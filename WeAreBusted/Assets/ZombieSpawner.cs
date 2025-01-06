using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab przeciwnika, kt�ry b�dzie spawnowany
    public float spawnInterval = 5f; // Czas mi�dzy spawnami przeciwnik�w w sekundach
    public int maxEnemies = 10; // Maksymalna liczba przeciwnik�w, kt�rzy mog� by� na scenie jednocze�nie
    private int currentEnemyCount = 0; // Obecna liczba przeciwnik�w na scenie
    public bool spawnEnabled;

    void Start()
    {
        if (spawnEnabled)
        // Uruchom powtarzaj�ce si� zadanie spawnuj�ce przeciwnik�w
        InvokeRepeating("SpawnEnemy", spawnInterval, spawnInterval);
    }

    void SpawnEnemy()
    {
        // Sprawd�, czy liczba przeciwnik�w na scenie nie przekracza maksymalnej liczby
        if (currentEnemyCount < maxEnemies)
        {
            // Stw�rz nowego przeciwnika w miejscu spawnera
            Instantiate(enemyPrefab, transform.position, transform.rotation);
            currentEnemyCount++;
        }
    }

    // Metoda do zmniejszania licznika przeciwnik�w
    public void EnemyDestroyed()
    {
        if (currentEnemyCount > 0)
        {
            currentEnemyCount--;
        }
    }
}