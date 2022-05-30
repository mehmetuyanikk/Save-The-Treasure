using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;

public class RegisterBase
{
    public bool RegisterBase_Async { get; set; }

    public void RegisterEmail(InputField _username, InputField _email, InputField _password)
    {
        PlayFabClientAPI.RegisterPlayFabUser(new RegisterPlayFabUserRequest()

        {
            Username = _username.text,
            Email = _email.text,
            Password = _password.text,
            DisplayName = _username.text
        },

        Result =>
        {
            RegisterBase_Async = true;
            Debug.Log("Kayýt Tamamlandý");
        },

        Error =>
        {
            RegisterBase_Async = false;
            Debug.Log("Kayýt Baþarýsýz");
        }

            );
    }

}
