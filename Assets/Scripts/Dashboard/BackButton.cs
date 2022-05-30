using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{

    [SerializeField] GameObject _dashboardPanel, _displayNamePanel;

    public void BackButtonOnClick()
    {
        switch (_displayNamePanel.activeInHierarchy)
        {
            case true:
                _displayNamePanel.SetActive(false);
                _dashboardPanel.SetActive(true);
                break;

            default:
                _displayNamePanel.SetActive(true);
                _dashboardPanel.SetActive(false);
                break;
        }
    }
}
