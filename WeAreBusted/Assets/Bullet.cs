using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float lifeTime = 5f; // Czas �ycia kuli w sekundach

    void Start()
    {
        // Zniszcz obiekt po up�ywie ustalonego czasu
        Destroy(gameObject, lifeTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // Pobierz nazw� trafionego obiektu
        string hitObjectName = collision.gameObject.name;

        // Wy�wietl nazw� trafionego obiektu w konsoli
        Debug.Log("Kula trafi�a w: " + hitObjectName);

        // Zniszcz pocisk po kolizji
        Destroy(gameObject);
    }
}