using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionRange = 4f; // Zasi�g interakcji
    public LayerMask interactableLayer; // Warstwa interaktywnych obiekt�w (ustaw w inspektorze)
    public bool inRange;

    void Update()
    {
        // Sprawd�, czy gracz naciska przycisk interakcji (domy�lnie "E")
        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    void Interact()
    {
        // Wykonaj promie� (raycast) z pozycji gracza do przodu
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, interactionRange, interactableLayer))
        {
            // Sprawd�, czy trafiony obiekt ma komponent IInteractable
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {
                inRange = true;
                Debug.Log("jest w zasi�gu");

                // Wywo�aj metod� interakcji
                interactable.Interact();
            }
        }
    }
}