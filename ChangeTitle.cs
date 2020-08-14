using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTitle : MonoBehaviour
{
    public Text txtObject;
    public GameObject cat;
    public GameObject monkey;
    public GameObject tiger;
    public GameObject cow;

    // Start is called before the first frame update
    void Start()
    {
        txtObject = GetComponent<Text>();
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
