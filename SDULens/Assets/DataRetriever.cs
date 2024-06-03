using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataRetriever : MonoBehaviour
{
    public static DataRetriever instance;
    public string retrievedData;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

        }
        else
        {
            Destroy(gameObject);
            return;
        }

    }
    public void retrieveButtonPressedData(string data)
    {
        retrievedData = data;
        Debug.Log("Data was retrieved" + retrievedData);
    }
 
}
