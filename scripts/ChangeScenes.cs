using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//To change between scenes
public class ChangeScenes : MonoBehaviour
{
 
    public void GotoScenes()
    {
        SceneManager.LoadScene("Scenes");
    }
    public void GotoCategories()
    {
        SceneManager.LoadScene("Categories");
    }
    public void GotoCameraView()
    {
        SceneManager.LoadScene("CameraView");
    }
    public void GotoHome()
    {
        SceneManager.LoadScene("HomePage");
    }

    

    public void GotoPark()
    {
       
        SceneManager.LoadScene("Park");
    }

}
