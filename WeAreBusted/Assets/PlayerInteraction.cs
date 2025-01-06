using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionRange = 4f; // Zasiêg interakcji
    public LayerMask InteractableLayer; // Warstwa interaktywnych obiektów (ustaw w inspektorze)
    public Camera playerCamera;

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
        Debug.Log("Próba interakcji");

        // Wykonaj promieñ (raycast) z pozycji gracza do przodu
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, interactionRange, InteractableLayer))
        {
            Debug.Log("Coœ zosta³o trafione: " + hit.collider.name);

            // SprawdŸ, czy trafiony obiekt ma komponent IInteractable
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {
                Debug.Log("Interaktywny obiekt znaleziony: " + hit.collider.name);

                // Wywo³aj metodê interakcji
                interactable.Interact();
            }
            else
            {
                Debug.Log("Brak komponentu IInteractable na trafionym obiekcie");
            }
        }
        else
        {
            Debug.Log("Promieñ nie trafi³ w ¿aden obiekt");
        }
    }
}