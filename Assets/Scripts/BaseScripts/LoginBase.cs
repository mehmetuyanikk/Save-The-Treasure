using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.SceneManagement;

public class LoginBase
{
    public bool Login_Async { get; set; }

    public void LoginUser(InputField _email, InputField _password)
    {
        PlayFabClientAPI.LoginWithPlayFab(new LoginWithPlayFabRequest()

        {
            Username = _email.text,
            Password = _password.text
        },

        Result =>
        {
            Login_Async = true;
            SceneManager.LoadScene(1);
        },

        Error =>
        {
            Debug.Log("Giriþ Baþarýsýz");
            Login_Async = false;
        }

            );
    }

    public void LoginGuest()
    {
        PlayFabClientAPI.LoginWithCustomID(new LoginWithCustomIDRequest()
        {
            CreateAccount = true,
            CustomId = "Misafir Girisi",
        },

        Success =>
        {
            Debug.Log("Misafir Girisi Basarili");
            SceneManager.LoadScene(3);
        },

        Error =>
        {
            Debug.Log("Misafir Girisi Basarisiz");
        }

            );
    }

}
