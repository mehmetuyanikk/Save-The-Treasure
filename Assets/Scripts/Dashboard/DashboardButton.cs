using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DashboardButton : MonoBehaviour
{
    public void DashboardPanelOnClick()
    {
        SceneManager.LoadScene(2);
    }
}
