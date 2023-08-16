using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public int speed = 0;

    void Update()
    {
        transform.position += Time.deltaTime * transform.forward * speed;
    }

}
