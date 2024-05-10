using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    public Vector3 startPosition;
    public float height;
    public float timePassed;
    public float timePerCycle;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newpos = startPosition;
        timePassed += Time.deltaTime;

        newpos = new Vector3(transform.position.x, startPosition.y + (height - Mathf.Abs(((timePassed * height / timePerCycle) % (2 * height)) - height)), transform.position.z);

        transform.position = newpos;
    }
}
