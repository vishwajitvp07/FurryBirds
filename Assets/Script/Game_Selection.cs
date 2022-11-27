using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Game_Selection : MonoBehaviour
{
    public Button[] Levels;

    // Start is called before the first frame update
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 2);

        for (int i = 0; i < Levels.Length; i++)
        {
            if (i + 2 > levelAt)
                Levels[i].interactable = false;
        }
    }
}
