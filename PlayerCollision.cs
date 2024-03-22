using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    // Fungsi ini dipanggil ketika terjadi tabrakan dengan collider lain
    void OnCollisionEnter2D(Collision2D collision)
    {
        // Jika yang ditabrak memiliki tag "Obstacle" (atau tag lain yang Anda tentukan untuk rintangan)
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Pemain mati, misalnya dengan memuat ulang scene
            KillPlayer();
        }
    }

    void KillPlayer()
    {
        // Tambahkan logika yang sesuai ketika pemain mati,
        // misalnya menampilkan layar kalah atau mengembalikan pemain ke titik awal
        Debug.Log("Player died!");

        // Misalnya, untuk memuat ulang scene (mengulang permainan)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
