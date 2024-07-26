using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SigIn : MonoBehaviour
{
    public string Name;
    public string Pass;

    public InputField UserName;
    public InputField Password;
    public Text LoginInfo;
    public Text PasswordInfo;

    string username;
    string password;

    public void UserNameEnter(string name)
    {
        name = UserName.text;
        username = name;
    }

    public void UserPasswordEnter(string pass)
    {
        pass = Password.text;
        password = pass;
    }

    public void CheckData()
    {
        LoginInfo.text = "";
        PasswordInfo.text = "";

        if (username == Name && password == Pass)
        {
            Debug.Log("Success entered");
        }
        
        if (username != Name)
        {
            LoginInfo.text = "Wrong login";
        }

        if (password != Pass)
        {
            PasswordInfo.text = "Wrong password";
        }
        
    }
}
