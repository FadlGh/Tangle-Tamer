using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public GameObject[] corridorPrefabs; 
    public Transform playerTransform; 
    public float corridorWidth; 

    private float spawnX = -24f; 

    private void Start()
    {
        for (int i = 0; i < 2; i++)
        {
            GameObject corridorSection = Instantiate(corridorPrefabs[0], transform);
            corridorSection.transform.position = new Vector3(spawnX, 0f, 0f);

            spawnX += corridorWidth;
        }
    }

    private void Update()
    {
        if (playerTransform.position.x > spawnX - 3 * corridorWidth)
        {
            SpawnCorridorSection();
        }
    }

    private void SpawnCorridorSection()
    {
        int randomIndex = Random.Range(1, corridorPrefabs.Length);

        GameObject corridorSection = Instantiate(corridorPrefabs[randomIndex], transform);
        corridorSection.transform.position = new Vector3(spawnX, 0f, 0f);

        spawnX += corridorWidth;
    }
}
