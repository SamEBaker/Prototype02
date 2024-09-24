using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorExit : MonoBehaviour
{
    public Player player;
    public bool Locked;
    public GameObject Door;
    Animation anim;
    public int Mykey;

    public GameObject playerScreen;

    //public Animation Fade;
    public float waitTime;

    //create 3 types of doors  locked unlocked and passcode locked 


    public void Start()
    {
        anim = gameObject.GetComponent<Animation>();
    }
 
    public void OpenDoor()
    {
        if(Locked == true)
        {
            if(player.Keys == Mykey)
            {
                Locked = false;
                Debug.Log("Entering next area");


                StartCoroutine(TP());
                //player.transform.position = Door.transform.position;


            } 
            else
            {
                Debug.Log("Door is locked!");
            }
        }
        else
        {
            Debug.Log("Entering next area");
            StartCoroutine(TP());
            //player.transform.position = Door.transform.position;
        }


        

    }

   IEnumerator TP()
    {

        //anim.clip Fade;
        //anim.Play("BGFade");
        player.GetComponent<Player>().enabled = false;
        ///play animation
        playerScreen.SetActive(true);  
        player.transform.position = Door.transform.position;
        yield return new WaitForSeconds(waitTime);

        player.GetComponent<Player>().enabled = true;
        playerScreen.SetActive(false);
    }

    /*

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player" && player.hasItem == true)
        {
            Locked = false;
            Debug.Log("Entering next area");
            player.transform.position = Door.transform.position;
        }
        else
        {
            Debug.Log("Door is locked!");
        }

    }
    */
}
