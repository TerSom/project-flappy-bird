using UnityEngine;

public class PipeRespawner : MonoBehaviour
{
    public GameObject pipePrefab; // Prefab untuk pipa
    public float respawnTime = 2f; // Waktu respawn (detik antara setiap respawn)
    public float respawnOffset = 4f; // Jarak respawn dari titik respawn
    public float minY = -2f; // Ketinggian minimum respawn pipa
    public float maxY = 2f; // Ketinggian maksimum respawn pipa

    private float nextRespawnTime = 0f;

    void Start()
    {
        // Menjadwalkan respawn pertama saat permainan dimulai
        ScheduleRespawn();

        // Respawn pipa pertama kali saat permainan dimulai
        RespawnPipe();
    }

    void Update()
    {
        // Jika waktu berikutnya untuk respawn telah tiba
        if (Time.time >= nextRespawnTime)
        {
            // Respawn pipa
            RespawnPipe();

            // Jadwalkan respawn berikutnya
            ScheduleRespawn();
        }
    }

    void ScheduleRespawn()
    {
        // Hitung waktu berikutnya untuk respawn
        nextRespawnTime = Time.time + respawnTime;
    }

    void RespawnPipe()
    {
        // Hitung posisi respawn pipa secara acak
        float randomY = Random.Range(minY, maxY);
        Vector3 respawnPosition = transform.position + Vector3.up * randomY + Vector3.right * respawnOffset;

        // Instansiasi pipa di posisi respawn
        Instantiate(pipePrefab, respawnPosition, Quaternion.identity);
    }
}
