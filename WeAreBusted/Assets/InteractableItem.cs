using UnityEngine;

public class InteractableItem : MonoBehaviour, IInteractable
{
    public string itemName; // Nazwa przedmiotu

    public void Interact()
    {
        // Wykonaj akcj� interakcji (np. podnie� przedmiot, otw�rz drzwi)
        Debug.Log("Interakcja z przedmiotem: " + itemName);
    }
}