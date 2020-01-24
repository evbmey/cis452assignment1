/*
* Evan Meyer
* TaxiDriver.cs
* Assignment #1
* TaxiDriver child class that inherits from Worker 
* and implements ITippable and IDriver
*/

using UnityEngine;

public class TaxiDriver : Worker, ITippable, IDriver
{
    private int milesDriven;

    public TaxiDriver(string name, decimal salary, int milesDriven) : base(name, salary)
    {
        this.milesDriven = milesDriven;
    }
    
    public override void work()
    {
        Debug.Log(string.Format("{0} is transporting a passenger.", getName()));
    }

    public override void printInfo()
    {
        Debug.Log(string.Format("{0}: Taxi Driver, ${1}/year, {2} miles", getName(), getSalary(), getMilesDriven()));
    }

    public int getMilesDriven() => milesDriven;

    public void receiveTip(decimal amount)
    {
        Debug.Log(string.Format("{0} was tipped ${1}.", getName(), amount));
    }

    public void drive()
    {
        Debug.Log(string.Format("{0} is driving.", getName()));
    }

}
