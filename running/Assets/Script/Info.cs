using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Info : MonoBehaviour 
{
    public GameObject InfoPanel;



    public void Info_Btn()
    {
        InfoPanel.SetActive(true);


    }

    public void Back_Btn()
    {
        InfoPanel.SetActive(false);

    }
}
