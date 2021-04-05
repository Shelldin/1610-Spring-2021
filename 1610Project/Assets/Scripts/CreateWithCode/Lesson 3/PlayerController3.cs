using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3 : MonoBehaviour
{
    private Rigidbody playerRb;
    private Animator playerAnim;

    private AudioSource playerAudio;

    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;
    public AudioClip crashSound;
    
    public float jumpForce = 10f;
    public float gravityModifier = 1f;
    public bool grounded;
    public bool gameOver = false;
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
        playerAnim = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && grounded && !gameOver )
        {
          playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
          grounded = false;
          playerAnim.SetTrigger("Jump_trig");
          dirtParticle.Stop();
          playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            grounded = true;
            dirtParticle.Play();
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParticle.Stop();
            playerAudio.PlayOneShot(crashSound, 1f);
        }
    }
}
