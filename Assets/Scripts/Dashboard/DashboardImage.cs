using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashboardImage : MonoBehaviour
{
    [SerializeField] GameObject _changeImagePanel, _dashboardPanel;

    public void ChangeImageOnClick()
    {
        _dashboardPanel.SetActive(false);
        _changeImagePanel.SetActive(true);
    }

}
