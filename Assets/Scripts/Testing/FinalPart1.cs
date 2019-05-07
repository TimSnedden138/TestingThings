using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class FinalPart1 : MonoBehaviour
{
    public List<Text> texts = new List<Text>();
    public Text Question;
    public List<GameObject> CorrectObjs = new List<GameObject>();
    public List<GameObject> ChoiceObjs = new List<GameObject>();
    public List<int> Q1 = new List<int>();
    public List<int> Q2 = new List<int>();
    public List<int> Q3 = new List<int>();
    public List<int> Q4 = new List<int>();
    int correctAnswers = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < ChoiceObjs.Count; i++)
        {
            ChoiceObjs[i].gameObject.GetComponent<Renderer>().material.color = Color.white;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (correctAnswers == 0)
        {
            Question1();
        }

        if (correctAnswers == 1)
        {
            Question2();
        }
        if (correctAnswers == 2)
        {
            Question3();
        }
        if (correctAnswers == 3)
        {
            Question4();
        }
        if(correctAnswers == 4)
        {
            Win();
        }
        if (correctAnswers > 5)
        {
            Lose();
        }
    }
    void Question1()
    {
        Question.text = "How many Answers were in the first trial";
        texts[0].text = "" + Q1[0];
        texts[1].text = "" + Q1[1];
        texts[2].text = "" + Q1[2];
        if (Input.GetKey(KeyCode.Z))
        {
            CorrectObjs[0].gameObject.GetComponent<Renderer>().material.color = Color.green;
            correctAnswers = correctAnswers + 1;
        }
        else if (Input.GetKey(KeyCode.X)|| Input.GetKey(KeyCode.C))
        {
            CorrectObjs[0].gameObject.GetComponent<Renderer>().material.color = Color.red;
            correctAnswers = correctAnswers + 1;
        }
    }
    void Question2()
    {
        Question.text = "How Many Color trials were their";
        texts[0].text = "" + Q2[0];
        texts[1].text = "" + Q2[1];
        texts[2].text = "" + Q2[2];
        if (Input.GetKey(KeyCode.C))
        {
            CorrectObjs[1].gameObject.GetComponent<Renderer>().material.color = Color.green;
            correctAnswers = correctAnswers + 1;
        }
        else if(Input.GetKey(KeyCode.X) || Input.GetKey(KeyCode.Z))
        {
            CorrectObjs[1].gameObject.GetComponent<Renderer>().material.color = Color.red;
            correctAnswers = correctAnswers + 1;
        }
    }
    void Question3()
    {
        Question.text = "How many numbers were on the PIN code";
        texts[0].text = "" + Q3[0];
        texts[1].text = "" + Q3[1];
        texts[2].text = "" + Q3[2];
        if (Input.GetKey(KeyCode.X))
        {
            CorrectObjs[2].gameObject.GetComponent<Renderer>().material.color = Color.green;
            correctAnswers = correctAnswers + 1;
        }
        else if(Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.C))
        {
            CorrectObjs[2].gameObject.GetComponent<Renderer>().material.color = Color.red;
            correctAnswers = correctAnswers + 1;
        }
    }
    void Question4()
    {
        Question.text = "What Order did the Colors Go";
        texts[0].text = "" + Q4[0] + Q4[1] + Q4[2] + Q4[3];
        texts[1].text = "" + Q4[1] + Q4[0] + Q4[3] + Q4[2];
        texts[2].text = "" + Q4[2] + Q4[1] + Q4[0] + Q4[3];
        if (Input.GetKey(KeyCode.C))
        {
            CorrectObjs[3].gameObject.GetComponent<Renderer>().material.color = Color.green;
            correctAnswers = correctAnswers + 1;
        }
        else if(Input.GetKey(KeyCode.X) || Input.GetKey(KeyCode.Z))
        {
            CorrectObjs[3].gameObject.GetComponent<Renderer>().material.color = Color.red;
            correctAnswers = correctAnswers + 2;
        }
    }
    void Win()
    {
        Question.text = "You Win";
        ChoiceObjs[0].gameObject.GetComponent<Renderer>().material.color = Color.green;
        ChoiceObjs[1].gameObject.GetComponent<Renderer>().material.color = Color.green;
        ChoiceObjs[2].gameObject.GetComponent<Renderer>().material.color = Color.green;
    }
    void Lose()
    {
        Question.text = "You Lose";
        ChoiceObjs[0].gameObject.GetComponent<Renderer>().material.color = Color.red;
        ChoiceObjs[1].gameObject.GetComponent<Renderer>().material.color = Color.red;
        ChoiceObjs[2].gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
}
