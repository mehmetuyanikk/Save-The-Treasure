using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RegisterButton : MonoBehaviour
{
    public void RegisterButtonOnClick()
    {
        SceneManager.LoadScene(0);
    }
}
