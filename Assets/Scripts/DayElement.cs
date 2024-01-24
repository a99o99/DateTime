using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class DayElement : MonoBehaviour
{
    public TextMeshProUGUI textDay;

    public void Init(int __i, int __firstDayOfWeek)
    {
        textDay.text = (__i - __firstDayOfWeek + 1).ToString();
        switch((__i + 7) % 7)
        {
            case 0:
                textDay.color = Color.red;
                break;
            case 6: 
                textDay.color = Color.blue;
                break;
        }
    }
}
