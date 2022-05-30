using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;

public class ChangeImage : MonoBehaviour
{

    [SerializeField] GameObject _changeImagePanel, _dashboardPanel;

    public void ChangeImageOnClick()
    {

        PlayFabClientAPI.UpdateAvatarUrl(new UpdateAvatarUrlRequest()

        {
            ImageUrl = "https://www.gravatar.com/userimage/182198420/7aae4fb15c04efdcd23c446dd1da3a8c?size=120"
        },
    Success => { }, Error => { }

            );

        switch (_changeImagePanel.activeInHierarchy)
        {
            case true:
                _changeImagePanel.SetActive(false);
                _dashboardPanel.SetActive(true);
                break;

            default:
                _changeImagePanel.SetActive(true);
                _dashboardPanel.SetActive(false);
                break;
        }

    }
}
