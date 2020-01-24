/*
* Evan Meyer
* PoliceOfficer.cs
* Assignment #1
* PoliceOfficer child class that inherits from Worker 
* and implements IDriver and IArmed
*/

using UnityEngine;

public class PoliceOfficer : Worker, IDriver, IArmed
{
    private string rank;

    public PoliceOfficer(string name, decimal salary, string rank) : base(name, salary)
    {
        this.rank = rank;
    }

    public override void work()
    {
        Debug.Log(string.Format("{0} is arresting a criminal.", getName()));
    }

    public override void printInfo()
    {
        Debug.Log(string.Format("{0}: Police Officer, ${1}/year, {2}", getName(), getSalary(), getRank()));
    }

    public string getRank() => rank;

    public void drive()
    {
        Debug.Log(string.Format("{0} is driving.", getName()));
    }

    public void shoot()
    {
        Debug.Log(string.Format("{0} is shooting.", getName()));
    }
}
