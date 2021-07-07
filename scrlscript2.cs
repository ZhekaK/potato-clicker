using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrlscript2 : MonoBehaviour
{
    public roulette cs;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cs.open == true)
        {
            gameObject.transform.Translate(new Vector2(cs.scrollSpeeds, 0) * Time.deltaTime);
        }
    }
}
