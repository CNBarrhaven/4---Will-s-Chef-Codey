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

        if (PlayerPrefs.GetFloat(levelNumber) <= platinumTime)
        {
            ColorBlock cb = gameObject.GetComponent<Button>().colors;
            cb.normalColor = new Color(0.8f, 0.8f, 1f);
            gameObject.GetComponent<Button>().colors = cb;
        }
        else if (PlayerPrefs.GetFloat(levelNumber) <= goldTime)
        {
            ColorBlock cb = gameObject.GetComponent<Button>().colors;
            cb.normalColor = new Color(1f, 0.8f,0.3f);
            gameObject.GetComponent<Button>().colors = cb;
        }
        else if (PlayerPrefs.GetFloat(levelNumber) <= silverTime)
        {
            ColorBlock cb = gameObject.GetComponent<Button>().colors;
            cb.normalColor = new Color(0.8f, 0.8f, 0.8f);
            gameObject.GetComponent<Button>().colors = cb;
        }
        else if (PlayerPrefs.GetFloat(levelNumber) <= bronzeTime)
        {
            ColorBlock cb = gameObject.GetComponent<Button>().colors;
            cb.normalColor = new Color(0.8f, 0.5f, 0.2f);
            gameObject.GetComponent<Button>().colors = cb;
        }
        else
        {
            ColorBlock cb = gameObject.GetComponent<Button>().colors;
            cb.normalColor = Color.white;
            gameObject.GetComponent<Button>().colors = cb;
        }

        if (PlayerPrefs.GetFloat(levelNumber) == 0)
        {
            ColorBlock cb = gameObject.GetComponent<Button>().colors;
            cb.normalColor = Color.white;
            gameObject.GetComponent<Button>().colors = cb;
        }


        

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
}
