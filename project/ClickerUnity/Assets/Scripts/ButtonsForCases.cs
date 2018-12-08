using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class ButtonsForCases : MonoBehaviour {
    int stage = 1;
    //Random realRnd = new Random();
    //int min = 10, max = 10000;
    public Text text;
    public Text textShowStage;
    public Text ShowMeNameOfCase;
    private void Awake()
    {
        
    }
    private void OnMouseDown()
    {
        
    }

    private void OnMouseUp()
    {
        
    }

    private void OnMouseUpAsButton()
    {
        if (stage == 5)
        {
            stage = 1;
        }
        SwitchCase();
        

        stage++;
        
        /*Debug.Log("случайные числа в диапазоне [" + min + "," + max + "]");
        Debug.Log("Число " + "= " + realRnd.Next(min, max));
        int x = realRnd.Next(min, max);
        text.text = "Вы получили " + x + " деталей, потратьте же их куда-нибудь!";*/
    }
    public void ShowAmount(int min, int max)
    {
        Random realRnd = new Random();
        /*Debug.Log("случайные числа в диапазоне [" + min + "," + max + "]");
        Debug.Log("Число " + "= " + realRnd.Next(min, max));*/
        switch (gameObject.name) {
            case "FirstCase":
                int x1 = realRnd.Next(min, max)*1;
                text.text = "Вы получили " + x1 + " деталей, потратьте же их куда-нибудь!";
                ShowMeNameOfCase.text = "I'm First Case";
                break;
            case "SecondCase":
                int x2 = realRnd.Next(min, max)*3;
                text.text = "Вы получили " + x2 + " деталей, потратьте же их куда-нибудь!";
                ShowMeNameOfCase.text = "I'm Second Case";
                break;
            case "ThirdCase":
                int x3 = realRnd.Next(min, max)*5;
                text.text = "Вы получили " + x3+ " деталей, потратьте же их куда-нибудь!";
                ShowMeNameOfCase.text = "I'm Third Case";
                break;
        }
        
    }
    public void SwitchCase()
    {
        switch (stage)
        {

            case 1:
                ShowAmount(10, 100);
                textShowStage.text = "1st Stage";
                break;
            case 2:
                ShowAmount(100, 1000);
                textShowStage.text = "2nd Stage";
                break;
            case 3:
                ShowAmount(1000, 10000);
                textShowStage.text = "3rd Stage";
                break;
            case 4:
                ShowAmount(10000, 100000);
                textShowStage.text = "4th Stage";
                break;


        }
    }
}
    

