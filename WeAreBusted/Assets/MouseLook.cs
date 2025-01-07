using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    public Transform cameraTransform; //
    public Transform weaponTransform; //

    float xRotation = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        cameraTransform = Camera.main.transform; //
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);

        weaponTransform.position = cameraTransform.position;
        weaponTransform.rotation = cameraTransform.rotation;
    }
}
