using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLight : MonoBehaviour
{
    [SerializeField] public Light lights;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Tunnel"))
        {
            Debug.Log("entered");
            lights.intensity = 90.0f;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");
        lights.intensity = 0.0f;
    }
}
