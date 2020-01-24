/*
* Evan Meyer
* Mailman.cs
* Assignment #1
* Mailman child class that inherits from Worker 
* and implements IDriver
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mailman : Worker, IDriver
{
    public Mailman(string name, decimal salary) : base(name, salary) { }

   public override void work()
    {
        Debug.Log(string.Format("{0} is delivering a package.", getName()));
    }

    public override void printInfo()
    {
        Debug.Log(string.Format("{0}: Mailman, ${1}/year", getName(), getSalary()));
    }

    public void drive()
    {
        Debug.Log(string.Format("{0} is driving.", getName()));
    }
}
