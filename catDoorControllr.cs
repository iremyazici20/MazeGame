using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catDoorControllr : MonoBehaviour
{
    public GameObject catDoor;
    public bool doorIsVisible;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (doorIsVisible == true)
        {
            catDoor.transform.Translate(Vector3.up * Time.deltaTime * 100);
        }
        if (catDoor.transform.position.y > 12.01f)
        {
            doorIsVisible = false;
        }
    }
    void OnMouseDown()
    {
        doorIsVisible = true;

    }
}
