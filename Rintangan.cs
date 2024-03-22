using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rintangan : MonoBehaviour
{
    public float moveSpeed = 3f;

    void Update()
    {
        // Pindahkan rintangan ke kiri
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        // Hapus rintangan jika sudah di luar layar
        if (transform.position.x < -19)
        {
            Destroy(gameObject);
        }
    }

    // Menangani deteksi tabrakan dengan karakter utama
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Logika yang harus dijalankan ketika karakter utama menabrak rintangan
            // Contoh: Mematikan permainan, mengurangi skor, atau efek lainnya
        }
    }
}