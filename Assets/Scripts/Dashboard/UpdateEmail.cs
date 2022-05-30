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
            Debug.Log("Email Ba�ar�yla De�i�tirildi");
        },
        Error =>
        {
            Debug.Log("Email de�i�tirilemedi");
        }

            );
    }
}
