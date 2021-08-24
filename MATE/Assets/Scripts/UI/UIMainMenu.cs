using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] GameObject teamBuilder;
    [SerializeField] GameObject optionsPanel;

    public void StartTeamBuilder()
    {
        teamBuilder.SetActive(true);
    }

    public void OpenOptionsPanel()
    { 
        optionsPanel.SetActive(true);
        gameObject.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }


}
