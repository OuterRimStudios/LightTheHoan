﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class SpawnBulb : MonoBehaviour
{
    private GameObject bulb;
    public Transform spawnPosition;
    public GameObject lightbulb;

    private bool infiniteSpawn;
    
    public void BulbSpawn()
    {
        if(bulb == null || infiniteSpawn)
        {
            bulb = Instantiate(lightbulb, spawnPosition.position, Quaternion.identity);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F4))
        {
            infiniteSpawn = !infiniteSpawn;
        }
    }
}
