using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    private float Speed = 5f;
    private float scorll = 9.5f;
    public Transform target;
    void Update()
    {
        transform.position += Vector3.down * Speed * Time.deltaTime;
        if (transform.position.y <= -scorll)
        {
            transform.position = target.position + Vector3.up * scorll;
        }
    }
}
