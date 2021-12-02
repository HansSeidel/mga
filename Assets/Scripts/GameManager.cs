using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static int player_count = 1;

    public static GameManager instance = null;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public static void setPlayerCount(int i)
    {
        if ( i < 1 || 4 < i)
        {
            i = 1;
        }
        player_count = i;
    }

    public static int getPlayerCount()
    {
        return player_count;
    }
}
