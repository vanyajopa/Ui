using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionController : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Options;
    public GameObject Map;
    public GameObject NoAds;
    public GameObject ChangePlayer;
    public GameObject OptionsButton;


    public void ShowOptions()
    {
        MainMenu.SetActive(true);
        NoAds.SetActive(false);
        Options.SetActive(true);
        Map.SetActive(false);
        OptionsButton.SetActive(false);
        ChangePlayer.SetActive(false);
    }

    public void ShowMainMenu()
    {
        MainMenu.SetActive(true);
        Options.SetActive(false);
        NoAds.SetActive(false);
        Map.SetActive(false);
        ChangePlayer.SetActive(false);
        OptionsButton.SetActive(true);
    }

    public void ShowMap()
    {
        MainMenu.SetActive(false);
        Options.SetActive(false);
        NoAds.SetActive(false);
        Map.SetActive(true);
        ChangePlayer.SetActive(false);
    }

    public void ShowChangePlayer()
    {
        MainMenu.SetActive(false);
        Options.SetActive(false);
        NoAds.SetActive(false);
        Map.SetActive(false);
        ChangePlayer.SetActive(true);
    }

    public void ShowNoAds()
    {
        MainMenu.SetActive(false);
        Options.SetActive(false);
        NoAds.SetActive(true);
        Map.SetActive(false);
        ChangePlayer.SetActive(false);
    }
}
