using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToby : MonoBehaviour {
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();
        transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        float curSpeed = speed * Input.GetAxis("Vertical");
        controller.SimpleMove(forward * curSpeed);


        if (Input.GetKey("up") || Input.GetKey("right") || Input.GetKey("left") || Input.GetKey("down")) 
        {
            GetComponent<Animator>().Play("Walking");
        }
        else
        {
            GetComponent<Animator>().Play("Idle");
        }
    }



    /*
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    void Update()
    {
        
        //var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
        //var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        //transform.Rotate(0, x, 0);
       // transform.Translate(0, 0, z);
        

        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {

            moveDirection = new Vector3(Input.GetAxis("Horizontal"),0 ,Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetKey("right"))
            {
                GetComponent<Animator>().Play("Walking");
            }
            else if (Input.GetKey("left"))
            {
                GetComponent<Animator>().Play("Walking");
            }
            else if (Input.GetKey("up"))
            {
                moveDirection.y = jumpSpeed;
                GetComponent<Animator>().Play("Jumping");
            }
            else
            {
                GetComponent<Animator>().Play("Idle");
            }

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

       // var x = Input.GetAxis("Horizontal") * Time.deltaTime  * 150.0f;
       // var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

        controller.transform.Rotate(0, x, 0);
    }
*/

}
