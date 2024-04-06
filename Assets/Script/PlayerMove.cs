using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    float Speed=5f;
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 h = new Vector3(x, y, 0);
        transform.position += h * Speed * Time.deltaTime;
    }
}
