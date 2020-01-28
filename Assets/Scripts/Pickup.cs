using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour {

    private Inventory inventory;
    public GameObject itemButton;
    public GameObject effect;

    private bool playerPickup = false;
    LevelGeneration level;

    private void Start()
    {
        level = GameObject.FindGameObjectWithTag("Generator").GetComponent<LevelGeneration>();
    }

    private void Update() {
        if(level.Stop && level.playerSpawned && !playerPickup)
        {
            inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
            playerPickup = true;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            // spawn the sun button at the first available inventory slot ! 
            

            for (int i = 0; i < inventory.items.Length; i++)
            {
                if (inventory.items[i] == 0) { // check whether the slot is EMPTY
                    Instantiate(effect, transform.position, Quaternion.identity);
                    inventory.items[i] = 1; // makes sure that the slot is now considered FULL
                    Instantiate(itemButton, inventory.slots[i].transform, false); // spawn the button so that the player can interact with it
                    Destroy(gameObject);
                    break;
                }
            }
        }
        
    }
}
