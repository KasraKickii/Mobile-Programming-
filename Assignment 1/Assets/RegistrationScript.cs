using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class RegistrationScript : MonoBehaviour
{
    public InputField nameInputField;
    public InputField emailInputField;
    public InputField passwordInputField;
    public InputField ConfirmPasswordInputField;
    public Text RegistrationInfoText;
    public Text validationText;

    public void OnRegisterButtonClick()
    {
        string name = nameInputField.text;
        string email = emailInputField.text;
        string password = passwordInputField.text;
        string confirmPassword = ConfirmPasswordInputField.text;

         if (password != confirmPassword)
        {
            validationText.text = "Passwords do not match!!";
            return;
        }
        RegistrationInfoText.text = "Name: " + name + "\nEmail: " + email + "\nPassword: " + password;

        nameInputField.text = "";
        emailInputField.text = "";
        passwordInputField.text = "";
        ConfirmPasswordInputField.text = "";
        validationText.text = "";
    }



}
