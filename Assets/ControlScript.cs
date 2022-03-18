using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ControlScript : MonoBehaviour
{
    public InputField spawnTime;
    public InputField rangeOfFlight;
    public InputField cubeSpeed;

    public GameObject cubePrefab;
    public Transform flyingTarget;

    public float _spawnTime;
    public float _rangeOfFlight;
    public float _cubeSpeed;

    public bool isStarting;

    private float timer;

    void Start()
    {
        
    }

    
    void Update()
    {       

        if (isStarting)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                GameObject simpleCube = Instantiate(cubePrefab, transform.position, Quaternion.identity);
                Cube cube = simpleCube.GetComponent<Cube>();

                cube.speed = _cubeSpeed;
                cube.range = _rangeOfFlight;
                cube.mather = gameObject;
                cube.target = flyingTarget;

                timer = _spawnTime;
            }
        }
    }

    public void ApplySettings()
    {
        float.TryParse(spawnTime.text, out _spawnTime);
        float.TryParse(cubeSpeed.text, out _cubeSpeed);
        float.TryParse(rangeOfFlight.text, out _rangeOfFlight);
        
        timer = _spawnTime;
        isStarting = true;
    }
}
