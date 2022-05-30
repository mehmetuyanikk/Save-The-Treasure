using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchEmailPanel : MonoBehaviour
{
    [SerializeField] GameObject _dashboardPanel, _emailPanel;

    public void SwitchEmailPanelOnClick()
    {
        switch (_dashboardPanel.activeInHierarchy)
        {
            case true:
                _dashboardPanel.SetActive(false);
                _emailPanel.SetActive(true);
                break;

            default:
                _dashboardPanel.SetActive(true);
                _emailPanel.SetActive(false);
                break;
        }
    }
}
