using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMove : MonoBehaviour
{
    private Transform Position;
    public Controller Controller;
    void Start()
    {
        Position = GetComponent<Transform>();
        Controller = Controller.GetController;
        Controller.MousePosition += Move;
    }

    private void Move(Vector3 MousePosition)
    {
        Vector3 pos = Position.position;
        pos.x = MousePosition.x;
        Position.position = pos;
        ;
    }
}
