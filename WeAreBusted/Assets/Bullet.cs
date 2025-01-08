using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 5f; // Czas ¿ycia kuli w sekundach

    void Start()
    {
        // Zniszcz obiekt po up³ywie ustalonego czasu
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Pobierz nazwê trafionego obiektu
        string hitObjectName = collision.gameObject.name;

        // Wyœwietl nazwê trafionego obiektu w konsoli
        Debug.Log("Kula trafi³a w: " + hitObjectName);

        // Zniszcz pocisk po kolizji
        Destroy(gameObject);
    }
}