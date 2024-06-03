using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InspectRoomBtn : MonoBehaviour
{
    public string inspectRoomBtnName;
    public InformationManager im;
    // Start is called before the first frame update

    private void Awake()
    {
        im = GameObject.FindGameObjectWithTag("Im").GetComponent<InformationManager>(); 
    }
    void Start()
    {
        inspectRoomBtnName = GetComponentInChildren<TextMeshProUGUI>().text;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {

        Debug.Log("Clock");
        im.inspectRooms(inspectRoomBtnName);

    }
}
