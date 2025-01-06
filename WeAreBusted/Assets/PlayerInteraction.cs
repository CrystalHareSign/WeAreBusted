using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactionRange = 4f; // Zasi�g interakcji
    public LayerMask InteractableLayer; // Warstwa interaktywnych obiekt�w (ustaw w inspektorze)
    public Camera playerCamera;

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
        Debug.Log("Pr�ba interakcji");

        // Wykonaj promie� (raycast) z pozycji gracza do przodu
        RaycastHit hit;
        if (Physics.Raycast(playerCamera.transform.position, playerCamera.transform.forward, out hit, interactionRange, InteractableLayer))
        {
            Debug.Log("Co� zosta�o trafione: " + hit.collider.name);

            // Sprawd�, czy trafiony obiekt ma komponent IInteractable
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {
                Debug.Log("Interaktywny obiekt znaleziony: " + hit.collider.name);

                // Wywo�aj metod� interakcji
                interactable.Interact();
            }
            else
            {
                Debug.Log("Brak komponentu IInteractable na trafionym obiekcie");
            }
        }
        else
        {
            Debug.Log("Promie� nie trafi� w �aden obiekt");
        }
    }
}