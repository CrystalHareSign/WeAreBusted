using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Prefab przeciwnika, który bêdzie spawnowany
    public float spawnInterval = 5f; // Czas miêdzy spawnami przeciwników w sekundach
    public int maxEnemies = 10; // Maksymalna liczba przeciwników, którzy mog¹ byæ na scenie jednoczeœnie
    private int currentEnemyCount = 0; // Obecna liczba przeciwników na scenie
    public bool spawnEnabled;

    void Start()
    {
        if (spawnEnabled)
        // Uruchom powtarzaj¹ce siê zadanie spawnuj¹ce przeciwników
        InvokeRepeating("SpawnEnemy", spawnInterval, spawnInterval);
    }

    void SpawnEnemy()
    {
        // SprawdŸ, czy liczba przeciwników na scenie nie przekracza maksymalnej liczby
        if (currentEnemyCount < maxEnemies)
        {
            // Stwórz nowego przeciwnika w miejscu spawnera
            Instantiate(enemyPrefab, transform.position, transform.rotation);
            currentEnemyCount++;
        }
    }

    // Metoda do zmniejszania licznika przeciwników
    public void EnemyDestroyed()
    {
        if (currentEnemyCount > 0)
        {
            currentEnemyCount--;
        }
    }
}