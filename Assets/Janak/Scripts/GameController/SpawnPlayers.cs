﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayers : MonoBehaviour
{
	public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
		Instantiate(player, Vector3.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
