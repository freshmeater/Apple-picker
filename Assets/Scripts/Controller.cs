using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public static event Action<Vector3> mousePosition;

    void Update()
    {
        Vector3 a = Input.mousePosition;
        a.z = Camera.main.transform.position.z;
        mousePosition?.Invoke(Camera.main.ScreenToWorldPoint(a));
    }
}
