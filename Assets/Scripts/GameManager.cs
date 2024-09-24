using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Animation anim;
    public Player player;
    
    public void playAnim()
    {
        anim.Play("Fade to black tp");
        //anim["Fade to black tp"].time = 9;
    }
 /*
    public void Enter(Player player)
    {


        player.currentState = this;
    }

    public void Handle(Player player)
    {



       

        if (Input.GetKeyDown(KeyCode.A))
        {
            LeftState leftState = new LeftState();
            leftState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            BackState backState = new BackState();
            backState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {

            RightState rightState = new RightState();
            rightState.Enter(player);
        }  */


        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Item"))
            {

            }
        }
}
