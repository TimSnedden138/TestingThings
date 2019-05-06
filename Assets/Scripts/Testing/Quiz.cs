using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Quiz : MonoBehaviour
{
    public List<GameObject> TrialObjs = new List<GameObject>();
    public List<Text> texts = new List<Text>();
    public List<GameObject> QuizObjs = new List<GameObject>();
    public RawImage WrongColorImg;
    public Camera PlayerCam;
    public Color correctColor;
    public Color wrongColor;
    int correctOption;
    int randomNumber1;
    int randomNumber2;
    bool Option1;
    bool Option2;
    bool Option3;
    int Cases;
    void Start()
    {
        for (int i = 0; i < TrialObjs.Count; i++)
        {
            switch (Random.Range(0, 2))
            {
                case 0:
                    TrialObjs[i].gameObject.GetComponent<Renderer>().material.color = correctColor;
                    correctOption += 1;
                    break;
                case 1:
                    TrialObjs[i].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                    break;
            }
        }
        randomNumber1 = Random.Range(0, 12 - correctOption - randomNumber2);
        randomNumber2 = Random.Range(0, 12 - correctOption - randomNumber1);
        if (randomNumber2 == correctOption)
        {
            randomNumber2 = Random.Range(0, 12 - correctOption - randomNumber1);
        }
        if (randomNumber1 == correctOption)
        {
            randomNumber1 = Random.Range(0, 12 - correctOption - randomNumber2);
        }
        Cases = Random.Range(0, 3);
        WrongColorImg.GetComponent<RawImage>().color = wrongColor;
    }
    void Update()
    {
        if (PlayerCam == Camera.current)
        {
            switch (Cases)
            {
                case 0:
                    texts[0].text = "Left Choice " + correctOption;
                    texts[1].text = "Middle Choice " + randomNumber1;
                    texts[2].text = "Right Choice " + randomNumber2;
                    Option1 = true;
                    Option2 = false;
                    Option3 = false;
                    if (Input.GetKey(KeyCode.Z))
                    {
                        if (Option1 == true)
                        {
                            Debug.Log("this is right");
                            QuizObjs[0].gameObject.GetComponent<Renderer>().material.color = correctColor;
                            QuizObjs[1].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                            QuizObjs[2].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                        }
                        else
                        {
                            Debug.Log("This is wrong");
                        }
                    }
                    if (Input.GetKey(KeyCode.X))
                    {
                        if (Option2 == true)
                        {
                            Debug.Log("this is right");
                            QuizObjs[0].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                            QuizObjs[1].gameObject.GetComponent<Renderer>().material.color = correctColor;
                            QuizObjs[2].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                        }
                        else
                        {
                            Debug.Log("This is right");
                        }
                    }
                    if (Input.GetKey(KeyCode.C))
                    {
                        if (Option3 == true)
                        {
                            Debug.Log("this is right");
                            QuizObjs[0].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                            QuizObjs[1].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                            QuizObjs[2].gameObject.GetComponent<Renderer>().material.color = correctColor;
                        }
                        else
                        {
                            Debug.Log("This is wrong");
                        }
                    }
                    break;
                case 1:
                    texts[0].text = "Left Choice " + randomNumber1;
                    texts[1].text = "Middle Choice " + correctOption;
                    texts[2].text = "Right Choice " + randomNumber2;
                    Option1 = false;
                    Option2 = true;
                    Option3 = false;
                    if (Input.GetKey(KeyCode.Z))
                    {
                        if (Option1 == true)
                        {
                            Debug.Log("this is right");
                            QuizObjs[0].gameObject.GetComponent<Renderer>().material.color = correctColor;
                            QuizObjs[1].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                            QuizObjs[2].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                        }
                        else
                        {
                            Debug.Log("This is wrong");
                        }
                    }
                    if (Input.GetKey(KeyCode.X))
                    {
                        if (Option2 == true)
                        {
                            Debug.Log("this is right");
                            QuizObjs[0].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                            QuizObjs[1].gameObject.GetComponent<Renderer>().material.color = correctColor;
                            QuizObjs[2].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                        }
                        else
                        {
                            Debug.Log("This is right");
                        }
                    }
                    if (Input.GetKey(KeyCode.C))
                    {
                        if (Option3 == true)
                        {
                            Debug.Log("this is right");
                            QuizObjs[0].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                            QuizObjs[1].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                            QuizObjs[2].gameObject.GetComponent<Renderer>().material.color = correctColor;
                        }
                        else
                        {
                            Debug.Log("This is wrong");
                        }
                    }
                    break;
                case 2:
                    texts[0].text = "Left Choice " + randomNumber1;
                    texts[1].text = "Middle Choice " + randomNumber2;
                    texts[2].text = "Right Choice " + correctOption;
                    Option1 = false;
                    Option2 = false;
                    Option3 = true;
                    if (Input.GetKey(KeyCode.Z))
                    {
                        if (Option3 == true)
                        {
                            Debug.Log("this is right");
                            QuizObjs[0].gameObject.GetComponent<Renderer>().material.color = correctColor;
                            QuizObjs[1].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                            QuizObjs[2].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                        }
                        else
                        {
                            Debug.Log("This is wrong");
                        }
                    }
                    if (Input.GetKey(KeyCode.X))
                    {
                        if (Option3 == true)
                        {
                            Debug.Log("this is right");
                            QuizObjs[0].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                            QuizObjs[1].gameObject.GetComponent<Renderer>().material.color = correctColor;
                            QuizObjs[2].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                        }
                        else
                        {
                            Debug.Log("This is right");
                        }
                    }
                    if (Input.GetKey(KeyCode.C))
                        if (Option3 == true)
                        {
                            Debug.Log("this is right");
                            QuizObjs[0].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                            QuizObjs[1].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                            QuizObjs[2].gameObject.GetComponent<Renderer>().material.color = correctColor;
                        }
                        else
                        {
                            Debug.Log("This is wrong");
                        }
                    break;
            }
        }
    }
}

