using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5f;
    public AudioClip jumpSound;

    private Rigidbody2D rb;
    private AudioSource audioSource;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Cek input klik mouse atau sentuhan layar
        if (Input.GetMouseButtonDown(0)) // 0 adalah tombol kiri mouse
        {
            Jumpa();
        }
    }

    void Jumpa()
    {
        // Beri gaya lompat ke Rigidbody
        rb.velocity = Vector2.up * jumpForce;
        
        // Memutar suara lompat
        audioSource.PlayOneShot(jumpSound);
    }

}

