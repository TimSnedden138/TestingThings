using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.UI;
using System;
public class ScreenCap : MonoBehaviour
{
    public KeyCode screenCaptureKey = KeyCode.F2;
    public string fileType = ".png";
    public string imgName;
    public string CanvasName;
    public Text pictureText;
    string folderName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    string subFolderName = "Screenshots";
    string pathString;
    string fileName = Path.GetRandomFileName();
    string delete;
    bool pictureTaken;
    void Start()
    {
        delete = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + subFolderName;
        pathString = Path.Combine(folderName, subFolderName);
        Directory.CreateDirectory(pathString);
        pathString = Path.Combine(pathString, fileName);
        Console.WriteLine("Path to my file: {0}\n", pathString);
        pictureTaken = false;
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
        if(pictureTaken == true)
        {
            pictureText.text = "Screenshot saved to Desktop";
        }
    }
    public void Deletion()
    {
        Directory.Delete(delete, true);
        Application.Quit();
    }

    public IEnumerator CaptureScreen()
    {
        yield return null;
        GameObject.Find(CanvasName).GetComponent<Canvas>().enabled = false;
        yield return new WaitForEndOfFrame();
        ScreenCapture.CaptureScreenshot(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "\\" +subFolderName+ "\\" + imgName + fileType);
        Debug.Log("ScreenCapture Taken!");
        GameObject.Find(CanvasName).GetComponent<Canvas>().enabled = true;
        pictureTaken = true;
    }
}