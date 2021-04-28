using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    private static float BottomEdge = -20f;
    private Transform Position;

    private void Start()
    {
        Position = GetComponent<Transform>();
    }

    void Update()
    {
        CheckForDropOut();
    }

    private void CheckForDropOut()
    {
        if (BottomEdge > Position.position.y)
        {
            Destroy(this.gameObject);
        }
    }
}
