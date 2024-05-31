using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelSelectClicked : MonoBehaviour
{
    public Animator titleAnimations;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playLevelSelectAnimations()
    {
        titleAnimations.Play("moveButtons", 0, 0);
    }

    public void playTitleScreenAnimations()
    {
        titleAnimations.Play("moveButtonsDefault", 0, 0);
    }
}
