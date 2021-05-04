using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMove : MonoBehaviour
{
    private Transform position;

    private float speed = 2f;
    private float chanceOfChangingDirection = 0.005f;
    private float edges = 10f;
    
    void Start()
    {
        position = GetComponent<Transform>();
    }

    
    void Update()
    {
        Move();
        TryChangeDirection();
    }

    private void Move()
    {
        Vector3 pos = position.position;
        pos.x += speed * Time.deltaTime;
        position.position = pos;
    }

    private void TryChangeDirection()
    {
        if (IsDiretionChanging()) speed *= -1;
    }

    private bool IsDiretionChanging() => !IsTreeInBorders() || RollChangeDirection();

    private bool IsTreeInBorders() => Mathf.Abs(position.position.x) < edges;

    private bool RollChangeDirection() => Random.value < chanceOfChangingDirection;

}
