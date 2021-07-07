using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class shop2 : MonoBehaviour
{
    public Controller cs;
    public GameObject b11;
    public GameObject b12;
    public GameObject b13;
    public GameObject b14;
    public GameObject b15;
    public GameObject b111;
    public GameObject b121;
    public GameObject b131;
    public GameObject b141;
    public GameObject b151;
    public Button c14;
    public Button c141;
    public Button c15;
    public Button c151;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (cs.score >= 80000)
        {
            b11.SetActive(true);
            b111.SetActive(false);
        }
        else
        {
            b11.SetActive(false);
            b111.SetActive(true);
        }
        if (cs.score >= 80000)
        {
            b12.SetActive(true);
            b121.SetActive(false);
        }
        else
        {
            b12.SetActive(false);
            b121.SetActive(true);
        }
        if (cs.score >= 100000)
        {
            b13.SetActive(true);
            b131.SetActive(false);
        }
        else
        {
            b13.SetActive(false);
            b131.SetActive(true);
        }
        if (cs.score >= 100000 && cs.lvl >= 100)
        {
            b14.SetActive(true);
            b141.SetActive(false);
            c14.interactable = true;
            c141.interactable = true;
        }
        else
        {
            b14.SetActive(false);
            b141.SetActive(true);
            c14.interactable = false;
            c141.interactable = false;
        }
        if (cs.score >= 160000)
        {
            b15.SetActive(true);
            b151.SetActive(false);
            c15.interactable = true;
            c151.interactable = true;
        }
        else
        {
            b15.SetActive(false);
            b151.SetActive(true);
            c15.interactable = false;
            c151.interactable = false;
        }
    }
}
