using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Create_Room", menuName = "ScriptableObjects/Room", order = 1)]
public class Rooms : ScriptableObject
{
    [SerializeField]
    public string RoomName;
    [SerializeField]
    public string RoomDescription;
    [SerializeField]
    public string RoomType;

}
