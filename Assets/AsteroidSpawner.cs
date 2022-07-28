using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] GameObject asteroidMesh;

    private const int numberOfAsteroids = 1000;
    private const int seed = 141141711;
    private const float yMax = 50f;
    private float innerRadius = 900f;
    private float outerRadius = 2000f;

    private Vector3 spawnPosition;

    private float radius;

    private float radian;
    private float torusHeight;

    private GameObject astroid;


    // Start is called before the first frame update
    void Start()
    {
        Random.InitState(seed);


        for (int i = 0; i < numberOfAsteroids; i++)
        {
            radius = Random.Range(innerRadius, outerRadius);
            radian = Random.Range(0, (2 * Mathf.PI));
            torusHeight = Random.Range(-yMax, yMax);
            spawnPosition.x = radius * Mathf.Cos(radian);
            spawnPosition.z = radius * Mathf.Sin(radian);
            spawnPosition.y = torusHeight;
            astroid = Instantiate(asteroidMesh, spawnPosition + transform.position, Random.rotation, transform);
            astroid.transform.localScale = new Vector3(Random.Range(1f, 10f), Random.Range(1f, 10f), Random.Range(1f, 10f));
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
