using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPlayerState
{
    public abstract void Enter(Player player);
    public abstract void Handle(Player player);

}
