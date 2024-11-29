using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLeft : MonoBehaviour
{
    public float Speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(-1, 0, 0) * Speed * Time.deltaTime, Space.World);
    }
}
