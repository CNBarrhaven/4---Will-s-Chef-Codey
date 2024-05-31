using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LevelSelected
{
    public static int levelSelected;
}

public class levelButtonClicked : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
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
