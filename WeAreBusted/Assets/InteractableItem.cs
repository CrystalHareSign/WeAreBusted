using UnityEngine;

public class InteractableItem : MonoBehaviour, IInteractable
{
    public string itemName; // Nazwa przedmiotu

    public void Interact()
    {
        // Wykonaj akcjê interakcji (np. podnieœ przedmiot, otwórz drzwi)
        Debug.Log("Interakcja z przedmiotem: " + itemName);
    }
}