using UnityEngine;
using System.Collections;

public class RockMover : MonoBehaviour
{

    public float delta = 30f;  
    public float speed = 10.0f;
    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        Vector3 v = startPos;
        v.z += delta * Mathf.Sin(Time.time * speed);
        transform.position = v;
    }
}