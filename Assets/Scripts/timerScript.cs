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
                bronzeTime = "02:30";
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
            case 4:
                bronzeTime = "04:20";
                silverTime = "03:20";
                goldTime = "02:30";
                platinumTime = "02:00";
                break;
            case 5:
                bronzeTime = "05:00";
                silverTime = "04:00";
                goldTime = "03:20";
                platinumTime = "02:30";
                break;
            case 6:
                bronzeTime = "06:00";
                silverTime = "04:50";
                goldTime = "04:10";
                platinumTime = "03:30";
                break;
            case 7:
                bronzeTime = "06:20";
                silverTime = "05:00";
                goldTime = "04:20";
                platinumTime = "03:40";
                break;
            case 8:
                bronzeTime = "07:30";
                silverTime = "06:40";
                goldTime = "06:10";
                platinumTime = "05:40";
                break;
            case 9:
                bronzeTime = "07:50";
                silverTime = "06:50";
                goldTime = "06:20";
                platinumTime = "05:50";
                break;
            case 10:
                bronzeTime = "14:00";
                silverTime = "12:00";
                goldTime = "10:30";
                platinumTime = "09:30";
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
