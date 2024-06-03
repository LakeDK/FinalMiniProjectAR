using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Vuforia;

public class ResetManager : MonoBehaviour
{
    public  InformationOverlaySystem ios;
    public HistoryBtn historyBtn;  
   public RoomBtn roomBtn;
   public NextBtnHandller nextBtnHandller;
   public RoomInformationOverlay ros;
   public InformationManager im;

   public List<ObserverBehaviour> observers;        


    public void Reset()
    {
        Debug.Log("Resetting");
        historyBtn.isTrue=false;    
        roomBtn.isTrue=false;   
        nextBtnHandller.hasClicked=false;
        im.building = null;

        foreach (Transform child in im.container.transform)
        {
            Destroy(child.gameObject);
            im.buttons.Clear();
            im.hasEnoughRooms = false;
        }
        im.ros.hideInfoOverlay();
        im.buttons.Clear();     
        ios.hideInfoOverlay();
        im.navigation.gameObject.SetActive(false);  
        im.roomInspection.gameObject.SetActive(false);      
        im.hasFoundBuilding = false;    
      


    }

    public void Update()
    {
        
        

        
    }
}
