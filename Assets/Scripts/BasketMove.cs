using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMove : MonoBehaviour
{
    private Transform position;
    private Controller controller;
    void Start()
    {
        position = GetComponent<Transform>();
        Controller.mousePosition += Move;
    }

    private void Move(Vector3 MousePosition)
    {
        Vector3 pos = position.position;
        pos.x = MousePosition.x;
        position.position = pos;
    }
}
