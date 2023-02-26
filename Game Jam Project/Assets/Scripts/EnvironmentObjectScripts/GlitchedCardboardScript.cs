using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlitchedCardboardScript : MonoBehaviour
{
    [SerializeField] private int levelToUnglitch;
    [SerializeField] private GameObject unglitchedTileMap;
    void Start()
    {
        if (PlayerData.numHacksCompleted >= levelToUnglitch)
        {
            unglitchedTileMap.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
