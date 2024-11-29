using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLocation : MonoBehaviour
{
    [SerializeField] Transform fireLocation;
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] GameObject prefab;

    public float spawnTime;
    public float spawnDelay;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnBullet", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
   
    }
    public void SpawnBullet()
    {
        if (prefab.GetComponent<PlayerController>().isShooting)
        {
            GameObject go = Instantiate(bulletPrefab);
            go.transform.position = fireLocation.position;
            //Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
        //bulletPrefab.transform.position = fireLocation.position;

        //GameObject go = Instantiate(bulletPrefab);
        //go.transform.position = fireLocation.position;
        //go.transform.rotation = fireLocation.rotation;
    }
}
