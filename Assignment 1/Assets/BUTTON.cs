using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class BUTTON : MonoBehaviour
{
    public Text textComponent;

    public void OnButtonClick()
    {
        textComponent.text = "Button Clicked!";
    }
}
