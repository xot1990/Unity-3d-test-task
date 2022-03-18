using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public float speed;
    public float range;
    public GameObject mather;
    public Transform target;
    public Transform startPos;

    private Vector3 dir;

    
    void Start()
    {
        startPos = transform;
        dir = (target.position - startPos.position).normalized;
    }

    
    void Update()
    {
        transform.position += dir * Time.deltaTime * speed;

        
        if (Vector3.Distance(transform.position, mather.transform.position) >= range)
            Destroy(gameObject);
    }
}
