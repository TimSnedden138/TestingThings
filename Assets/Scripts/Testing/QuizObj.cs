using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizObj : MonoBehaviour
{
    public GameObject obj;
    public ObjChild objChild;
    public Color wrongColor;
    public Color correctColor;

    void Start()
    {
        switch(Random.Range(0,2))
        {
            case 0:
                objChild.Obj.GetComponent<Renderer>().material.color = wrongColor;
                objChild.CorrectVal = 0;
                break;
            case 1:
                objChild.Obj.GetComponent<Renderer>().material.color = correctColor;
                objChild.CorrectVal = 1;
                break;
        }
        switch(objChild.CorrectVal)
        {
            case 0:
                obj.gameObject.GetComponent<BoxCollider>().isTrigger = false;
                break;
            case 1:
                obj.gameObject.GetComponent<BoxCollider>().isTrigger = true;
                break;
        }


    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("This is a interactable");   
        }
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && Input.GetKeyDown(KeyCode.E))
        {
            Debug.Log("This is being interacted with");
        }
        
    }
}
[System.Serializable]
public class ObjChild
{
    public GameObject Obj;
    public int CorrectVal;
}
