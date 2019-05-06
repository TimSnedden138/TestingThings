using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    public List<Camera> cam = new List<Camera>();
    void Start()
    {

    }
    void Update()
    {
        if (cam.Count == 2)
        {
            CameraSwaping2();
        }        
        else if (cam.Count == 3)
        {
            CameraSwaping3();
        }
    }
    public void CameraSwaping3()
    {
        switch (Input.inputString)
        {
            case "1":
                CameraSwitching(0);
                break;
            case "2":
                CameraSwitching(1);
                break;
            case "3":
                CameraSwitching(2);
                break;
        }
    }
    public void CameraSwaping2()
    {
        switch (Input.inputString)
        {
            case "1":
                CameraSwitching(0);
                break;
            case "2":
                CameraSwitching(1);
                break;
        }
    }
    public void CameraSwitching(int val)
    {
        if (cam.Count == 3)
        {
            if (val == 0)
            {
                cam[val].GetComponent<Camera>().gameObject.SetActive(true);
                cam[1].GetComponent<Camera>().gameObject.gameObject.SetActive(false);
                cam[2].GetComponent<Camera>().gameObject.gameObject.SetActive(false);
            }
            if (val == 1)
            {
                cam[val].GetComponent<Camera>().gameObject.gameObject.SetActive(true);
                cam[0].GetComponent<Camera>().gameObject.gameObject.SetActive(false);
                cam[2].GetComponent<Camera>().gameObject.gameObject.SetActive(false);
            }
            if (val == 2)
            {
                cam[val].GetComponent<Camera>().gameObject.gameObject.SetActive(true);
                cam[1].GetComponent<Camera>().gameObject.gameObject.SetActive(false);
                cam[0].GetComponent<Camera>().gameObject.gameObject.SetActive(false);
            }
        }
        if (cam.Count == 2)
        {
            if (val == 0)
            {
                cam[val].GetComponent<Camera>().gameObject.gameObject.SetActive(true);
                cam[1].GetComponent<Camera>().gameObject.gameObject.SetActive(false);
                cam[2].GetComponent<Camera>().gameObject.gameObject.SetActive(false);
            }
            if (val == 1)
            {
                cam[val].GetComponent<Camera>().gameObject.gameObject.SetActive(true);
                cam[0].GetComponent<Camera>().gameObject.gameObject.SetActive(false);
                cam[2].GetComponent<Camera>().gameObject.gameObject.SetActive(false);
            }
        }
    }
}
