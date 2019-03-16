using UnityEngine;

public class FishSpawning : MonoBehaviour
{
    public GameObject Fisch;
    public GameObject boundryR;
    public GameObject boundryL;
    public GameObject boundryLU;
    public GameObject boundryRU;
    float randX;
    float randY;
    Vector4 whereToSpawn;
    public float spawnRate = 3f;
    float timer;

    void Update()
    {
        SpawnFish();
    }

    private void SpawnFish()
    {
            randX = Random.Range(boundryL.transform.position.x, boundryR.transform.position.x);
            Debug.Log("spawn up");
            randY = Random.Range(boundryLU.transform.position.y, boundryRU.transform.position.y);
            whereToSpawn = new Vector4(randX, randY, transform.position.x, transform.position.y);
            Debug.Log("fish spawn down");
            Instantiate(Fisch, whereToSpawn, Quaternion.identity);
            timer = 0f;
    }
    }