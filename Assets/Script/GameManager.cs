using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Pause_Pannel;
  public void resume()
    {
        Time.timeScale = 1;
        Pause_Pannel.SetActive(false);
    }

    public void Pause()
    {
        Time.timeScale = 0;
        Pause_Pannel.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game_Menu");

    }
    public void Level_Selector()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Game_Selection");

    }
    public void Level1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level1");
       
    }
   
     public void Level2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level2");
        if (3 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 3);
        }

    }
    public void unlock2()
    {


        if (3 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 3);
        }

    }
    public void Level3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level3");
        if (4 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 4);
        }

    }
    public void unlock3()
    {


        if (4 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 4);
        }

    }
    public void Level4()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level4");
        if (5 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 5);
        }

    }
    public void unlock4()
    {


        if (5 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 5);
        }

    }
    public void Level5()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level5");
        if (6 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 6);
        }

    }
    public void unlock5()
    {


        if (6 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 6);
        }

    }
    public void Level6()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level6");
        if (7 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 7);
        }

    }
    public void unlock6()
    {


        if (7 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 7);
        }

    }
    public void Level7()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level7");
        if (8 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 8);
        }

    }
    public void unlock7()
    {


        if (8 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 8);
        }

    }
    public void Level8()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level8");
        if (9 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 9);
        }

    }
    public void unlock8()
    {


        if (9 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 9);
        }

    }
    public void unlock9()
    {


        if (10 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 10);
        }

    }
    public void Level9()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level9");
        if (10 > PlayerPrefs.GetInt("levelAt"))
        {
            PlayerPrefs.SetInt("levelAt", 10);
        }
    }

    public void FlyLevel1()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level1_Fly");

    }
    public void FlyLevel2()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level2_Fly");

    }
    public void FlyLevel3()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level3_Fly");

    }
    public void FlyLevel4()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level4_Fly");

    }
    public void FlyLevel5()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level5_Fly");

    }
    public void FlyLevel6()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level6_Fly");

    }
    public void FlyLevel7()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level7_Fly");

    }
    public void FlyLevel8()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level8_Fly");

    }
    public void FlyLevel9()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level9_Fly");

    }

}
