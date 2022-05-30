using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDisplayNamePanel : MonoBehaviour
{
    [SerializeField] GameObject _dashboardPanel, _displayNamePanel;

    public void SwitchDisplayNamePanelOnClick()
    {
        switch (_dashboardPanel.activeInHierarchy)
        {
            case true:
                _dashboardPanel.SetActive(false);
                _displayNamePanel.SetActive(true);
                break;

            default:
                _dashboardPanel.SetActive(true);
                _displayNamePanel.SetActive(false);
                break;
        }
    }
}
