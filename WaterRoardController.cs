using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRoardController : MonoBehaviour
{
    public GameObject WaterRoard;
    public bool planeisvisible;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (planeisvisible == true)
        {
            WaterRoard.transform.Translate(Vector3.up * Time.deltaTime * 5);
        }
        if (WaterRoard.transform.position.y > 0.01f)
        {
            planeisvisible = false;
        }
    }
    void OnMouseDown()
    {
        planeisvisible = true;

    }
}
