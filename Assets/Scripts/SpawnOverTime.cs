using UnityEngine;
using System.Collections;

public class SpawnOverTime : MonoBehaviour
{

    // Object to spawn
    [SerializeField]
    private GameObject spawnObject;
    // Delay between spawns
    [SerializeField]
    private float spawnDelay = 2f;
    private Renderer ourRenderer;

    // Use this for initialization
    void Start()
    {
        ourRenderer = GetComponent<Renderer>();
        // Stop our Spawner from being visible
        ourRenderer.enabled = false;
        // Call the given function after spawnDelay seconds, and then repeatedly call it after spawnDelay seconds
        InvokeRepeating("Spawn", spawnDelay, spawnDelay);
    }

    //Spawns an object a random position within boundries
    void Spawn()
    {
        // Calculate spawn boundries
        float min = transform.position.x - ourRenderer.bounds.size.x / 2;
        float max = transform.position.x + ourRenderer.bounds.size.x / 2;

        // Randomly pick a point within the spawn object
        Vector2 spawnPoint = new Vector2(Random.Range(min, max), transform.position.y);

        // Spawn the object at the 'spawnPoint' position
        Instantiate(spawnObject, spawnPoint, Quaternion.identity);
    }
}
