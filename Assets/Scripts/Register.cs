using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Register : MonoBehaviour
{
    RegisterBase _registerBase;
    InputController _inputController;
    GetDefaultAvatarImage _getDefaultAvatarImage;

    [SerializeField] InputField _email, _password, _username, _repeatPassword;
    [SerializeField] Button _registerButton;
    [SerializeField] GameObject _asyncPanel;
    [SerializeField] Text _asyncInfo;

    [SerializeField] public string _avatarUrl;

    private void Awake()
    {
        _registerBase = new RegisterBase();
        _inputController = new InputController();
        _getDefaultAvatarImage = new GetDefaultAvatarImage();
    }

    public void RegisterOnClick()
    {
        StartCoroutine(RegisterAsyncControl());
    }

    IEnumerator RegisterAsyncControl()
    {
        _asyncPanel.SetActive(true);
        _asyncInfo.text = "Kayýt oluþturuluyor";
        _registerBase.RegisterEmail(_username, _email, _password);
        yield return new WaitForSeconds(2f);
        _asyncPanel.SetActive(false);

        yield return new WaitUntil(() => _registerBase.RegisterBase_Async);
        _asyncInfo.text = "Kayýt Oluþturuldu";

        _getDefaultAvatarImage.GetDefaultAvatar(_avatarUrl);
        yield return new WaitUntil(() => _getDefaultAvatarImage._isAvatarUploaded);

        yield return new WaitForSeconds(2f);
        _asyncPanel.SetActive(false);
    }

    public void RegisterControl()
    {
        _inputController.LoginInputControl(_username, _password, _registerButton);
    }

}
