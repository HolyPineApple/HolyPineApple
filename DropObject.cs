using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObject : MonoBehaviour
{
    public Score ScoreCanvas;
    private Vector3 offset;
    Rigidbody rbObj;
    public Vector3 direction;
    public float PushPower;
    bool TakeBox = true;
    private void Start()
    {
        rbObj = GetComponent<Rigidbody>();
    }
    void OnMouseDown()
    {
        if (TakeBox)
        {
            offset = gameObject.transform.position -
                Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
        }
    }

    void OnMouseDrag()
    {
        if (TakeBox)
        {
            Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
            transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
        }
    }

    private void OnMouseUp()
    {
        if (TakeBox)
        {
            ScoreCanvas.ScoreValue += 1;
            rbObj.AddForce(direction.normalized * PushPower, ForceMode.Impulse);
        }
        TakeBox = false;
    }
}
