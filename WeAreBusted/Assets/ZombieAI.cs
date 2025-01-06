using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player; // Referencja do obiektu gracza
    public float moveSpeed = 5f; // Prêdkoœæ poruszania siê przeciwnika
    public float followDistance = 10f; // Dystans, w którym przeciwnik zaczyna pod¹¿aæ za graczem

    void Update()
    {
        // SprawdŸ, czy obiekt gracza istnieje
        if (player != null)
        {
            // Oblicz dystans do gracza
            float distanceToPlayer = Vector3.Distance(transform.position, player.position);

            // SprawdŸ, czy gracz jest w zasiêgu œledzenia
            if (distanceToPlayer <= followDistance)
            {
                // Oblicz kierunek do gracza
                Vector3 direction = player.position - transform.position;
                direction.y = 0;

                // Przemieszcz przeciwnika w kierunku gracza
                transform.position += direction * moveSpeed * Time.deltaTime;

                // Oblicz now¹ rotacjê w kierunku gracza
                Quaternion rotation = Quaternion.LookRotation(direction);

                // Obróæ przeciwnika w kierunku gracza
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * 5f);
            }
        }
    }
}