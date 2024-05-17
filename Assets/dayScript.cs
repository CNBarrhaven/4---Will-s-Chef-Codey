using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class akjfs
{
    public bool workingh;
    public string name;

    public akjfs( bool workingh, string name)
    {
        this.workingh = workingh;
        this.name = name;
    }   
}

public class dayScript : MonoBehaviour
{
    public int orderAmount;

    public List<akjfs> thingList;

    // Start is called before the first frame update
    void Start()
    {
        thingList.Add(new akjfs(false, "dagan"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
