using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefabrykat pocisku
    public Transform firePoint; // Punkt, z kt�rego b�d� wystrzeliwane pociski
    public float bulletSpeed = 200f; // Pr�dko�� pocisku

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Tworzenie pocisku w punkcie wystrza�u
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.linearVelocity = firePoint.forward * bulletSpeed;
    }
}