using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 10;
    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        /*
        Vector3 pos = transform.position;
        pos += transform.forward * Speed * Time.deltaTime;
        transform.position = pos;
        //transform.Translate(transform.forward * Speed * Time.deltaTime);
        */
        transform.Translate(new Vector3(1, 0, 0) * Speed * Time.deltaTime, Space.World);
    }
}
