using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons: MonoBehaviour
{
    public void Options()

    {

        SceneManager.LoadScene("Options");
    }
    public void Level1()

    {

        SceneManager.LoadScene("Level1");
    }
    public void quitGame()

    {

        Application.Quit();
    }
    public void mainmenu()

    {

        SceneManager.LoadScene("mainmenu");
    }
    public void Level2()
    {

        SceneManager.LoadScene("level2");
    }
    public void Level3()
    {

        SceneManager.LoadScene("level3");
    }
}
