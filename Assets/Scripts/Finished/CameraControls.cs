using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    public List<Cameras> cam = new List<Cameras>();
    void Start()
    {
    }
    void Update()
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
        if (val == 0)
        {
            cam[val].camera.gameObject.SetActive(true);
            cam[1].camera.gameObject.SetActive(false);
        }
        if (val == 1)
        {
            cam[val].camera.gameObject.SetActive(true);
            cam[0].camera.gameObject.SetActive(false);
        }
    }
}
[System.Serializable]
public class Cameras
{
    public Camera camera;
}
