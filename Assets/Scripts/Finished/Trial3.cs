using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Trial3 : MonoBehaviour
{
    public List<TrialObject3> objects = new List<TrialObject3>();
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < objects.Count; i++)
        {
            objects[i].Obj.GetComponent<Renderer>().material.color = Color.black;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
        {
            objects[0].Obj.GetComponent<Renderer>().material.color = Color.red;
            if (Input.GetKey(KeyCode.Alpha2))
            {
                objects[2].Obj.GetComponent<Renderer>().material.color = Color.green;
                if (Input.GetKey(KeyCode.Alpha3))
                {
                    objects[3].Obj.GetComponent<Renderer>().material.color = Color.yellow;
                    if (Input.GetKey(KeyCode.Alpha4))
                    {
                        SceneManager.LoadScene("Color1");
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < objects.Count; i++)
            {
                objects[i].Obj.GetComponent<Renderer>().material.color = Color.black;
            }
        }
    }
}
[System.Serializable]
public class TrialObject3
{
    public GameObject Obj;
}
