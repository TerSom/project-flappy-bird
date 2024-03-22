using UnityEngine;
using UnityEngine.UI;

public class PointManager : MonoBehaviour
{
    public Text scoreText; // Referensi ke UI Text untuk menampilkan skor
    private int score = 0; // Variabel untuk menyimpan skor

    // Fungsi ini dipanggil ketika objek lain menyentuh trigger (memasuki collider dengan isTrigger diaktifkan)
    void OnTriggerEnter2D(Collider2D other)
    {
        // Jika yang menyentuh memiliki tag "Player" (atau tag lain yang Anda tetapkan untuk pemain)
        if (other.CompareTag("Player"))
        {
            // Tambahkan satu poin
            AddScore(1); // Misalnya, tambahkan 1 poin setiap kali pemain melewati objek
        }
    }

    void AddScore(int points)
    {
        // Tambahkan poin
        score += points;

        // Perbarui tampilan skor di UI Text
        scoreText.text = "Score: " + score.ToString();
    }
}

