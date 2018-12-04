using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class ButtonsForCases : MonoBehaviour {
    Random realRnd = new Random();
    int min = 10, max = 10000;
    public Text text;
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
        Debug.Log("случайные числа в диапазоне [" + min + "," + max + "]");
        Debug.Log("Число " + "= " + realRnd.Next(min, max));
        int x = realRnd.Next(min, max);
        text.text = "Вы получили " + x + " деталей, потратьте же их куда-нибудь!";
    }
}
