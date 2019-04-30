using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Quiz : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>();
    public List<Text> texts = new List<Text>();
    public int correctVal;
    public int randomVal;
    void Start()
    {
        for (int i = 0; i < objects.Count; i++)
        {
            objects[i].gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
        for (int t = 0; t < objects.Count; t++)
        {
            if (objects[t].GetComponent<QuizObj>().objChild.CorrectVal == 1)
            {
                correctVal = correctVal + 1;
            }
            else if (objects[t].GetComponent<QuizObj>().objChild.CorrectVal == 0)
            {
                Debug.Log("Not One of the Values");
            }
        }
        randomVal = Random.Range(0, 12 - correctVal);
        switch (Random.Range(0, 2))
        {
            case 0:
                texts[0].text = "Left Choice " + correctVal;
                texts[1].text = "Middle Choice " + randomVal;
                texts[2].text = "Right Choice " + randomVal;
                break;
            case 1:
                texts[0].text = "Left Choice " + randomVal;
                texts[1].text = "Middle Choice " + correctVal;
                texts[2].text = "Right Choice " + randomVal;
                break;
            case 2:
                texts[0].text = "Left Choice " + randomVal;
                texts[1].text = "Middle Choice " + randomVal;
                texts[2].text = "Right Choice " + correctVal;
                break;
        }
    }
}
