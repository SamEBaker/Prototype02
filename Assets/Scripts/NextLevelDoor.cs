using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelDoor : MonoBehaviour
{
    public Player player;
    public bool Locked;
    //public GameObject Door;
    public int Mykey;
    public GameObject playerScreen;

    public float waitTime;


    public void Leave()
    {
        if(Locked == true)
        {
            if(player.Keys == Mykey)
            {
                Locked = false;
                Debug.Log("Entering next area");
                //HUD fade to black 
                StartCoroutine(TP());
                //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

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
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        

    }

    IEnumerator TP()
    {

        //anim.clip Fade;
        //anim.Play("BGFade");
        //player.GetComponent<Player>().enabled = false;
        ///play animation
        playerScreen.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        yield return new WaitForSeconds(waitTime);

        //player.GetComponent<Player>().enabled = true;
        //playerScreen.SetActive(false);
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
