using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float Speed;
    bool canJump =true;
    Animator animator;
    public float JumpSpeed = 7.5f;
    int JumpCount = 0;
    public GameObject GameOver;
    public GameObject Splash;
    public AudioSource audio;
    public GameObject Boost;
    private GameObject Cloud;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        Cloud = GameObject.Find("Cloud");
    }
    private void Update()
    {
        if(JumpCount==2)
        {
            canJump = false;
        }
        transform.position = Vector3.right * Speed*Time.deltaTime + transform.position;
     
        if (Input.touchCount >0 && canJump==true)
        {
            rb.velocity = Vector3.up *JumpSpeed;
            animator.SetTrigger("Jump");
            JumpCount += 1 ;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > 5)
        {
            Boost = Instantiate(Resources.Load("Prefabs/Cloud"), transform.position, transform.rotation) as GameObject;


        }
        if (collision.gameObject.CompareTag("ground"))
        {
            JumpCount = 0;
            canJump = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameObject.SetActive(false);
            Instantiate(Splash, transform.position, Quaternion.identity);
            Vibration.Vibrate(25);
            audio.Play();
            GameOver.SetActive(true);
            
        }

    }
   
}
