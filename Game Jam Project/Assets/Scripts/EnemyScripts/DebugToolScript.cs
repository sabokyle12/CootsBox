using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DebugToolScript : MonoBehaviour , IPointerClickHandler
{
    private GameObject child;
    private float timeDeleted = 2f;
    // Start is called before the first frame update
    void Start()
    {
        child = transform.GetChild(0).gameObject;
    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if ((!PlayerData.isUsingDebug) && PlayerData.hackType == "DebugTool" )
        {
            StartCoroutine(tempDeleteObject());
        }
        
    }

    IEnumerator tempDeleteObject()
    {
        PlayerData.isUsingDebug = true;
        child.SetActive(false);
        yield return new WaitForSeconds(timeDeleted);
        PlayerData.isUsingDebug = false;
        child.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
