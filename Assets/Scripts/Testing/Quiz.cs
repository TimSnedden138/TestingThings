using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Quiz : MonoBehaviour
{
    public List<GameObject> objects = new List<GameObject>();
    public List<Text> texts = new List<Text>();
    public int correctVals;
    void Start()
    {
        for(int i = 0; i < objects.Count; i++)
        {
            objects[i].gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
        for (int t = 0; t < objects.Count; t++)
        {
            if (objects[t].GetComponent<QuizObj>().objChild.CorrectVal == 1)
            {
                correctVals = correctVals + 1;
            }
            else if (objects[t].GetComponent<QuizObj>().objChild.CorrectVal == 0)
            {
                Debug.Log("Not One of the Values");
            }
        }
        switch (Random.Range(0, 2))
        {
            case 0:
                texts[0].text = "Left Choice" + correctVals;
                texts[1].text = "Middle Choice" + Random.Range(0,12 - correctVals);
                texts[2].text = "Right Choice" + Random.Range(0, 12 - correctVals);
                break;
            case 1:
                texts[0].text = "Left Choice" + Random.Range(0,12 - correctVals);
                texts[1].text = "Middle Choice" + correctVals;
                texts[2].text = "Right Choice" + Random.Range(0, 12 - correctVals);
                break;
            case 2:
                texts[0].text = "Left Choice" + Random.Range(0,12 - correctVals);
                texts[1].text = "Middle Choice" + Random.Range(0, 12 - correctVals);
                texts[2].text = "Right Choice" + correctVals;
                break;
        }
    }
}
