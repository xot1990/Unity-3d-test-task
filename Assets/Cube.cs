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

    
    void Start()
    {
        startPos = transform;
    }

    
    void Update()
    {
        transform.Translate((target.position - startPos.position).normalized * Time.deltaTime * speed);

        Debug.Log(Vector3.Distance(transform.position, mather.transform.position));
        if (Vector3.Distance(transform.position, mather.transform.position) >= range)
            Destroy(gameObject);
    }
}
