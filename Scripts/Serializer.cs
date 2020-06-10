using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using System.Text;
using UnityEditor;


public class Serializer : MonoBehaviour
{
    public bool isImgOn;
    public Text eText;
    public GameObject jetobject;
    public GameObject carobject;
    
    private static string pathn;
    void Start()
    {
        eText.enabled = false;
        isImgOn = false;
    }
    public void Explorer()
    {
        pathn = EditorUtility.OpenFilePanel("Select the File to Import", "", "");
        string f_name = Path.GetFileName(pathn);
        Debug.Log("Selected File is " + " " + f_name);
        eText.text = "File" + " " + f_name+ " "+"selected" ;

    }
    public void changepos()
    {
        string path1 = pathn;
        string filename = path1;
        string fromfile = File.ReadAllText(filename);

        SerializableClass sc = JsonUtility.FromJson<SerializableClass>(fromfile);
        if (sc.name == "myJet")
        {
            
            jetobject.transform.position = sc.position;
            jetobject.transform.rotation = sc.rotation;
        }
        if (sc.name == "myCar")
        {
            carobject.transform.position = sc.position;
            carobject.transform.rotation = sc.rotation;
            Vector3 position = new Vector3(205, 343, -235);
            GameObject duplicate = Instantiate(carobject, position, transform.rotation);
        }
    }

    public void Disply()
    {
        string text1 = File.ReadAllText(pathn);
        SerializableClass sc1 = JsonUtility.FromJson<SerializableClass>(text1);
        if (sc1.name == "myJet")
        {

            string dispStr = "Jet.json File Loaded"+" "+ "\r\n";
            dispStr = dispStr + "name of jet :"+" " + sc1.name + "\r\n";
            dispStr = dispStr + "position of jet changed to:"+" " + sc1.position + "\r\n";
            dispStr = dispStr + "Orientation of jet changed to:"+" " + sc1.rotation + "\r\n";
            eText.text = dispStr;
            Debug.Log(dispStr);

        }
        if (sc1.name == "myCar")
        {
           string dispStr1 = "Car.json File Loaded" +" "+"\r\n";
            dispStr1 = dispStr1 + "name of Car:"+" " + sc1.name + "\r\n";
            dispStr1 = dispStr1 + "position of Car changed to"+" " + sc1.position + "\r\n";
            dispStr1 = dispStr1 + "Orientation of Car changed to"+" " + sc1.rotation + "\r\n";
            eText.text = dispStr1;
            Debug.Log(dispStr1);
        }

    }
    void Update()
    {

        if (Input.GetKeyDown("i"))
        {

            if (isImgOn == true)
            {

                
                eText.enabled = false;
                isImgOn = false;
            }

            else
            {

                
                eText.enabled = true;
                isImgOn = true;
            }
        }
    }
    }

