using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 5.0f;
    private float forwardInput;
    private float horizontalInput;
    private GameObject lights;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        lights = GameObject.Find("Spot Light");
        Debug.Log(lights);
        lights.SetActive(false);
    }


    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Arch" || other.gameObject.name == "Arch2" || other.gameObject.name == "Arch3")
        {
            lights.SetActive(true);
        }
        else
        {
            lights.SetActive(false);
        }
    }

}
