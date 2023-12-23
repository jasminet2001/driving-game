using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    //private Rigidbody rb;
    public float speed = 5.0f;
    private float forwardInput;
    private float horizontalInput;
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
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
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("entered");
        }

    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("exit");
    }
}
