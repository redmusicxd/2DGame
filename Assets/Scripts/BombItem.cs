using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombItem : MonoBehaviour {

    private Transform player;
    public GameObject explosionEffect;

    //GameObject exploder;
    public LayerMask Ground;
    public float radius;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    public void Use() {
        Instantiate(explosionEffect, player.transform.position, Quaternion.identity);
      Vector2 bombPos = player.position;
      Collider2D[] colliders = Physics2D.OverlapCircleAll(bombPos,radius, Ground);
      foreach(Collider2D hit in colliders)
      {
          Collider2D somwe = hit.GetComponent<BoxCollider2D>();
          if(somwe.tag != "Border")
          {
              Destroy(somwe.gameObject);
          }
      }
        //Destroy(gameObject);
    }

}
