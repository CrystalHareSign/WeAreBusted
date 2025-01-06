using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionRange = 4f; // Zasiêg interakcji
    public LayerMask interactableLayer; // Warstwa interaktywnych obiektów (ustaw w inspektorze)
    public bool inRange;

    void Update()
    {
        // SprawdŸ, czy gracz naciska przycisk interakcji (domyœlnie "E")
        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    void Interact()
    {
        // Wykonaj promieñ (raycast) z pozycji gracza do przodu
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, interactionRange, interactableLayer))
        {
            // SprawdŸ, czy trafiony obiekt ma komponent IInteractable
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {
                inRange = true;
                Debug.Log("jest w zasiêgu");

                // Wywo³aj metodê interakcji
                interactable.Interact();
            }
        }
    }
}