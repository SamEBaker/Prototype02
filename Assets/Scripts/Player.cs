using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{       
    public Rigidbody rb;
    public float playerSpeed;
    public int Keys = 0;
    public float currSpeed;
    public float sprintSpeed;
    public Vector3 movement;
    public IPlayerState currentState;
    public StaminaController staminaController;

    void Start()
    {
        Keys = 0;
        staminaController = GetComponent<StaminaController>();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (staminaController.playerStamina > 5f)
            {
                staminaController.isSprinting = true;
                staminaController.Sprinting(); ;
                staminaController.UpdateStamina(1);
                currSpeed = playerSpeed + sprintSpeed;
            }
            else if (staminaController.playerStamina <=5f)
            {
                staminaController.isSprinting = false;
                staminaController.UpdateStamina(0);
                currSpeed = playerSpeed;
            }
        }
        else
        {
            staminaController.isSprinting = false;
            staminaController.UpdateStamina(0);
            currSpeed = playerSpeed;
        }
        

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        //currentState.Handle(this);
    }

    void FixedUpdate()
    {
        rb.velocity = (movement * currSpeed);
    }

    /*
    private void Awake()
    {
        currentState = new GameManager();
    }
    */
    public void UnlockDoor()
    {
        Keys +=1;
    }
}
