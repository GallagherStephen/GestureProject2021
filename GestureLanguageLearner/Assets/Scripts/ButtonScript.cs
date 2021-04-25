using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    
    public void ButtonMoveScene(string levelSelect)
    {
        SceneManager.LoadScene(levelSelect);
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
