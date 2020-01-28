using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {


    public int[] items;
    public GameObject[] slots;
    Slot inv;
    private void Update() {
            slots = GameObject.FindGameObjectsWithTag("Inv");
    }
}
