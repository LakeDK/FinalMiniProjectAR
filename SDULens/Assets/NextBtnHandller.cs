using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextBtnHandller : MonoBehaviour
{
    public bool hasClicked = false; 

    public void onClickedNext()
    {
        Debug.Log("Next info");
        hasClicked = true;  

    }
}
