using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float Speed = 5f;
    void Update()
    {
        transform.Translate(0, Speed * Time.deltaTime, 0);
    }
   
}
