using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class timerScript : MonoBehaviour
{
    public Text timerText;
    public Text bronzeText;
    public Text silverText;
    public Text goldText;
    public Text platinumText;

    public float globalTime = 0;
    public float time = 0;
    public int seconds = 0;
    public int minutes = 0;

    public string bronzeTime;
    public string silverTime;
    public string goldTime; 
    public string platinumTime;
    // Start is called before the first frame update
    void Start()
    {
        switch (LevelSelected.levelSelected)
        {
            case 1:
                bronzeTime = "01:20";
                silverTime = "01:00";
                goldTime = "00:40";
                platinumTime = "00:30";
                break;
            case 2:
                bronzeTime = "01:30";
                silverTime = "02:00";
                goldTime = "01:30";
                platinumTime = "01:10";
                break;
            case 3:
                bronzeTime = "03:20";
                silverTime = "02:40";
                goldTime = "02:10";
                platinumTime = "01:40";
                break;
        }
        bronzeText.text = "Bronze: " + bronzeTime;
        silverText.text = "Silver: " + silverTime;
        goldText.text = "Gold: " + goldTime;
        platinumText.text = "Platinum: " + platinumTime;
    }

    // Update is called once per frame
    void Update()
    {
        globalTime += Time.deltaTime;
        time += Time.deltaTime;
        seconds = Mathf.RoundToInt(time);
        if (time > 60)
        {
            minutes += 1;
            time -= 60;
        }
        if (minutes > 60)
        {
            SceneManager.LoadScene(1);
        }
        timerText.text = minutes.ToString() + ":" + seconds.ToString();
        PlayerPrefs.SetString("currentTime", timerText.text.ToString());
    }
}
