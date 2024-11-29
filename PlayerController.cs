using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRB;
    Animator playerAnimator;

    public bool isTrapActive = false;
    bool isHolding = false;
    public bool isShooting = false;
    public bool isBulletActive = false;
    public bool isFalling = false;

    [SerializeField] GameObject LaternHolding;
    [SerializeField] GameObject Player;

    public float speed = 5;
    public float RotationSpeed = 60;

    // Start is called before the first frame update
    void Start()
    {
        playerRB = gameObject.GetComponent<Rigidbody>();
        playerAnimator = gameObject.GetComponentInChildren<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Rotate(new Vector3(0, 1, 0) * RotationSpeed * Time.deltaTime * h);

        playerRB.velocity = transform.forward * v * speed;
        
        //playerRB.velocity = new Vector3(h, 0, v)*speed;
        
        

        //playerAnimator.SetFloat("Speed", playerRB.velocity.magnitude);

        bool running = Mathf.Abs(v) > 0.1f || Mathf.Abs(h) > 0.1f;
        playerAnimator.SetBool("isRunning", running);

        playerAnimator.SetFloat("xSpeed", h);
        playerAnimator.SetFloat("zSpeed", v);

        if (isHolding == true)
        {
            HoldLatern();
        }

        if(Input.GetMouseButtonDown(1) && isHolding == false)
        {
            Debug.Log("You didn't take the latern yet.");
        }
        
       
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Latern")
        {
            Destroy(collision.gameObject);
            Debug.Log("Hold RMB to use the latern");
            isHolding = true;
        }
        if (collision.gameObject.tag == "TrapBlock")
        {
            isTrapActive = true;
            Debug.Log("Trap is active");
        }
        if (collision.gameObject.tag == "Doors")
        {
            Destroy(Player);
            Debug.Log("GG");
            SceneManager.LoadScene(0);
        }
        if(collision.gameObject.tag == "Wire")
        {
            isShooting = true;
            isBulletActive = true;
        }
        if(collision.gameObject.tag == "Bullet")
        {
            Destroy(Player);
            SceneManager.LoadScene(0);
        }
        /*
        if(collision.gameObject.tag == "FallingBlocks")
        {
            isFalling = true;
        }
        */
        if (collision.gameObject.tag == "Water")
        {
            Destroy(Player);
            SceneManager.LoadScene(0);
        }
        if(collision.gameObject.tag == "BlackHole")
        {
            Destroy(Player);
            SceneManager.LoadScene(0);
        }
        if(collision.gameObject.tag == "DownTrap")
        {
            Destroy(Player);
            SceneManager.LoadScene(0);
        }
    }

    void HoldLatern()
    {
        if (Input.GetMouseButton(1))
        {
            LaternHolding.SetActive(true);
        }
        else 
        {
            LaternHolding.SetActive(false);
        }
    }
}
