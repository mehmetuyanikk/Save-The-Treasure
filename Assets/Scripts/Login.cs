using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Login : MonoBehaviour
{

    LoginBase _loginBase;
    InputController _inputController;

    [SerializeField] InputField Username, _password;
    [SerializeField] Button _loginButton;
    [SerializeField] GameObject _asyncPanel;
    [SerializeField] Text _asyncInfo;

    private void Awake()
    {
        _loginBase = new LoginBase();
        _inputController = new InputController();
    }

    public void LoginOnClick()
    {
        StartCoroutine(LoginAsyncControl());
    }

    public void LoginControl()
    {
        _inputController.LoginInputControl(Username, _password, _loginButton);
    }

    public void LoginGuestOnClick()
    {
        _loginBase.LoginGuest();
    }

    IEnumerator LoginAsyncControl()
    {
        _asyncPanel.SetActive(true);
        _asyncInfo.text = "Giriþ Yapýlýyor";
        _loginBase.LoginUser(Username, _password);

        yield return new WaitUntil(() => _loginBase.Login_Async);
    }

}
