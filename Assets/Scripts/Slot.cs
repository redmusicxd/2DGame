using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour {


    private Inventory inventory;
    public int index;
    private LevelGeneration level;
    private bool playerPickup = false;

    private void Start()
    {
        level = GameObject.FindGameObjectWithTag("Generator").GetComponent<LevelGeneration>();
    }

    private void Update()
    {
        if(level.Stop && level.playerSpawned && !playerPickup)
        {
            inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
            playerPickup = true;
        }
        if (transform.childCount <= 0 && playerPickup) {
            inventory.items[index] = 0;
        }
    }

    public void Cross() {

        foreach (Transform child in transform) {
            child.GetComponent<Spawn>().SpawnItem();
            GameObject.Destroy(child.gameObject);
        }
    }

}
