using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour
{

    [SerializeField]
    private GameObject bullet;
    private float lastFiredTime = 0f;
    [SerializeField]
    private float fireDelay = 1f;
    private float bulletOffset = 2f;

    void Start()
    {
        // Do some math to perfectly spawn bullets in front of us
        bulletOffset = GetComponent<Renderer>().bounds.size.y / 2 // Half of our size
            + bullet.GetComponent<Renderer>().bounds.size.y / 2; // Plus half of the bullet size
    }

    // Fire a bullet with delay between shots
    public void Shoot()
    {
        float currentTime = Time.time;

        // Have a delay so we don't shoot too many bullets
        if (currentTime - lastFiredTime > fireDelay)
        {
            // Calculate spawn position based on shooters position plus offset
            Vector2 spawnPosition = new Vector2(transform.position.x, transform.position.y + bulletOffset);
            Instantiate(bullet, spawnPosition, transform.rotation);
            lastFiredTime = currentTime;
        }
    }
}
