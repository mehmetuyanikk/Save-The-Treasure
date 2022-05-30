using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;

public class UpdateEmail : MonoBehaviour
{

    [SerializeField] InputField _email;

    public void UpdateEmailOnClick()
    {
        PlayFabClientAPI.RegisterPlayFabUser(new RegisterPlayFabUserRequest()
        {
            Email = _email.text
        },
        Success =>
        {
            Debug.Log("Email Baþarýyla Deðiþtirildi");
        },
        Error =>
        {
            Debug.Log("Email deðiþtirilemedi");
        }

            );
    }
}
