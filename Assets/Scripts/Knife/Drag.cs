using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    private Vector3 offset;
    public float sensity;
    private Vector3 firstPos;

    private void Start()
    {
        firstPos = transform.position;
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            offset = MousePos() - new Vector3(transform.position.x, 2, transform.position.z);
        }
        if (Input.GetMouseButton(0))
        {
            Vector3 directMove = MousePos() - offset;
            transform.position = directMove * sensity;
        }
        if (Input.GetMouseButtonUp(0))
        {
            transform.position = firstPos;
        }
    }

    public Vector3 MousePos()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 10;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);
        mousePos.y = 0;
        return mousePos;
    }
}