using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPlayerCountScript : MonoBehaviour
{
    public void setPlayerCount(int i)
    {
        GameManager.setPlayerCount(i);
    }
}
