using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxMove : MonoBehaviour
{
    CharacterController Controller;
    public float Speed;
    public Transform Cam;
    public float gravity = 15.0F;
    [SerializeField] Animator animator;
    [SerializeField] float x;
    [SerializeField] float y;
    [SerializeField] CameraMove cameraMove;
    [SerializeField]Transform fox;
    float rotation;
    // Start is called before the first frame update
    void Start()
    {
        Controller = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
        cameraMove = GetComponentInChildren<CameraMove>();
    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        float Vertical = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        y= Input.GetAxis("Vertical") * Speed * Time.deltaTime;
        x= Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        if (Horizontal==0&&Vertical==0&&cameraMove.X==0)
        {
            animator.SetBool("Run", false);
            animator.SetBool("RunBack", false);
            animator.SetBool("Idle", true);

        }
        if (Vertical>0||Horizontal>0||Horizontal<0)
        {
            animator.SetBool("RunBack", false);
            animator.SetBool("Idle", false);
            animator.SetBool("Run", true);
        }
        if (Vertical<0)
        {
            animator.SetBool("Idle", false);
            animator.SetBool("Run", false);
            animator.SetBool("RunBack", true);
        }
        Vector3 Movement = Cam.transform.right * Horizontal + Cam.transform.forward * Vertical;
        Movement.y -= gravity*Time.deltaTime;
        if (cameraMove.X != 0)
        {

            animator.SetBool("Idle", false);
            animator.SetBool("Run", false);
            animator.SetBool("RunBack", false);
            if (cameraMove.X > 0.05)
            {
                animator.SetBool("RunLeft", false);
                animator.SetBool("RunRight", true);
            }
            if (cameraMove.X < -0.05)
            {
                animator.SetBool("RunLeft", true);
                animator.SetBool("RunRight", false);
            }
        }
        else
        {
            animator.SetBool("RunLeft", false);
            animator.SetBool("RunRight", false);
        }
        //if (Horizontal!=0||Vertical!=0)
        //{
        //    animator.SetBool("Idle", false);
        //    if (Vertical>0&&Horizontal==0)
        //    {
        //        animator.SetBool("Run", true);
        //        animator.SetBool("RunLeft", false);
        //        animator.SetBool("RunRight", false);
        //    }
        //    if (Horizontal < 0)
        //    {
        //        animator.SetBool("Run", false);
        //        animator.SetBool("RunLeft", true);
        //        animator.SetBool("RunRight", false);
        //    }
        //    if (Horizontal > 0)
        //    {
        //        animator.SetBool("Run", false);
        //        animator.SetBool("RunLeft", false);
        //        animator.SetBool("RunRight", true);
        //    }
        //}
        //else
        //{
        //    animator.SetBool("Run", false);
        //    animator.SetBool("RunLeft", false);
        //    animator.SetBool("RunRight", false);
        //    animator.SetBool("Idle", true);
        //}
        Controller.Move(Movement);
        if (Movement.magnitude != 0f)
        {
            transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * Cam.GetComponent<CameraMove>().sensivity * Time.deltaTime);
            Quaternion CamRotation = Cam.rotation;
            CamRotation.x = 0f;
            CamRotation.z = 0f;
            transform.rotation = Quaternion.Lerp(transform.rotation, CamRotation, 0.1f);

        }
    }

}