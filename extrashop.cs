using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Monetization;

public class extrashop : MonoBehaviour
{
    public int bonus = 0;
    public Button exbonus1;
    public Button exbonus2;
    public Button exbonus3;
    public Button exbonus4;
    public Button exbonus5;
    public GameObject exbonus11;
    public GameObject exbonus22;
    public GameObject exbonus33;
    public GameObject exbonus44;
    public GameObject exbonus55;
    public Button exshop1;
    public Button exshop2;
    public Button exshop3;
    public Button exshop4;
    public Button exshop5;
    public GameObject bonuspan1;
    public GameObject bonuspan3;
    public GameObject bonuspan5;
    public Controller cs;
    public GameObject elshop1;
    public Button lvl200;
    public Button pps200;
    public Button tap200;

    void Start()
    {
        bonus = PlayerPrefs.GetInt("Bonus");
    }

    void Update()
    {
        PlayerPrefs.SetInt("Bonus", bonus);
        if (bonus >= 1)
        {
            exbonus11.SetActive(false);
        }
        if (bonus >= 2)
        {
            exbonus22.SetActive(false);
        }
        if (bonus >= 3)
        {
            exbonus33.SetActive(false);
        }
        if (bonus >= 4)
        {
            exbonus44.SetActive(false);
        }
        if (bonus >= 5)
        {
            exbonus55.SetActive(false);
        }
        if (cs.extralvl >= 1)
        {
            exbonus1.interactable = true;
            exshop1.interactable = true;
        }
        if (cs.extralvl >= 2)
        {
            exbonus2.interactable = true;
            exshop2.interactable = true;
        }
        if (cs.extralvl >= 3)
        {
            exbonus3.interactable = true;
            exshop3.interactable = true;
        }
        if (cs.extralvl >= 4)
        {
            exbonus4.interactable = true;
            exshop4.interactable = true;
        }
        if (cs.extralvl >= 5)
        {
            exbonus5.interactable = true;
            exshop5.interactable = true;
        }
        if(cs.score >= 120000)
        {
            lvl200.interactable = true;
            pps200.interactable = true;
            tap200.interactable = true;
        }
        else
        {
            lvl200.interactable = false;
            pps200.interactable = false;
            tap200.interactable = false;
        }
    }

    public void ok1()
    {
        bonuspan1.SetActive(false);
    }
    public void ok3()
    {
        bonuspan3.SetActive(false);
    }
    public void ok5()
    {
        bonuspan5.SetActive(false);
    }

    public void exitpan1()
    {
        elshop1.SetActive(false);
    }
    public void LVL200()
    {
        if(cs.score >= 120000)
        {
            cs.lvl = cs.lvl + 200;
            cs.score = cs.score - 120000;
        }
        else
        {
            cs.failbuy.SetActive(true);
        }
    }

    public void PPS200()
    {
        if (cs.score >= 120000)
        {
            cs.countpot3 = cs.countpot3 + 200;
            cs.score = cs.score - 120000;
        }
        else
        {
            cs.failbuy.SetActive(true);
        }
    }

    public void TAP200()
    {
        if (cs.score >= 120000)
        {
            cs.x = cs.x + 200;
            cs.score = cs.score - 120000;
        }
        else
        {
            cs.failbuy.SetActive(true);
        }
    }

    public void bonusbttn1()
    {
        cs.countpot3 = cs.countpot3 + 50;
        cs.x = cs.x + 50;
        cs.lvl = cs.lvl + 20;
        bonus++;
        bonuspan1.SetActive(true);
    }
    public void bonusbttn2()
    {
        cs.countpot3 = cs.countpot3 + 50;
        cs.x = cs.x + 50;
        cs.lvl = cs.lvl + 20;
        bonus++;
        bonuspan1.SetActive(true);
    }
    public void bonusbttn3()
    {
        cs.countpot3 = cs.countpot3 + 100;
        cs.x = cs.x + 100;
        cs.lvl = cs.lvl + 50;
        bonus++;
        bonuspan3.SetActive(true);
    }
    public void bonusbttn4()
    {
        cs.countpot3 = cs.countpot3 + 100;
        cs.x = cs.x + 100;
        cs.lvl = cs.lvl + 50;
        bonus++;
        bonuspan3.SetActive(true);
    }
    public void bonusbttn5()
    {
        cs.countpot3 = cs.countpot3 + 150;
        cs.x = cs.x + 150;
        cs.lvl = cs.lvl + 100;
        bonus++;
        bonuspan5.SetActive(true);
    }

    public void shopbttn1()
    {
        elshop1.SetActive(true);
    }
    public void shopbttn2()
    {

    }
    public void shopbttn3()
    {

    }
    public void shopbttn4()
    {

    }
    public void shopbttn5()
    {

    }
}
