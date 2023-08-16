using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardModeSpawner : MonoBehaviour
{
    public GameObject[] cubes;
    public Transform[] points;
    public float beat = 1;
    float timer;

    // Update is called once per frame
    void Update()
    {
        if (timer > beat)
        {
            int cubeIndex = Random.Range(0, cubes.Length);
            int pointIndex = Random.Range(0, points.Length);

            GameObject cube = Instantiate(cubes[cubeIndex], points[pointIndex]);

            cube.transform.localPosition = Vector3.zero;

            cube.transform.Rotate(transform.forward, 90 * Random.Range(0, 4));

            timer -= beat;
        }

        timer += Time.deltaTime;
    }
}
