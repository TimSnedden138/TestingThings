using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Trial1 : MonoBehaviour
{
    public List<TrialObject> Buttons = new List<TrialObject>();
    int buttonsVal;
    int chance;
    public Text chanceText;
    public Text loseText;
    public Text pickText;
    public Button ContinueButton;
    public Button FailButton;
    public bool win;
    // Start is called before the first frame update
    void Start()
    {
        buttonsVal = Random.Range(0, Buttons.Count);
        switch (buttonsVal)
        {
            case 0:
                Buttons[0].IsCorrect = true;
                break;
            case 1:
                Buttons[1].IsCorrect = true;
                break;
            case 2:
                Buttons[2].IsCorrect = true;
                break;
        }
        loseText.gameObject.SetActive(false);
        ContinueButton.gameObject.SetActive(false);
        FailButton.gameObject.SetActive(false);
    }
    void Update()
    {
        chanceText.text = "Chances:" + chance;
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (chance < 2 && win != true)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                if (Buttons[0].IsCorrect == true)
                {
                    Buttons[0].Obj.GetComponent<Renderer>().material.color = Color.white;
                    pickText.text = "Push the Button To Continue";
                    ContinueButton.gameObject.SetActive(true);
                    win = true;
                }
                else
                {
                    Debug.Log("This Is Incorrect");
                    Buttons[0].Obj.GetComponent<Renderer>().material.color = Color.black;
                    chance = chance + 1;
                }
            }
            if (Input.GetKeyDown(KeyCode.X))
            {
                if (Buttons[1].IsCorrect == true)
                {
                    Buttons[1].Obj.GetComponent<Renderer>().material.color = Color.white;
                    pickText.text = "Push the Button To Continue";
                    ContinueButton.gameObject.SetActive(true);
                    win = true;
                }
                else
                {
                    Debug.Log("This Is Incorrect");
                    Buttons[1].Obj.GetComponent<Renderer>().material.color = Color.black;
                    chance = chance + 1;
                }
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                if (Buttons[2].IsCorrect == true)
                {
                    Buttons[2].Obj.GetComponent<Renderer>().material.color = Color.white;
                    pickText.text = "Push the Button To Continue";
                    ContinueButton.gameObject.SetActive(true);
                    win = true;
                }
                else
                {
                    Debug.Log("This Is Incorrect");
                    Buttons[2].Obj.GetComponent<Renderer>().material.color = Color.black;
                    chance = chance + 1;
                }
            }
        }
        if(chance >= 2 && win == false)
        {
            Debug.Log("You Lose");
            Buttons[0].Obj.SetActive(false);
            Buttons[1].Obj.SetActive(false);
            Buttons[2].Obj.SetActive(false);
            chanceText.gameObject.SetActive(false);
            loseText.gameObject.SetActive(true);
            loseText.text = "You Lose";
            FailButton.gameObject.SetActive(true);
        }
    }
}
[System.Serializable]
public class TrialObject
{
    public GameObject Obj;
    public bool IsCorrect;
}
