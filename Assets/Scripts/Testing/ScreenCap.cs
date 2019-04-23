using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System;
public class ScreenCap : MonoBehaviour
{
    public KeyCode screenCaptureKey = KeyCode.F2;
    public string fileType = ".png";
    public InputField imgName;
    public string img;
     folder;
    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(screenCaptureKey))
        {
            StartCoroutine(CaptureScreen());
        }
    }
    public IEnumerator CaptureScreen()
    {
        img = imgName.text;
        // Wait till the last possible moment before screen rendering to hide the UI
        yield return null;
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = false;

        // Wait for screen rendering to complete
        yield return new WaitForEndOfFrame();

        // Take screenshot
        ScreenCapture.CaptureScreenshot(folder + "\\" + imgName.text + fileType);
        Debug.Log("ScreenCapture Taken!");
        // Show UI after we're done
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = true;
    }
}