using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Monetization;

public class casinobox4 : MonoBehaviour
{
    public bool open = false;
    public GameObject[] prefabss;
    public GameObject sps;
    public float scrollSpeeds = -20f;
    public float velocitys = 3f;
    public Image finalDrops;
    public GameObject dropPans;
    public GameObject v5050s;
    public GameObject notpots;
    public Controller cs;
    public Button rolls;
    public GameObject exits;

    // Start is called before the first frame update
    void Start()
    {
        if (Monetization.isSupported) Monetization.Initialize("3597679", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (open == true)
        {
            scrollSpeeds = Mathf.MoveTowards(scrollSpeeds, 0f, velocitys * Time.deltaTime);
            RaycastHit2D hit = Physics2D.Raycast(Vector2.down, Vector2.up);
            exits.SetActive(false);
            if (hit.collider != null)
            {
                if (scrollSpeeds == 0)
                {
                    dropPans.SetActive(true);
                    finalDrops.sprite = hit.collider.gameObject.GetComponent<Image>().sprite;
                }
            }
            else if (scrollSpeeds == 0)
            {
                scrollSpeeds = Mathf.MoveTowards(scrollSpeeds, -5f, velocitys * Time.deltaTime);
            }
        }
    }
    public void casebttn(int caseInts)
    {
        if (cs.score >= 20000)
        {
            open = true;
            gameObject.SetActive(true);
            casinocntrl();
            velocitys = Random.Range(3f, 4f);
            cs.score = cs.score - 20000;
            rolling();
        }
        else
        {
            notpots.SetActive(true);
        }
    }
    public void ok()
    {
        if (finalDrops.sprite.name.Equals("1000"))
        {
            cs.score = cs.score + 1000;
        }
        if (finalDrops.sprite.name.Equals("25k"))
        {
            cs.score = cs.score + 25000;
        }
        if (finalDrops.sprite.name.Equals("5lvl"))
        {
            cs.lvl = cs.lvl + 5;
        }
        if (finalDrops.sprite.name.Equals("40pps"))
        {
            cs.countpot3 = cs.countpot3 + 40;
        }
        if (finalDrops.sprite.name.Equals("x10"))
        {
            cs.x = cs.x + 10;
        }
        if (finalDrops.sprite.name.Equals("50k"))
        {
            cs.score = cs.score + 50000;
        }
        Invoke("zd", 0.1f);
    }

    public void ok2()
    {
        notpots.SetActive(false);
    }

    public void zd()
    {
        v5050s.SetActive(false);
        SceneManager.LoadScene(Application.loadedLevel);
    }
    void casinocntrl()
    {
        for (int a = 0; a < 40; a++)
        {
            int rands = Random.Range(0, 1000);
            int randWeapons = 0;
            if (rands <= 200)
            {
                randWeapons = 0;
            }
            else if (rands > 200 && rands <= 400)
            {
                randWeapons = 1;
            }
            else if (rands > 400 && rands <= 600)
            {
                randWeapons = 2;
            }
            else if (rands > 600 && rands <= 750)
            {
                randWeapons = 3;
            }
            else if (rands > 750 && rands <= 900)
            {
                randWeapons = 4;
            }
            else if (rands > 900 && rands <= 1000)
            {
                randWeapons = 5;
            }
            GameObject objs = Instantiate(prefabss[randWeapons], new Vector2(0, 0), Quaternion.identity) as GameObject;
            objs.transform.SetParent(sps.transform);
            objs.transform.localScale = new Vector2(1f, 1f);
        }
    }
    void rolling()
    {
        rolls.interactable = false;
    }
}
