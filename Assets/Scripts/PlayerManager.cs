using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.LEGO.Minifig
{
    public class PlayerManager : MonoBehaviour
    {
        public GameObject[] PlayerPrefabs;
        public GameObject CameraPrefab;
        public Transform[] StartPositions;

        // Start is called before the first frame update
        void Awake()
        {
            int playerCount = GameManager.getPlayerCount();
            if (playerCount < 0 || 4 < playerCount)
            {
                playerCount = 1;
            }
            for (int i = 0; i < playerCount; i++)
            {
                float width = 1;
                float x = 0;
                float height = 1;
                float y = 0;
                if (playerCount >= 2)
                {
                    width = 0.499f;
                    if (i == 1 || i == 3)
                    {
                        x = 0.501f;
                    }
                    if (playerCount >= 3)
                    {
                        height = 0.499f;
                        if (i <= 1)
                        {
                            y = 0.501f;
                        }
                    }
                }
                GameObject player = Instantiate(PlayerPrefabs[Random.Range(0, PlayerPrefabs.Length)], StartPositions[i].position, Quaternion.identity);
                player.GetComponent<MinifigController>().setPlayerNumber(i + 1);
                GameObject playerCamera = Instantiate(CameraPrefab, StartPositions[i].position, Quaternion.identity);
                playerCamera.GetComponent<SmoothFollow>().setPosition(player.transform, width, height, x, y);
            }
        }
    }
}