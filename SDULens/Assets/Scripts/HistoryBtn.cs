using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HistoryBtn : MonoBehaviour
{
    public bool isTrue = false;
    public InformationOverlaySystem ios;
    public InformationManager im;



    public RoomBtn roomBtn;
    public NextBtnHandller nextBtn;
   public void OnButtonClick()
    {
        im.DisplayHistory();


    }
}
