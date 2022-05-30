using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.SceneManagement;

public class UpdateDisplayName : MonoBehaviour
{
    [SerializeField] InputField _displayName;

    public void UpdateDisplayNameOnClick()
    {
        PlayFabClientAPI.UpdateUserTitleDisplayName(new UpdateUserTitleDisplayNameRequest()
        {
            DisplayName = _displayName.text
        },
        Success =>
        {
            Debug.Log("Kullan�c� Ad� Ba�ar�yla De�i�tirildi");
        },
        Error =>
        {
            Debug.Log("Display Name G�ncellenemedi");
        }

            );
    }
}
