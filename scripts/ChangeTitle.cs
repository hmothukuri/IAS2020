using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//To the change the animal name which has been selected in the next scene
public class ChangeTitle : MonoBehaviour
{
//variables to hold the reference of game objects
    public Text txtObject; 
    public GameObject cat;
    public GameObject monkey;
    public GameObject tiger;
    public GameObject cow;

    // Start is called before the first frame update
    void Start()
    {
    //each game object is assigned to respective variable
        txtObject = GetComponent<Text>();
    //accessing the public variable from the globalvars class
        txtObject.text = GlobalVars.selectedAnimal;

        if(txtObject.text == "Cat")
        {
            cat.SetActive(true);

            cow.SetActive(false);
            monkey.SetActive(false); 
            tiger.SetActive(false);
        }
        if (txtObject.text == "Tiger")
        {
            cat.SetActive(false);
             cow.SetActive(false);
            monkey.SetActive(false);
            tiger.SetActive(true);
        }
        if (txtObject.text == "Monkey")
        {
            cat.SetActive(false);
            cow.SetActive(false);
            monkey.SetActive(true);
            tiger.SetActive(false);
        }
        if (txtObject.text == "Cow")
        {
            cat.SetActive(false);
            cow.SetActive(true);
            monkey.SetActive(false);
            tiger.SetActive(false);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
