using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public static class LevelSelected
{
    public static int levelSelected;
}

public class levelButtonClicked : MonoBehaviour
{
    public CompletionScript completionScript;

    public string levelNumber;

    public float bronzeTime;
    public float silverTime;
    public float goldTime;
    public float platinumTime;

    public Text highScore;
    public float highScoreNumber;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.GetChild(4).gameObject.GetComponent<Text>().text = "High Score: " + PlayerPrefs.GetString(levelNumber + "highscore");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void levelButtonPressed(int levelNumber)
    {
        LevelSelected.levelSelected = levelNumber;
        SceneManager.LoadScene(0);
    }

    public void checkMedals()
    {
        print("Level High Score: " + PlayerPrefs.GetFloat(levelNumber));
        print("Platinum Time: " + platinumTime);

        if (PlayerPrefs.GetFloat(levelNumber) == 0)
        {
            ColorBlock cb = gameObject.GetComponent<Button>().colors;
            cb.normalColor = Color.white;
            gameObject.GetComponent<Button>().colors = cb;
        }
        else if (PlayerPrefs.GetFloat(levelNumber) <= platinumTime)
        {
            ColorBlock cb = gameObject.GetComponent<Button>().colors;
            cb.normalColor = new Color(0.8f, 0.8f, 1f);
            gameObject.GetComponent<Button>().colors = cb;
            Medals.platinums++;
        }
        else if (PlayerPrefs.GetFloat(levelNumber) <= goldTime)
        {
            ColorBlock cb = gameObject.GetComponent<Button>().colors;
            cb.normalColor = new Color(1f, 0.8f, 0.3f);
            gameObject.GetComponent<Button>().colors = cb;
            Medals.golds++;
        }
        else if (PlayerPrefs.GetFloat(levelNumber) <= silverTime)
        {
            ColorBlock cb = gameObject.GetComponent<Button>().colors;
            cb.normalColor = new Color(0.8f, 0.8f, 0.8f);
            gameObject.GetComponent<Button>().colors = cb;
            Medals.silvers++;
        }
        else if (PlayerPrefs.GetFloat(levelNumber) <= bronzeTime)
        {
            ColorBlock cb = gameObject.GetComponent<Button>().colors;
            cb.normalColor = new Color(0.8f, 0.5f, 0.2f);
            gameObject.GetComponent<Button>().colors = cb;
            Medals.bronzes++;
        }
        else
        {
            ColorBlock cb = gameObject.GetComponent<Button>().colors;
            cb.normalColor = Color.white;
            gameObject.GetComponent<Button>().colors = cb;
            Medals.defaultclears++;
        }

        
        print("Total Platinums after calculation: " + Medals.platinums);
    }
}
