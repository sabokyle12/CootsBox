using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideObjects : MonoBehaviour
{
    [SerializeField] private GameObject[] items;
    // Start is called before the first frame update
    void Start()
    {
        foreach (GameObject obj in items)
        {
            if (!PlayerData.itemsCollected[obj.name])
            {
                obj.SetActive(false);
            }    
        }
        
    }

}
