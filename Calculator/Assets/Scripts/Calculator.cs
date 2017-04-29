using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

public class Calculator : MonoBehaviour {


    public Text inputField;
    public Text randomField;

    string inputString;
    int[] number = new int[2];
    string operatorSymbol;
    int i = 0;
    int result;
    bool displayedResults = false;
    bool plus = false;
    bool minus = false;
    bool mult = false;
    bool div = false;
    byte[] randomList = new byte[15];
    string randomChoice;
    byte randomString;
    int pirateMonkey = 0;

    public void numGen()
    {
        if (pirateMonkey == 0)
        {


            randomList[0] = 0;
            randomList[1] = 1;
            randomList[2] = 2;
            randomList[3] = 3;
            randomList[4] = 4;
            randomList[5] = 5;
            randomList[6] = 6;
            randomList[7] = 7;
            randomList[8] = 8;
            randomList[9] = 9;
            randomList[10] = 10;
            randomList[11] = 12;
            randomList[12] = 14;
            randomList[13] = 15;
            randomList[14] = 16;

            randomString = randomList[pirateMonkey];
            randomField.text += randomString;

            pirateMonkey++;
        }
    }

    public void Press()
    {
        if (plus == true & minus == true & mult == true & div == true)
        {
            plus = false;
            minus = false;
            mult = false;
            div = false;
        }

            if (displayedResults == true)
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
                                if (plus == false)
                                {
                                    result = number[0] + number[1];
                                    plus = true;
                                    inputString = result.ToString();
                                    break;
                                }
                                else
                                {
                                    result = 0;
                                    inputString = "use dif operand";
                                }
                                break;
                            case "-":
                                if (minus == false)
                                {
                                    result = number[0] - number[1];
                                    minus = true;
                                    inputString = result.ToString();
                                    break;
                                }
                                else
                                {
                                    result = 0;
                                    inputString = "use dif operand";
                                }
                                break;
                            case "*":
                                if (mult == false)
                                {
                                    result = number[0] * number[1];
                                    mult = true;
                                    inputString = result.ToString();
                                    break;
                                }
                                else
                                {
                                    result = 0;
                                    inputString = "use dif operand";
                                }
                                break;
                            case "/":
                                if (div == false)
                                {
                                    result = number[0] / number[1];
                                    div = true;
                                    inputString = result.ToString();
                                    break;
                                }
                                else
                                {
                                    result = 0;
                                    inputString = "use dif operand";
                                }
                                break;
                        }

                        displayedResults = true;

                        number = new int[2];
                        break;
                }
            }





        

        inputField.text = inputString;

    }

}
