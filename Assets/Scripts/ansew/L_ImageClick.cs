using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class L_ImageClick : MonoBehaviour, IPointerClickHandler
{
    public static string clickName;
    public static int clickNum = 0;

    public void OnPointerClick(PointerEventData eventData)
    {

        clickName = this.name;

        if (clickName == "Panel")
        {
            clickNum++;
            if (L_Problems.isTrue)
            {
                demo.proLevel++;
                L_Problems.isTrue = false;
                SceneManager.LoadScene("answer");

            }
        }
        if (L_Problems.val == 0)
        {
            if(clickName == "OptionB")
            {
                L_Problems.trueNum++;
            }
        }
        if (L_Problems.val == 1)
        {
            if (clickName == "OptionC")
            {
                L_Problems.trueNum++;
            }
        }
        if (L_Problems.val == 2)
        {
            if (clickName == "OptionC")
            {
                L_Problems.trueNum++;
            }
        }
        if (L_Problems.val == 3)
        {
            if (clickName == "OptionB")
            {
                L_Problems.trueNum++;
            }
        }
        if (L_Problems.val == 4)
        {
            if (clickName == "OptionC")
            {
                L_Problems.trueNum++;
            }
        }
        if (L_Problems.val == 5)
        {
            if (clickName == "OptionD")
            {
                L_Problems.trueNum++;
            }
        }
        if (L_Problems.val == 6)
        {
            if (clickName == "OptionA")
            {
                L_Problems.trueNum++;
            }
        }
        if (L_Problems.val == 7)
        {
            if (clickName == "OptionC")
            {
                L_Problems.trueNum++;
            }
        }
        if (L_Problems.val == 8)
        {
            if (clickName == "OptionD")
            {
                L_Problems.trueNum++;
            }
        }
        if (L_Problems.val == 9)
        {
            if (clickName == "OptionD")
            {
                L_Problems.trueNum++;
            }
        }
        if (L_Problems.val == 10)
        {
            if (clickName == "OptionA")
            {
                L_Problems.trueNum++;
            }
        }
        if (L_Problems.val == 11)
        {
            if (clickName == "OptionC")
            {
                L_Problems.trueNum++;
            }
        }
        if (L_Problems.val == 12)
        {
            if (clickName == "OptionA")
            {
                L_Problems.trueNum++;
            }
        }
        if (L_Problems.val == 13)
        {
            if (clickName == "OptionB")
            {
                L_Problems.trueNum++;
            }
        }
        if (L_Problems.val == 14)
        {
            if (clickName == "OptionB")
            {
                L_Problems.trueNum++;
            }
        }
        if (L_Problems.val == 15)
        {
            if (clickName == "OptionA")
            {
                L_Problems.trueNum++;
            }
        }
        if (L_Problems.val == 16)
        {
            if (clickName == "OptionD")
            {
                L_Problems.trueNum++;
            }
        }
        if (L_Problems.val == 17)
        {
            if (clickName == "OptionD")
            {
                L_Problems.trueNum++;
            }
        }
    }

}

