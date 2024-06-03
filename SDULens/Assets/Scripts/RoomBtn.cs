using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomBtn : MonoBehaviour
{
   
    public bool isTrue = false;
    public HistoryBtn historyBtn;
    public InformationManager im;
   
    public void OnButtonClick()
    {
        im.DisplayRooms();
        Debug.Log("Button was clicked now showing rooms");

 
        
    }
}
