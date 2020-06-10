using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Specialized;

public class Movement : MonoBehaviour
{

    
    public GameObject gobj;


  

    public void Forward()

    {
        Vector3 pos = new Vector3(10f, 0f, 0f) * Time.deltaTime;
        gobj.transform.position = gobj.transform.position + pos;
        

    }
    public void Backward()
    {
        Vector3 posNeg = new Vector3(-10f, 0f, 0f) * Time.deltaTime;
        gobj.transform.position = gobj.transform.position + posNeg;

    }

    public void stop()
    {
        gobj.transform.position = gobj.transform.position + new Vector3(0,0,0) * Time.deltaTime;
       
    }

}