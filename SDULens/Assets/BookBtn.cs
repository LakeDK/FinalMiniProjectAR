using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using static System.Net.WebRequestMethods;

public class BookBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public string url = "https://mitsdu.sdu.dk/booking/Book.aspx";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick()
    {
        Debug.Log("Booking this room");
        Application.OpenURL(url);   

    }
}
