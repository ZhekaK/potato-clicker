using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{
    public Controller cs;
    public GameObject b6;
    public GameObject b7;
    public GameObject b8;
    public GameObject b9;
    public GameObject b10;
    public GameObject b61;
    public GameObject b71;
    public GameObject b81;
    public GameObject b91;
    public GameObject b101;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cs.score >= 2000)
        {
            b6.SetActive(true);
            b61.SetActive(false);
        }
        else
        {
            b6.SetActive(false);
            b61.SetActive(true);
        }
        if(cs.score >= 15000)
        {
            b7.SetActive(true);
            b71.SetActive(false);
        }
        else
        {
            b7.SetActive(false);
            b71.SetActive(true);
        }
        if (cs.score >= 45000)
        {
            b8.SetActive(true);
            b81.SetActive(false);
        }
        else
        {
            b8.SetActive(false);
            b81.SetActive(true);
        }
        if (cs.score >= 45000)
        {
            b9.SetActive(true);
            b91.SetActive(false);
        }
        else
        {
            b9.SetActive(false);
            b91.SetActive(true);
        }
        if (cs.score >= 60000)
        {
            b10.SetActive(true);
            b101.SetActive(false);
        }
        else
        {
            b10.SetActive(false);
            b101.SetActive(true);
        }
    }
}
