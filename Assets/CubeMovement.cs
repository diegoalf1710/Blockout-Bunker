using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CubeMovement : MonoBehaviour
{
    public float speed = 10f; // Velocidad de movimiento del cubo
    public float jumpForce = 1f; // Fuerza de salto del cubo
    public float gravity = -10f; // Gravedad aplicada al cubo
    public float groundDistance = 0.2f; // Distancia para verificar si el cubo está en el suelo
    public LayerMask groundMask; // Máscara de capas para el suelo

    private CharacterController controller;
    private Vector3 velocity;
    private bool isGrounded;

    public PlayerInput playerInput;//Este es para el metodo con el componente PlayerInput
    //MisInputs controlPlayer; //Este es del metodo con codigo
    InputAction accionControl,accionJump;
    public Vector2 controlP;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        accionControl = playerInput.actions["Control"];
        accionJump = playerInput.actions["Jump"];
        //controlPlayer = new();
    }

    private void OnEnable()
    {
        //controlPlayer.Enable();
        /*
        //Agregamos la funcion como un callback context metodo codigo
        controlPlayer.Juego.Jump.started += ctx => Salto();
        controlPlayer.Juego.Jump.performed += ctx => SaltoDoble();
        controlPlayer.Juego.Jump.canceled += ctx => SaltoCancel();
        */

        //Agregamos la funcion como un callback context metodo componente PlayerInput
        accionJump.started += ctx => Salto();
        accionJump.performed += ctx => SaltoDoble();
        accionJump.canceled += ctx => SaltoCancel();
    }

    private void OnDisable()
    {
        /*Metodo con codigo
        controlPlayer.Disable();
        controlPlayer.Juego.Jump.started -= ctx => Salto();
        controlPlayer.Juego.Jump.performed -= ctx => SaltoDoble();
        controlPlayer.Juego.Jump.canceled -= ctx => SaltoCancel();
        */
        //Agregamos la funcion como un callback context metodo componente PlayerInput
        accionJump.started -= ctx => Salto();
        accionJump.performed -= ctx => SaltoDoble();
        accionJump.canceled -= ctx => SaltoCancel();
    }

    void Update()
    {
        // Verificamos si el cubo está en el suelo
        isGrounded = Physics.CheckSphere(transform.position - new Vector3(0, controller.height / 2 - controller.radius, 0), groundDistance, groundMask);

        // Resetear la velocidad si estamos en el suelo
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        /*
        // Input Movimiento Regular
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        */

        // Con Input Nuevo
        //controlP = controlPlayer.Juego.Control.ReadValue<Vector2>();
        controlP = accionControl.ReadValue<Vector2>();
        //Debug.Log(controlP.x);
        // Calculamos el vector de movimiento nuevo input
        Vector3 movementNew = transform.right * controlP.x + transform.forward * controlP.y;
        controller.Move(movementNew * speed * Time.deltaTime);

        /*
        // Calculamos el vector de movimiento
        Vector3 movement = transform.right * horizontalInput + transform.forward * verticalInput;
        controller.Move(movement * speed * Time.deltaTime);
        */

        /*
        // Salto con Input Regular
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        }
        */

        // Aplicamos la gravedad
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    //Funcion salto para nuevo Input
    void Salto()
    {
        velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity);
        Debug.Log("Start");
    }
    void SaltoDoble()
    {
        Debug.Log("Performed");
    }

    void SaltoCancel()
    {
        Debug.Log("Cancel");
    }
}


