using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class scrollscript : MonoBehaviour
{
    public casino cs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(cs.openCase == true) 
        {
            gameObject.transform.Translate(new Vector2(cs.scrollSpeed, 0) * Time.deltaTime);
        }
    }
}
