using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody RB;
    public CharacterController cc;
    Vector3 move;
	public float speed;
    public float gravity;
    // Start is called before the first frame update
    void Start()
    {
        //cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();

        
    }

	private void MovePlayer()
	{
        if(cc.isGrounded)
        {
            move = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
            move = transform.TransformDirection(move);
            move *= speed;

           
        }
        move.y -= gravity * Time.deltaTime;
        

        cc.Move(move * Time.deltaTime);
    }
}
