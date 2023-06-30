using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneSwiitcher : MonoBehaviour
{
    [SerializeField]
    GameObject[] Menus;

    int iterator = 0;

    public void ActivateMenu(int menuNumber) { 
        foreach (GameObject menu in Menus)
        {
            menu.SetActive(false); //Turns everything off
        }
        Menus[menuNumber].SetActive(true); //Turns on desired menu
    }
    // Start is called before the first frame update
    void Start()
    {
        ActivateMenu(0);
    }
    public void InterateMenu()
    {
        iterator++; //Adds one
        ActivateMenu(iterator);
    }
}
