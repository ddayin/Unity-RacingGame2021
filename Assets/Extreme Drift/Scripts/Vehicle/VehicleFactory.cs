using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WanzyeeStudio;

public class VehicleFactory : MonoBehaviour
{
    public static VehicleFactory instance
    {
        get { return Singleton<VehicleFactory>.instance; }
    }

    public GameObject[] CarsPrefabs;
    public Transform startPoint;

    public void Create()
    {
        GameObject InstantiatedCar = Instantiate(CarsPrefabs[PlayerPrefs.GetInt("CurrentVehicle")], startPoint.position, startPoint.rotation) as GameObject;
    }
}
