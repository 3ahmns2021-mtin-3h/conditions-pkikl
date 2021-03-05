using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private bool buttonPressed = false;
    private bool spacebarPressed = false;
    private bool numbersPressed = false;
    private bool pinCorrect = false;


    private bool onePressed = false;
    private bool twoPressed = false;
    private bool threePressed = false;
    private bool fourPressed = false;



    private float timeCounter = 0f;

    public string secretPin;

    public InputField inputField;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            timeCounter += Time.deltaTime;
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            timeCounter = 0;
        }

        if(timeCounter >= 3)
        {
            spacebarPressed = true;
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            onePressed = true;
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            twoPressed = true;
        }

        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            threePressed = true;
        }

        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            fourPressed = true;
        }

        if(onePressed && twoPressed && threePressed && fourPressed)
        {
            numbersPressed = true;
        }


        if((buttonPressed && spacebarPressed)||(spacebarPressed && numbersPressed)||(numbersPressed && pinCorrect))
        {
            Debug.Log("true");
        }

        else
        {
            Debug.Log("false");
        }


    }

    public void ButtonPressed()
    {
        buttonPressed = true;
    }

    public void InputText()
    {
        if(inputField.text == secretPin)
        {
            pinCorrect = true;
        }
    }
}
