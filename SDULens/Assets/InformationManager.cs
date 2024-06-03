
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class InformationManager : MonoBehaviour

{
    public InformationOverlaySystem ios;
    public TextMeshProUGUI title;
    public TextMeshProUGUI description;
    public RoomInformationOverlay ros;
    public List<Button> buttons;
    public GameObject prefab;
    public Transform container;
    public Information building;
    public NavigationOverlaySystem navigation;
    public bool hasEnoughRooms = false;
    public HistoryBtn historyBtn;
    public RoomBtn roomBtn;

    public GameObject roomInspection;
    public TextMeshProUGUI inspectRoomTitle;
    public TextMeshProUGUI inspectRoomDescription;
    public bool hasFoundBuilding = false;
    public List<Information> buildings;


    private void Start()
    {
     

    }

    private void Update()
    {
        /*
        try
        {
            if (building.name != null)
            {
                Debug.Log("Has found an building");

                DefineBuildingsHistoryandRooms(building);
              
            }

        } catch(Exception e) { 
        
            Debug.Log(e.ToString());
        }
        }
       */
    }
      
    

    public void GetData(string imageTarget)
    {


        for(int i = 0; i < buildings.Count; i++)
        {
            Debug.Log("Image target" + imageTarget);
            Debug.Log("Title" + buildings[i].title);

            if (buildings[i].title == imageTarget)
            {
                Debug.Log("Building name");
                building = buildings[i];
                hasFoundBuilding = true;
                DefineBuildingsHistoryandRooms(building);
            }
        }
       



    }


    public void DefineBuildingsHistoryandRooms(Information info)
    {
        Debug.Log("Calling to define things");
        title.text = info.title;
        description.text = info.description;

        if (hasEnoughRooms == false)
        {
            for (int i = 0; i <= info.Rooms.Count; i++)
            {

                GameObject button = Instantiate(prefab, container);
                buttons.Add(button.GetComponent<Button>());
          

            }

            hasEnoughRooms = true;
            Debug.Log("We got the same number of rooms and buttons");
            if (hasEnoughRooms == true && info.Rooms.Count < buttons.Count)
            {
                for (int i = buttons.Count - 1; i >= info.Rooms.Count; i--)
                {
                    Debug.Log("Removing not needed buttons");
                    if (buttons[i].gameObject != null)
                    {
                        Destroy(buttons[i].gameObject);
                        buttons.Remove(buttons[i]);
                    }
                }


            }
            for (int i = 0; i < buttons.Count; i++)
            {
                Debug.Log("We're here");
                buttons[i].GetComponentInChildren<TextMeshProUGUI>().text = info.Rooms[i].RoomName;
                
            }

        }

        
       



    }

    public void DisplayHistory()
    {
        ios.showInfoOverlay();
        ros.hideInfoOverlay();  
    }

    public void DisplayRooms()
    {

        ros.showInfoOverlay();
        ios.hideInfoOverlay();


    }

    public void ClearData()
    {
        Debug.Log("Clearing all PLayerprefs");
        PlayerPrefs.DeleteAll();
    }


    public void sendButtonPressedData(string data)
    {
        Debug.Log("Was" + data + "pressed");
        DataRetriever.instance.retrieveButtonPressedData(data); 

    }

    public void inspectRooms(string roomName)
    {
        for(int i= 0; i<building.Rooms.Count; i++) {
            Rooms room = building.Rooms[i];
            if (roomName == room.name)
            {
                Debug.Log("We're here" + room.RoomName);
                ros.hideInfoOverlay();
                roomInspection.SetActive(true); 
                inspectRoomTitle.text = " Room " + roomName;
                inspectRoomDescription.text = room.RoomDescription + " and the type of this room is " + room.RoomType;

            }
        }
      
    }




}
    
