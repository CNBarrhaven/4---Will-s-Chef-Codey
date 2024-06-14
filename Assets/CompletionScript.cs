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
    // Start is called before the first frame update
    void Start()
    {
/*        if (PlayerPrefs.GetInt("percentage") == 0)
        {
            PlayerPrefs.SetInt("percentage", 1);
        }*/

        checkPercentage();
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Text>().text = PlayerPrefs.GetInt("percentage").ToString() + "% Completed";
    }

    public void checkPercentage()
    {
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
