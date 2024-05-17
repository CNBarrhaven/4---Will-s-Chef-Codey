using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class orderManager : MonoBehaviour
{
    public float timer;
    public int day;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (day == 1)
        {
            if (timer >= 10)
            {

            }
        }

    }
}
