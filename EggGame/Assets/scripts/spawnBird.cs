using UnityEngine;

public class spawnBird : MonoBehaviour
{
    [SerializeField] private Vector3 spawnPosition1;
    [SerializeField] private Vector3 spawnPosition2;
    [SerializeField] private GameObject birdPrefab;
    private float spawnRate = 3;
    private float timer = 0;

    void Start()
    {
        RandomSpawn();
    }

    // Update is called once per frame
    void Update()
    {   
        if(timer < spawnRate){
            timer = timer + Time.deltaTime;
        }
        else{
            RandomSpawn();
            timer = 0;
        }
    }

    private void RandomSpawn()
    {
        int spawnNum = Random.Range(1, 3);
        if(spawnNum == 1){
            spawnBirdAt(spawnPosition1);
        }
        else{
            spawnBirdAt(spawnPosition2);
        }
    }

    private void spawnBirdAt(Vector3 spawn){
        float hight = Random.Range(4.08f, 1.86f);
        spawn.y = hight;
        Instantiate(birdPrefab, spawn, Quaternion.identity);
    }
}
