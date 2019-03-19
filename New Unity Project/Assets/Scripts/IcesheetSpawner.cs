using UnityEngine;

public class IcesheetSpawner : MonoBehaviour {

    public GameObject Icesheet;
    public GameObject boundryR;
    public GameObject boundryL;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 3f;
    float timer;

    void Update()
    {
        SpawnIcesheet();
    }

    private void SpawnIcesheet()
    {
        randX = Random.Range(boundryL.transform.position.x, boundryR.transform.position.x);
        Debug.Log("Icesheet");
        Instantiate(Icesheet, whereToSpawn, Quaternion.identity);
        timer = 0f;
    }
}