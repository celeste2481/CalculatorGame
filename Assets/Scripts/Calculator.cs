using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class Calculator : MonoBehaviour {


    public Text inputField;

    string inputString;
    int[] number = new int[2];
    string operatorSymbol;
    int i = 0;
    int result;
    bool displayedResults = false;

    public void Press()
    {
        if(displayedResults == true)
        {
            inputField.text = "";
            inputString = "";
            displayedResults = false;
        }
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
        string buttonValue = EventSystem.current.currentSelectedGameObject.name;
        inputString += buttonValue;

        int arg;
        if (int.TryParse(buttonValue, out arg))
        {
            if (i > 1) i = 0;
            number[i] = arg;
            i = i + 1;
        }
        else
        {
            switch (buttonValue)
            {
                case "+":
                    operatorSymbol = buttonValue;
                    break;
                case "-":
                    operatorSymbol = buttonValue;
                    break;
                case "*":
                    operatorSymbol = buttonValue;
                    break;
                case "/":
                    operatorSymbol = buttonValue;
                    break;
                case "=":
                    switch (operatorSymbol)
                    {
                        case "+":
                            result = number[0] + number[1];
                            break;
                        case "-":
                            result = number[0] - number[1];
                            break;
                        case "*":
                            result = number[0] * number[1];
                            break;
                        case "/":
                            result = number[0] / number[1];
                            break;
                    }

                    displayedResults = true;
                    inputString = result.ToString();
                    number = new int[2];
                    break;
            }
        }


        

        inputField.text = inputString;

    }

}
