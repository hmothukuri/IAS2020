using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GoToPark : MonoBehaviour
{
   //creating dropdown object 
   private GameObject dd;
   
    public TextMeshProUGUI txtObject;
   
    // Start is called before the first frame update
    void Start()
    {
    //assigning the variables to dropdown menu 
        dd = GameObject.FindGameObjectWithTag("dropdown");
        txtObject = dd.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        GlobalVars.selectedAnimal = txtObject.text;

    }


    
}
