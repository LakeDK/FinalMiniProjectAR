using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/InformationInfoObject", order = 1)]
public class Information : ScriptableObject
{
    public string title;
    public string description;  
    public List<Rooms> Rooms = new List<Rooms>(); 

}

