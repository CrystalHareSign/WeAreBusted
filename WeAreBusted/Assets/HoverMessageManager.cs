using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HoverMessageManager : MonoBehaviour
{
    public TMP_Text messageText; // Tekst, kt�ry b�dzie wy�wietlany po najechaniu kursorem
    private Camera mainCamera;

    void Start()
    {
        // Ukryj tekst na pocz�tku
        if (messageText != null)
        {
            messageText.gameObject.SetActive(false);
        }
        // Pobierz g��wn� kamer�
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Rzutowanie promienia z pozycji kursora
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Sprawdzenie, czy promie� trafia w collider obiektu
        if (Physics.Raycast(ray, out hit))
        {
            HoverMessage hoverMessage = hit.transform.GetComponent<HoverMessage>();
            if (hoverMessage != null && hit.distance <= hoverMessage.interactionDistance)
            {
                // Wy�wietl komunikat po najechaniu kursorem na obiekt
                if (messageText != null)
                {
                    messageText.text = hoverMessage.message;
                    messageText.gameObject.SetActive(true);
                }
            }
            else
            {
                // Ukryj komunikat, je�li kursor nie jest nad obiektem
                if (messageText != null)
                {
                    messageText.gameObject.SetActive(false);
                }
            }
        }
        else
        {
            // Ukryj komunikat, je�li kursor nie jest nad obiektem
            if (messageText != null)
            {
                messageText.gameObject.SetActive(false);
            }
        }
    }
}