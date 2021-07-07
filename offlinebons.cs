using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class offlinebons : MonoBehaviour
{
    public Controller cs;
    TimeSpan ts;
    public float bon;
    public float totalbon;
    // Start is called before the first frame update
    void Start()
    {
        CheckOffline();
    }

    void CheckOffline()
    {
        if (PlayerPrefs.HasKey("LastSession"))
        {
            ts = DateTime.Now - DateTime.Parse(PlayerPrefs.GetString("LastSession"));
            print(string.Format("Игровой бонус начислен за отсутствие: {0} часов {1} минут {2} секунд", ts.Hours, ts.Minutes, ts.Seconds));
            cs.startbonus.SetActive(true);
        }
        if (ts.Hours >= 4)
        {
            bon = 14400;
        }
        else
        {
            bon = (float)ts.TotalSeconds;
        }
        totalbon = bon * (cs.countpot3 + (cs.countpot2 / 2) + (cs.countpot / 5));
        print(string.Format("он составил:" + totalbon));
        cs.score = cs.score + totalbon;
        cs.count = cs.count + totalbon;
        cs.bonusscore.text = totalbon.ToString();
    }

    void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
        }
    }
}
