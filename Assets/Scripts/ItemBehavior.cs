using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ItemBehavior : MonoBehaviour
{
    public Player player;
    public enum PickupType
    {
        Corn,
        Ammo,
        Health
    }



    public void PickUpItem()
    {
        /*
        if (CompareTag("Player") == true)
        {
            if (type == PickupType.Corn)
                player.GiveCorn();
            else if (type == PickupType.Ammo)
                weapon.GiveAmmo();
            else if (type == PickupType.Health)
                player.GiveHealth(10);

        */
            Destroy(this.gameObject);
        Debug.Log("You Picked this up!");
        player.UnlockDoor();
    }
}
