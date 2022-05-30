using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    [SerializeField] Text _playerInfo;

    GetAccountInfo _getAccountInfo;

    private void Awake()
    {
        _getAccountInfo = new GetAccountInfo();
        _getAccountInfo.AccountInfo();
    }

    private void Start()
    {
        StartCoroutine(PlayerNameInfo());
    }

    void PlayerNameText()
    {
        _playerInfo.text = _getAccountInfo.DisplayName;
    }

    IEnumerator PlayerNameInfo()
    {
        yield return new WaitUntil(() => _getAccountInfo.DashboardInfo);
        PlayerNameText();
    }
}
