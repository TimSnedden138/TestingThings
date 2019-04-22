using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StoryPicker : MonoBehaviour
{
    public Text storyText;
    // Start is called before the first frame update
    void Start()
    {
        switch (Random.Range(0, 2))
        {
            case 0:
                storyText.text = "So you are a person who stumbled into this game. \n" +
                    "You here that you may have a chance to get out \n" +
                    "If you pass the trials in front of you";
                break;
            case 1:
                storyText.text = "So you are a person who stumbled into this game. \n" +
                    "You try to leave and you get shocked and hear a thing say \n" +
                    "If you pass the trials in front of you may leave";
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
