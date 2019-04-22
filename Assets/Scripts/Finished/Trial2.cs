using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Trial2 : MonoBehaviour
{
    public List<TrialObject2> Objs = new List<TrialObject2>();
    public int Num1;
    public int Num2;
    public int Num3;
    public Mats mats;
    int correctNums;
    int wrongNums;
    public UIElement uI;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < Objs.Count; i++)
        {
            Objs[i].Obj.GetComponent<Renderer>().material.color = mats.starting.color;
        }
        Num1 = Random.Range(0, 4);
        Num2 = Random.Range(4, 7);
        Num3 = Random.Range(7, 10);
    }
    // Update is called once per frame
    void Update()
    {
        uI.pinText.gameObject.SetActive(false);
        uI.Continue.gameObject.SetActive(false);
        uI.Fail.gameObject.SetActive(false);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        uI.wrongText.text = "Wrong\nYou Have " + wrongNums + " left";
        uI.correctText.text = "Correct\nYou got " + correctNums + " out of 3";
        if (correctNums < 3 && wrongNums < 3)
        {

            switch (Input.inputString)
            {
                case "0":
                    pinChecker(0);
                    break;
                case "1":
                    pinChecker(1);
                    break;
                case "2":
                    pinChecker(2);
                    break;
                case "3":
                    pinChecker(3);
                    break;
                case "4":
                    pinChecker(4);
                    break;
                case "5":
                    pinChecker(5);
                    break;
                case "6":
                    pinChecker(6);
                    break;
                case "7":
                    pinChecker(7);
                    break;
                case "8":
                    pinChecker(8);
                    break;
                case "9":
                    pinChecker(9);
                    break;
            }
        }
            if (correctNums >= 3)
            {
                Win();
            }
            if (wrongNums == 3 && correctNums < 3)
            {
                Lose();
            }
    }
    public void pinChecker(int val)
    {
        if (val == Num1)
        {
            Objs[val].Obj.GetComponent<Renderer>().material.color = mats.green.color;
            correctNums = correctNums + 1;
            wrongNums = 0;
        }
        else if (val == Num2)
        {
            Objs[val].Obj.GetComponent<Renderer>().material.color = mats.green.color;
            correctNums = correctNums + 1;
            wrongNums = 0;
        }
        else if(val == Num3)
        {
            Objs[val].Obj.GetComponent<Renderer>().material.color = mats.green.color;
            correctNums = correctNums + 1;
            wrongNums = 0;
        }
        else
        {
            Debug.Log("Not one of the Numbers");
            Objs[val].Obj.GetComponent<Renderer>().material.color = mats.red.color;
            wrongNums = wrongNums + 1;
        }
    }
    public void Win()
    {
        Debug.Log("You Win");
        uI.desText.text = "You Win Hope Your Ready";
        uI.Continue.gameObject.SetActive(true);
        for (int f = 0; f < Objs.Count; f++)
        {
            Objs[f].Obj.GetComponent<Renderer>().material.color = mats.green.color;
        }
        uI.Continue.gameObject.SetActive(true);
    }
    public void Lose()
    {
        Debug.Log("You Lose");
        uI.empty.gameObject.SetActive(false);
        uI.pinText.gameObject.SetActive(true);
        uI.Fail.gameObject.SetActive(true);
        uI.pinText.text = "The PIN was " + Num1 +" "+ Num2+ " " + Num3;
        uI.desText.text = "You Lose";
        for(int f = 0; f < Objs.Count; f++)
        {
            Objs[f].Obj.GetComponent<Renderer>().material.color = mats.red.color;
        }
    }
}
[System.Serializable]
public class TrialObject2
{
   public GameObject Obj;
}
[System.Serializable]
public class UIElement
{
    public Text wrongText;
    public Text correctText;
    public GameObject empty;
    public Text desText;
    public Text pinText;
    public Button Continue;
    public Button Fail;
}
[System.Serializable]
public class Mats
{
    public Material red;
    public Material green;
    public Material starting;
}