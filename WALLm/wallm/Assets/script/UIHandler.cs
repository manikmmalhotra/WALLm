using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIHandler : MonoBehaviour
{
    private void Start()
    {
        Invoke("showad", 2.5f);
    }


    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitBTn()
    {
        Application.Quit();
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene(0);
    }

    private void showad()
    {
        adsmanager.VideoAd();
    }
}