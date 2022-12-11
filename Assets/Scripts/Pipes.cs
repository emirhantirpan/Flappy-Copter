using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed = 4f;
    private float _border;

    private void Start()
    {
        _border = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1f;
    }


    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < _border)
        {
            Destroy(gameObject);
        }
    }


}
