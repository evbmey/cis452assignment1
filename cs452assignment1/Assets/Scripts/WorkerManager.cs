/*
* Evan Meyer
* WorkerManager.cs
* Assignment #1
* WorkerManager MonoBehaviour for creating lists of Worker classes
* and logging their functionality in response to user input
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerManager : MonoBehaviour
{

    private List<Worker> workers = new List<Worker>();
    private List<IDriver> drivers = new List<IDriver>();

    // Start is called before the first frame update
    public void Start()
    {
        TaxiDriver driver1 = new TaxiDriver("Devon", 32000m, 470000);
        driver1.printInfo();
        driver1.receiveTip(8m);

        PoliceOfficer officer1 = new PoliceOfficer("Dylan", 47500m, "Lieutenant");
        officer1.printInfo();
        officer1.shoot();

        Mailman mailman = new Mailman("Salim", 38250m);
        TaxiDriver driver2 = new TaxiDriver("Erik", 29000m, 250000);
        PoliceOfficer officer2 = new PoliceOfficer("Alexandria", 75000m, "Sergeant");

        workers.Add(driver1);
        workers.Add(officer1);
        workers.Add(driver2);
        workers.Add(officer2);
        workers.Add(mailman);

        drivers.Add(driver1);
        drivers.Add(officer1);
        drivers.Add(driver2);
        drivers.Add(officer2);
        drivers.Add(mailman);
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            foreach (Worker worker in workers)
            {
                worker.printInfo();
                worker.work();
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            foreach (IDriver driver in drivers)
            {
                driver.drive();
            }
        }
    }
}
