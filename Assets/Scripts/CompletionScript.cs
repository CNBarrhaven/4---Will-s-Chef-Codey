using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class Medals
{
    public static int platinums;
    public static int golds;
    public static int silvers;
    public static int bronzes;
    public static int defaultclears;
}

public class CompletionScript : MonoBehaviour
{
    public levelButtonClicked[] medalCheckScripts;


    // Start is called before the first frame update
    void Start()
    {
        Medals.platinums = 0;
        Medals.golds = 0;
        Medals.silvers = 0;
        Medals.bronzes = 0;
        Medals.defaultclears = 0;

        for (int i = 0; i < medalCheckScripts.Length; i++)
        {
            medalCheckScripts[i].checkMedals();
        }
        checkPercentage();
    }

    // Update is called once per frame
    void Update()
    {   
        gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("percentage").ToString() + "% Completed";
    }

    public void checkPercentage()
    {
        /*print(Medals.platinums);
        print(Medals.golds);
        print(Medals.silvers);
        print(Medals.bronzes);
        print(Medals.defaultclears);*/

        PlayerPrefs.SetInt("percentage", 0);
        for (int i = 0; i < Medals.platinums; i++)
        {
            PlayerPrefs.SetInt("percentage", PlayerPrefs.GetInt("percentage") + 20);
        }
        for (int i = 0; i < Medals.golds; i++)
        {
            PlayerPrefs.SetInt("percentage", PlayerPrefs.GetInt("percentage") + 10);
        }
        for (int i = 0; i < Medals.silvers; i++)
        {
            PlayerPrefs.SetInt("percentage", PlayerPrefs.GetInt("percentage") + 5);
        }
        for (int i = 0; i < Medals.bronzes; i++)
        {
            PlayerPrefs.SetInt("percentage", PlayerPrefs.GetInt("percentage") + 3);
        }
        for (int i = 0; i < Medals.defaultclears; i++)
        {
            PlayerPrefs.SetInt("percentage", PlayerPrefs.GetInt("percentage") + 1);
        }
    }
}
