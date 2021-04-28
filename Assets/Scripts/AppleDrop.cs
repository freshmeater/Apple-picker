using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleDrop : MonoBehaviour
{
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
    }
}