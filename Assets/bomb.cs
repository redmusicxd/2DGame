using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    GameObject exploder;
    public LayerMask Ground;
    public float radius;
    // Start is called before the first frame update
    void Start()
    {
        exploder = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.G)){
            Explode();
        }
    }
   void Explode(){
      Vector2 bombPos = exploder.transform.position;
      Collider2D[] colliders = Physics2D.OverlapCircleAll(bombPos,radius, Ground);
      foreach(Collider2D hit in colliders)
      {
          Collider2D somwe = hit.GetComponent<BoxCollider2D>();
          if(somwe.tag != "Border")
          {
              Destroy(somwe.gameObject);
          }
      }
   }
}
