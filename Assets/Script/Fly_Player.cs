using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly_Player : MonoBehaviour
{
    Rigidbody2D rb;
    public float Speed =10f;
    bool canJump = true;
    Animator animator;
    public float JumpSpeed = 7.5f;
    int JumpCount = 0;
    public AudioSource audio;
    public GameObject GameOver;
    public GameObject Splash;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (JumpCount == 2)
        {
            canJump = false;
        }
        transform.position = Vector3.right * Speed * Time.deltaTime + transform.position;

        if (Input.touchCount > 0 && canJump == true)
        {
            rb.velocity = Vector3.up * Speed;
            animator.SetTrigger("Jump");
           // JumpCount += 1;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            JumpCount = 0;
            canJump = true;
        }
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            gameObject.SetActive(false);
            GameOver.SetActive(true);
            Vibration.Vibrate(25);
            audio.Play();
            Instantiate(Splash, transform.position, Quaternion.identity);
        }
    }
}
