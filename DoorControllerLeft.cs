using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControllerLeft : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    Vector3 openPosition;

    // Start is called before the first frame update
    void Start()
    {
        openPosition = transform.position;
        openPosition.x += 3.95f;
    }

    // Update is called once per frame
    void Update()
    {
        if (prefab.GetComponent<PlayerController>().isTrapActive)
        {
            transform.position = Vector3.MoveTowards(transform.position, openPosition, 3.95f * Time.deltaTime);
        }
    }
}
