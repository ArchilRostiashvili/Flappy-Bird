using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle_Spawn : MonoBehaviour
{
    [SerializeField] private float collumn_speed;

    private void Update()
    {
        transform.position += Vector3.left * collumn_speed * Time.deltaTime;
    }
}
