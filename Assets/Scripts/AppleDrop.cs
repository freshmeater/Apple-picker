using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AppleDrop : MonoBehaviour
{
    public static event Action onAppleDrop;
    public GameObject ApplePref;
    private float SecondsBetweenAppleDrops = 1f;
    private Transform Position; 

    void Start()
    {
        Position = GetComponent<Transform>();
        InvokeRepeating("DropApple", 2f, SecondsBetweenAppleDrops);
    }

    private void DropApple()
    {
        Instantiate(ApplePref, Position.position, Position.rotation);
        onAppleDrop?.Invoke();
    }
}