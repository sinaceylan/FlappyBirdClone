using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moves : MonoBehaviour
{
    public float speed;
    private void Start()
    {
        Destroy(gameObject,5.5f);
    }

    private void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
