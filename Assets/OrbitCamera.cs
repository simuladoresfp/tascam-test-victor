using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCamera : MonoBehaviour
{
    private void OnOrbitEast()
    {
        //Orbitamos el objeto alrededor de la coordenada 0,0,0 hacia el este
        transform.RotateAround(Vector3.zero, Vector3.up, 90);
        transform.LookAt(Vector3.zero);
        Debug.Log("Orbiting East");
        
    }
}
