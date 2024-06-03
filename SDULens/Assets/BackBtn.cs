using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackBtn : MonoBehaviour
{
    public GameObject roomInspectionOverlay;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onCLick()
    {
        Debug.Log("Closing the inspection layer");
        roomInspectionOverlay.SetActive(false);
    }
}
