﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Transform spawnPoint;
    public CharacterController player;

    //public Bonus bonusSpawner;

    private void OnTriggerEnter(Collider other) {
        // Collect pick ups
        if(other.CompareTag("Pick Up"))
        {
            Debug.Log("Pick up collected!");
            GameObject.Destroy(other.gameObject);

            //if (bonusSpawner)
                //bonusSpawner.gameObject.SendMessage("Pickup");
        }

        // Respawn after hitting fall zone
        if(other.CompareTag("Fall Zone"))
        {
            Debug.Log("Player has fallen out of bounds. Resetting position...");
            player.enabled = false;
            transform.SetPositionAndRotation(spawnPoint.position, spawnPoint.rotation);
            player.enabled = true;
        }
    }
}
