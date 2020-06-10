using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHide : MonoBehaviour
{
    float speed = 90f;
    public void showIt(GameObject obj)
    {
        obj.SetActive(true);
    }
    public void hideIt(GameObject obj)
    {
        obj.SetActive(false);
    }

    public void spin(GameObject obj)
    {
        obj.transform.Rotate(0, 0, speed);
    }
    public void spinCar(GameObject obj)
    {
        obj.transform.Rotate(0, speed, 0);
    }
}

