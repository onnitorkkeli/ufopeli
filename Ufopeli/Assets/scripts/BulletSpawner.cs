using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public Transform bulletSpawnPoint1;
    public Transform bulletSpawnPoint2;
    public Transform bulletSpawnPoint3;
    public Transform bulletSpawnPoint4;
    public Transform bulletSpawnPoint5;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public float fireRate = 5;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint1.position, bulletSpawnPoint1.rotation);
            bullet.GetComponent<Rigidbody2D>().linearVelocity = bulletSpawnPoint1.up * bulletSpeed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint2.position, bulletSpawnPoint2.rotation);
            bullet.GetComponent<Rigidbody2D>().linearVelocity = bulletSpawnPoint2.up * bulletSpeed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint3.position, bulletSpawnPoint3.rotation);
            bullet.GetComponent<Rigidbody2D>().linearVelocity = bulletSpawnPoint3.up * bulletSpeed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint4.position, bulletSpawnPoint4.rotation);
            bullet.GetComponent<Rigidbody2D>().linearVelocity = bulletSpawnPoint4.up * bulletSpeed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint5.position, bulletSpawnPoint5.rotation);
            bullet.GetComponent<Rigidbody2D>().linearVelocity = bulletSpawnPoint5.up * bulletSpeed;
        }
    }
}

