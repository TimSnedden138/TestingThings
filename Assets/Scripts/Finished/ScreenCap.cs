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
    string folderName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    string subFolderName = "Screenshots";
    string pathString;
    string fileName = Path.GetRandomFileName();
    string delete;
    void Start()
    {
        delete = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + subFolderName;
        pathString = Path.Combine(folderName, subFolderName);
        Directory.CreateDirectory(pathString);
        pathString = Path.Combine(pathString, fileName);
        Console.WriteLine("Path to my file: {0}\n", pathString);
    }

    void Update()
    {
        if (Input.GetKeyDown(screenCaptureKey))
        {
            StartCoroutine(CaptureScreen());
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Deletion();
        }
    }
    public void Deletion()
    {
        Directory.Delete(delete, true);
        Application.Quit();
    }

    public IEnumerator CaptureScreen()
    {
        img = imgName.text;
        yield return null;
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = false;
        yield return new WaitForEndOfFrame();
        ScreenCapture.CaptureScreenshot(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "\\" +subFolderName+ "\\" + imgName.text + fileType);
        Debug.Log("ScreenCapture Taken!");
        GameObject.Find("Canvas").GetComponent<Canvas>().enabled = true;
    }
}