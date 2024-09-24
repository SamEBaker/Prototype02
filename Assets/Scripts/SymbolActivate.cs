using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SymbolActivate : MonoBehaviour
{

    public Player player;
    public MeshRenderer mr;
    // Start is called before the first frame update
    public void ActivateSymbol()
    {
        player.Keys += 1;
        mr.material.color = Color.green;
        //change color
        //Destroy(this.gameObject);
        Debug.Log("You Picked this up!");
        if(player.Keys >= 6)
        {
            player.UnlockDoor();
        }

    }
}
