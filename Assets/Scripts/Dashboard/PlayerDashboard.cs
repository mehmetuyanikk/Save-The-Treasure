using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDashboard : MonoBehaviour
{
    [SerializeField] Text _displayName, _email, _playerID;
    //[SerializeField] GameObject _asyncPanel;
    [SerializeField] RawImage _avatarImage;

    string _tempUrl;

    GetAccountInfo _getAccountInfo;

    private void Awake()
    {
        _getAccountInfo = new GetAccountInfo();
        _getAccountInfo.AccountInfo();
    }

    private void Start()
    {
        StartCoroutine(AsyncDashboard());
    }

    IEnumerator AsyncDashboard()
    {
        yield return new WaitUntil(() => _getAccountInfo.DashboardInfo);
        PlayerInfo();
        StartCoroutine(_getAccountInfo.DownloadAvatar(_tempUrl, _avatarImage));
        yield return new WaitUntil(() => _getAccountInfo.DownloadAvatarInfo);
    }

    void PlayerInfo()
    {
        _displayName.text = _getAccountInfo.DisplayName;
        _email.text = _getAccountInfo.Email;
        _playerID.text = _getAccountInfo.PlayerID;
        _tempUrl = _getAccountInfo.AvatarURL;
    }

}
