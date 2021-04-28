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
    public void Level4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void Level5()
    {
            SceneManager.LoadScene("Level5");
    }
    public void Level6()
    {
        SceneManager.LoadScene("Level6");
    }
    public void Level7()
    {
        SceneManager.LoadScene("Level7");
    }
    public void Level8()
    {
        SceneManager.LoadScene("Level8");
    }
    public void Level9()
    {
        SceneManager.LoadScene("Level9");

    }
    public void Level10()
    {
        SceneManager.LoadScene("Level10");
    }

}
