using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUDManager : MonoBehaviour
{
    public TMP_Text PopUp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InteractPopUp(string popUpMessage)
    {

        PopUp.text = popUpMessage;;
    }
    public void InteractPopDown()
    {
        PopUp.text = "";
        //PopUp.SetActive (false);
    }
}
