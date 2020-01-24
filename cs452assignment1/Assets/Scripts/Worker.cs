/*
* Evan Meyer
* Worker.cs
* Assignment #1
* Abstract Worker base class with
* abstract work and printInfo methods
*/

public abstract class Worker
{
    private string name;
    private decimal salary;

    public Worker(string name, decimal salary)
    {
        this.name = name;
        this.salary = salary;
    }

    protected string getName() => name;
    protected decimal getSalary() => salary;

    public abstract void work();
    public abstract void printInfo();

}
