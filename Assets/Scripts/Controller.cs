using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public static Controller GetController { get; private set; }

    public event Action<Vector3> MousePosition;
    private void Start()
    {
        GetController = this;
    }
    void Update()
    {
        Vector3 a = Input.mousePosition;
        a.z = Camera.main.transform.position.z;
        MousePosition?.Invoke(Camera.main.ScreenToWorldPoint(a));
    }
}
