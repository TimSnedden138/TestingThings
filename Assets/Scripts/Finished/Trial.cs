using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Trial : MonoBehaviour
{
    public List<TrialObject> Buttons = new List<TrialObject>();
    int buttonsVal;
    int chance;
    public Text chanceText;
    public Text loseText;
    public Text pickText;
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
    }

    void Update()
    {
        chanceText.text = "Chances:" + chance;
        if (chance < 2)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                if (Buttons[0].IsCorrect == true)
                {
                    Buttons[0].Obj.SetActive(false);
                    Buttons[0].Obj.GetComponent<Renderer>().material.color = Color.white;
                    Buttons[0].objTxt.GetComponent<Text>().color = Random.ColorHSV();
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
                    Buttons[1].Obj.SetActive(false);
                    Buttons[1].Obj.GetComponent<Renderer>().material.color = Color.white;
                    Buttons[1].objTxt.GetComponent<Text>().color = Random.ColorHSV();
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
                    Buttons[2].Obj.SetActive(false);
                    Buttons[2].Obj.GetComponent<Renderer>().material.color = Color.white;
                    Buttons[2].objTxt.GetComponent<Text>().color = Random.ColorHSV();
                }
                else
                {
                    Debug.Log("This Is Incorrect");
                    Buttons[2].Obj.GetComponent<Renderer>().material.color = Color.black;
                    chance = chance + 1;
                }
            }
        }
        else if(chance >= 2)
        {
            Debug.Log("You Lose");
            Buttons[0].Obj.SetActive(false);
            Buttons[1].Obj.SetActive(false);
            Buttons[2].Obj.SetActive(false);
            Buttons[0].objTxt.gameObject.SetActive(false);
            Buttons[1].objTxt.gameObject.SetActive(false);
            Buttons[2].objTxt.gameObject.SetActive(false);
            chanceText.gameObject.SetActive(false);
            loseText.gameObject.SetActive(true);
            pickText.text = "Press Q to reset the scene";
            loseText.text = "You Lose";
            if (Input.GetKeyDown(KeyCode.Q))
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}
[System.Serializable]
public class TrialObject
{
    public GameObject Obj;
    public bool IsCorrect;
    public Text objTxt;
}
