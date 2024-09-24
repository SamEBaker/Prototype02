using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityStandardAssets.Characters.FirstPerson;

public class Keypad : MonoBehaviour
{
    //https://www.youtube.com/watch?v=c2Ze4WRUgKY
    public GameObject player;
    public GameObject keypad;
    public GameObject HUD;

    //public GameObject inv;

    //public GameObject animObject;
   // public Animator Anim;

    public Text text;
    public string answer;
    public bool animate;

    public void String(string letter)
    {
        text.text += letter;
        //audio
    }

    public void Number(int number)
    {
        text.text += number.ToString();
      //audio
    }
    public void PopUpKeypad()
    {
        HUD.SetActive(true);
    }
    public void Execute()
    {
        if(text.text == answer)
        {
            //audio

            text.text = "Unlocked";

        }
        else
        {
            //audio
            text.text = "Invalid";
            StartCoroutine(DelayClear());
        }
    }

    public void Clear()
    {
        text.text = "";
        //audio
    }

    public void ExitPad()
    {
        //keypad.SetActive(false);

        HUD.SetActive(false);
        player.GetComponent<Player>().enabled = true;
    }

    public void Update()
    {
        if(text.text == "Unlocked" )
        {
            //Anim.SetBool("animate", true);
            Debug.Log("Unlocked door");
            StartCoroutine(DelayExit());

        }

        if (keypad.activeInHierarchy)
        {
            //HUD.SetActive(false);
            player.GetComponent<Player>().enabled=false;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        
    }
    IEnumerator DelayClear()
    {
        yield return new WaitForSeconds(2f);
        Clear();
    }
    IEnumerator DelayExit()
    {
        yield return new WaitForSeconds(3);
        player.GetComponent<Player>().Keys += 1;
        ExitPad();
    }
}
