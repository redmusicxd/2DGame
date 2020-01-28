using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller2D;
    public float horizontalMove = 0f;
    public bool jump = false;
    public bool crouch = false;
    // Update is called once per frame
    void Update()
    {
		crouch = Input.GetButton("Crouch");
		jump = Input.GetButton("Jump");
        horizontalMove = Input.GetAxisRaw("Horizontal");

    }
    private void FixedUpdate() {
        controller2D.Move(horizontalMove, crouch, jump);
    }
}
