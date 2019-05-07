using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Quiz : MonoBehaviour
{
    public List<GameObject> TrialObjs = new List<GameObject>();
    public List<Text> texts = new List<Text>();
    public Text Question;
    public List<GameObject> QuizObjs = new List<GameObject>();
    public RawImage WrongColorImg;
    public Camera PlayerCam;
    public Color correctColor;
    public Color wrongColor;
    Scene scene;
    int correctOption;
    int randomNumber1;
    int randomNumber2;
    public int QuestionVal;
    public string QuestionNumber;
    bool isAvalible = false;
    int Cases;
    void Start()
    {
        scene = SceneManager.GetActiveScene();
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
        randomNumber1 = Random.Range(0, TrialObjs.Count - correctOption - randomNumber2);
        randomNumber2 = Random.Range(0, TrialObjs.Count - correctOption - randomNumber1);
        if (randomNumber2 == correctOption)
        {
            randomNumber2 = Random.Range(0,TrialObjs.Count - correctOption - randomNumber1);
        }
        if (randomNumber1 == correctOption)
        {
            randomNumber1 = Random.Range(0, TrialObjs.Count - correctOption - randomNumber2);
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
                    if (Input.GetKey(KeyCode.Z))
                    {
                            Debug.Log("this is right");
                            QuizObjs[0].gameObject.GetComponent<Renderer>().material.color = correctColor;
                            Win();
                            isAvalible = true;
                    }
                    if (Input.GetKey(KeyCode.X))
                    {
                        QuizObjs[1].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                        Debug.Log("This is wrong");

                    }
                    if (Input.GetKey(KeyCode.C))
                    {
                        QuizObjs[2].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                        Debug.Log("This is wrong");

                    }
                    break;
                case 1:
                    texts[0].text = "Left Choice " + randomNumber1;
                    texts[1].text = "Middle Choice " + correctOption;
                    texts[2].text = "Right Choice " + randomNumber2;
                    if (Input.GetKey(KeyCode.Z))
                    {

                        QuizObjs[0].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                        Debug.Log("This is wrong");

                    }
                    if (Input.GetKey(KeyCode.X))
                    {
                            Debug.Log("this is right");
                            QuizObjs[1].gameObject.GetComponent<Renderer>().material.color = correctColor;
                            Win();
                            isAvalible = true;
                    }
                    if (Input.GetKey(KeyCode.C))
                    {
                        QuizObjs[2].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                        Debug.Log("This is wrong");

                    }
                    break;
                case 2:
                    texts[0].text = "Left Choice " + randomNumber1;
                    texts[1].text = "Middle Choice " + randomNumber2;
                    texts[2].text = "Right Choice " + correctOption;
                    if (Input.GetKey(KeyCode.Z))
                    {
                        QuizObjs[0].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                        Debug.Log("This is wrong");

                    }
                    if (Input.GetKey(KeyCode.X))
                    {
                        QuizObjs[1].gameObject.GetComponent<Renderer>().material.color = wrongColor;
                        Debug.Log("This is wrong");

                    }
                    if (Input.GetKey(KeyCode.C))
                    {
                        Debug.Log("this is right");
                        QuizObjs[2].gameObject.GetComponent<Renderer>().material.color = correctColor;
                        Win();
                        isAvalible = true;
                        
                    }
                    break;
            }
            if(Input.GetKey(KeyCode.Space) && isAvalible == true)
            {
                Debug.Log("Going to the next question");
                Question.text = "Going to the next question";
                NextQuestion();
            }
        } 
    }
    void Win()
    {
        if (scene.name != "Q3")
        {
            Question.text = "You have beaten the " + QuestionNumber + " question Are you ready for the next question " +
            "Press Space to Continue";
        }
        if (scene.name == "Q3")
        {
            Question.text = "You have beaten the " + QuestionNumber + " question Good Job " +
            "Press Space to Continue to the final trial for the section";
        }
        WrongColorImg.gameObject.SetActive(false);

    }
    void NextQuestion()
    {
        SceneManager.LoadScene("Q" + QuestionVal);
    }

}

