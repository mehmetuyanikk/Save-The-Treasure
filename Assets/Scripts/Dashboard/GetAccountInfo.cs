using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GetAccountInfo
{
    public string DisplayName { get; set; }
    public string PlayerID { get; set; }
    public string Email { get; set; }
    public string AvatarURL { get; set; }

    public bool DashboardInfo { get; set; }
    public bool DownloadAvatarInfo { get; set; }

    public void AccountInfo()
    {
        PlayFabClientAPI.GetAccountInfo(new GetAccountInfoRequest(),

            Result =>
            {
                DisplayName = Result.AccountInfo.TitleInfo.DisplayName;
                PlayerID = Result.AccountInfo.PlayFabId;
                Email = Result.AccountInfo.PrivateInfo.Email;
                AvatarURL = Result.AccountInfo.TitleInfo.AvatarUrl;

                DashboardInfo = true;

            },

            Error =>
            {
                DashboardInfo = false;
            }

            );
    }

    public IEnumerator DownloadAvatar(string _avatarUrl, RawImage _avatarImage)
    {
        UnityWebRequest _request = UnityWebRequestTexture.GetTexture(_avatarUrl);
        yield return _request.SendWebRequest();

        _avatarImage.texture = ((DownloadHandlerTexture)_request.downloadHandler).texture;
        DownloadAvatarInfo = true;

    }

}
