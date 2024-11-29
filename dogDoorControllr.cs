using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogDoorControllr : MonoBehaviour
{
    public GameObject dogDoor;
    public bool doorIsVisible;
    public GameObject downTrap;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (doorIsVisible == true)
        {
            dogDoor.transform.Translate(Vector3.up * Time.deltaTime * 100);
        }
        if (dogDoor.transform.position.y > 12.01f)
        {
            doorIsVisible = false;
        }

        if(doorIsVisible == true)
        {
            downTrap.GetComponent<Rigidbody>().useGravity = true;
        }
    }
    void OnMouseDown()
    {
        doorIsVisible = true;

    }
    
}
