using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMove : MonoBehaviour
{
    private Transform Position;

    private float Speed = 2f;
    private float ChanceOfChangingDirection = 0.005f;
    private float Edges = 10f;
    
    void Start()
    {
        Position = GetComponent<Transform>();
    }

    
    void Update()
    {
        Move();
        TryChangeDirection();
    }

    private void Move()
    {
        Vector3 pos = Position.position;
        pos.x += Speed * Time.deltaTime;
        Position.position = pos;
    }

    private void TryChangeDirection()
    {
        if (IsDiretionChanging()) Speed *= -1;
    }

    private bool IsDiretionChanging() => !IsTreeInBorders() || RollChangeDirection();

    private bool IsTreeInBorders() => Mathf.Abs(Position.position.x) < Edges;

    private bool RollChangeDirection() => Random.value < ChanceOfChangingDirection;

}
