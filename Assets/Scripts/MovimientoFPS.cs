using UnityEngine;
using System.Collections;

public class MovimientoFPS : MonoBehaviour {
    
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 movimiento = Vector3.zero;
    public AudioSource paso;
    void Update()
    {
        CharacterController controller = GetComponent<CharacterController>();


        if (Input.GetButton("Vertical"))
        {
          //  paso.Play();

        }
        if (Input.GetButton("Horizontal"))
        {
          // paso.Play();
        }

        if (controller.isGrounded)
        {
            movimiento = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            movimiento = transform.TransformDirection(movimiento);
            movimiento *= speed;
            if (Input.GetButton("Jump"))
                movimiento.y = jumpSpeed;
                
        }
        movimiento.y -= gravity * Time.deltaTime;
        controller.Move(movimiento * Time.deltaTime);
    }
}