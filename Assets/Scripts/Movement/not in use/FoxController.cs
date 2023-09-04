using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxController : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 5f;
    public float sprintspeed = 10f;
    public List<int> hello = new List<int>();
    public int[] array = new int[4];
    public Vector3 movement;
    public float jumpSpeed = 8.0F;
    public float gravity = 15.0F;
    private Vector3 moveDirection = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * y;
        move.Normalize();
        movement = transform.right * x + transform.forward * y;
        movement *= speed;
        if (controller.isGrounded && Input.GetButton("Jump"))
        {
            moveDirection.y = jumpSpeed;
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            controller.Move(move * sprintspeed * Time.deltaTime);
        }
        else
        {
            controller.Move(move * speed * Time.deltaTime);
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

    }
}
