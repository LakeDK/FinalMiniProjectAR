using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.PlayerLoop;
using Vuforia;

public class UpdateInfoHandler : MonoBehaviour
{
    public ObserverBehaviour ob;
    public bool isTracking = false;
    public InformationManager im;
    public DataRetriever retrievedData;
  



  

   
  
    public void TrackingHasFound()
    {

      
        Debug.Log("Printing this to say we're here" + ob.TargetName);
        isTracking = true;  
        im.GetData(ob.TargetName);
        im.navigation.showNavigationOverlay();


    }
    
    

    

    
                
   
      

    }



   


