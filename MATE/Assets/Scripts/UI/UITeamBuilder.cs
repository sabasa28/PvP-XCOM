using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class UITeamBuilder : MonoBehaviour
{
    [SerializeField] GameObject classesDisplay;
    [SerializeField] GameObject teamLayout1;
    [SerializeField] GameObject teamLayout2;
    [SerializeField] GameObject playerName1;
    [SerializeField] GameObject playerName2;
    [SerializeField] TMP_Text timer;
    [SerializeField] float timeToChoose;
    float timeLeftToChoose;
    int playerChoosing = 1;
    void Start()
    {
        timeLeftToChoose = timeToChoose;
        playerName1.SetActive(true);
    }
    
    // Update is called once per frame
    void Update()
    {
        
        timer.text = ((int)timeLeftToChoose).ToString();
        timeLeftToChoose -= Time.deltaTime;
    }

    void ChangePlayerChoosing()
    {
        if (playerChoosing == 1)
        {
            playerChoosing = 2;
            playerName1.SetActive(false);
            playerName2.SetActive(true);
        }
        else
        {
            playerChoosing = 1;
            playerName1.SetActive(true);
            playerName2.SetActive(false);
        }

        timeLeftToChoose = timeToChoose;
    }

    public void ChooseClass(UnityEngine.UI.Button classChosen)
    {
        
        if (playerChoosing == 1) classChosen.transform.parent=teamLayout1.transform;
        else classChosen.transform.parent = teamLayout2.transform;
        ChangePlayerChoosing();
    }
    

}
