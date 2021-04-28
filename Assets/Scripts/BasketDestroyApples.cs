using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketDestroyApples : MonoBehaviour
{
    public event Action OnAppleCatched;
    private void OnCollisionEnter(Collision collision)
    {
        GameObject collidedWith = collision.gameObject; 
        if (collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);
            OnAppleCatched?.Invoke();
        }
    }
}
