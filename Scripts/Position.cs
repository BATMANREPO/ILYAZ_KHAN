using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.UI;

public class Position : MonoBehaviour
{

    
    public GameObject gameObject;
    public GameObject textDisplay;
    // Start is called before the first frame update
    public void storePosition()
    {
        
        Vector3 pos = gameObject.GetComponent<Transform>().position;
        textDisplay.GetComponent<Text>().text = "The Aircraft's new position is "+ pos ;
    }

    
}
