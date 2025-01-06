using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player; // Referencja do obiektu gracza
    public float moveSpeed = 5f; // Pr�dko�� poruszania si� przeciwnika
    public float followDistance = 10f; // Dystans, w kt�rym przeciwnik zaczyna pod��a� za graczem

    void Update()
    {
        // Sprawd�, czy obiekt gracza istnieje
        if (player != null)
        {
            // Oblicz dystans do gracza
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            // Sprawd�, czy gracz jest w zasi�gu �ledzenia
            if (distanceToPlayer <= followDistance)
            {
                // Oblicz kierunek do gracza
                Vector3 direction = player.position - transform.position;
                direction.y = 0;

                // Przemieszcz przeciwnika w kierunku gracza
                transform.position += direction * moveSpeed * Time.deltaTime;

                // Oblicz now� rotacj� w kierunku gracza
                Quaternion rotation = Quaternion.LookRotation(direction);

                // Obr�� przeciwnika w kierunku gracza
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 5f);
            }
        }
    }
}