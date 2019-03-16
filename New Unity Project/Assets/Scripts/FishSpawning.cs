using UnityEngine;

public class FishSpawning : MonoBehaviour
{
    public GameObject Fish;
    public GameObject boundryR;
    public GameObject boundryL;
    float randX;
    Vector2 whereToSpawn;
    public float spawnRate = 2f;
    //float nextSpawn = 0.0f;
    float timer;

    void Update()
    {
        SpawnFish();
    }

    private void SpawnFish()
    {
        timer = timer + Time.deltaTime;
        Debug.Log(timer);
        if (timer > spawnRate)
        {
            randX = Random.Range(boundryL.transform.position.x, boundryR.transform.position.x);
            whereToSpawn = new Vector2(randX, transform.position.y);
            Instantiate(Fish, whereToSpawn, Quaternion.identity);
            timer = 0f;
        }
    }




    //public GameObject spawn;
    //float nextSpawn = 1f;
    //public float spawnRate = 2f;
    //Vector2 whereToSpawn;
    //float randX;
    //float timer;

    //// Update is called once per frame
    //void Update()
    //{
    //    SpawnFish();
    //}

    //private void SpawnFish()
    //{
    //    timer = timer + Time.deltaTime;
    //    // timer += Time.deltaTime

    //    if (timer > spawnRate)
    //    {
    //        nextSpawn = Time.deltaTime + spawnRate;
    //        randX = Random.Range(-8f, 8f);
    //        whereToSpawn = new Vector2(randX, transform.position.y);
    //        Instantiate(spawn, whereToSpawn, Quaternion.identity);
    //        timer = 0f;
    //        Debug.Log("Fishes are spawning");
    //    }
    //}
}