using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSelector : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

    // Update is called once per frame
    public void QuitRequest()
    {
        Application.Quit();
    }
}
