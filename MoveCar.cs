using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCar : MonoBehaviour
{
    public Rigidbody rbCar;
    public float SpeedCar;
    public Vector3 direction;
    public GameObject GameOver;
    void FixedUpdate()
    {
        rbCar.AddForce(direction * SpeedCar, ForceMode.Force);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Box"))
        {
            SpeedCar = 0;
            GameOver.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Finish"))
        {
            SpeedCar = 0;       
            GameOver.SetActive(true);
        }
    }
}
