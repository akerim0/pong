using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menumanager : MonoBehaviour
{
    // Start is called before the first frame update
  

    // Update is called once per frame
    public void Load(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
