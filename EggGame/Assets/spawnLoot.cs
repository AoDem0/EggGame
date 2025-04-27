using System.Collections.Generic;
using UnityEngine;

public class spawnLoot : MonoBehaviour
{

    [SerializeField] private eventHolder events;
    [SerializeField] private GameObject[] eggs;
    [SerializeField] private GameObject poop;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        events = FindAnyObjectByType<eventHolder>();
    }


    private void OnEnable()
    {
        eventHolder.OnSendPosition += spawnRandomLoot;
    }

    private void OnDisable()
    {
       eventHolder.OnSendPosition -= spawnRandomLoot;
    }



    private void spawnRandomLoot(Vector3 spawnPosition){
        int lootChance = Random.Range(0, 101);
        if (lootChance <= 60)
        {
            int randIndex = Random.Range(0, eggs.Length);
            Instantiate(eggs[randIndex], spawnPosition, Quaternion.identity);
        }
        else{
            Instantiate(poop, spawnPosition, Quaternion.identity);
        }
        }
}
