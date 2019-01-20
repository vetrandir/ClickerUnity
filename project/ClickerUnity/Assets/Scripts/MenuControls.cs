using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void PlayPressedfabric()
    {
        SceneManager.LoadScene("fabric");
    }
    public void PlayPressedstock()
    {
        SceneManager.LoadScene("stock");
    }
    public void PlayPressedshop()
    {
        SceneManager.LoadScene("shop");
    }
    public void PlayPressedproduction()
    {
        SceneManager.LoadScene("production");
    }
    public void PlayPressedachievement()
    {
        SceneManager.LoadScene("achievement");
    }
    public void PlayPressedcabinet()
    {
        SceneManager.LoadScene("cabinet");
    }
    public void PlayPressedcase()
    {
        SceneManager.LoadScene("case1");
    }
    public void PlayPressedsettings()
    {
        SceneManager.LoadScene("settings");
    }
}
