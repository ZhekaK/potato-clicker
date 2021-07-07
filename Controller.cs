using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Monetization;
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Controller : MonoBehaviour
{
    public float score;
    public Text scoreT;
    public int lvl = 1;
    public Text lvlT;
    public GameObject failbuy;
    public float x = 0f;
    public float mno = 0.2f;
    public float countpot;
    public float countpot2;
    public float countpot3;
    public float count = 0f;
    public GameObject v50505;
    public GameObject roulettes;
    public GameObject menu;
    public Text pps;
    public Text tap;
    public float tap1;
    public float pps1;
    public float pps2;
    public float pps3;
    public GameObject but1;
    public GameObject but2;
    public GameObject but3;
    public GameObject but4;
    public GameObject but5;
    public GameObject but11;
    public GameObject but21;
    public GameObject but31;
    public GameObject but41;
    public GameObject but51;
    public int extralvl = 0;
    public Text extralvlT;
    public GameObject ppstappan;
    public GameObject closebtn;
    public GameObject box3;
    public GameObject box4;
    public GameObject box5;
    public GameObject startbonus;
    public Text bonusscore;
    public int exitint;
    public float bon;
    public float totalbon;
    TimeSpan ts;
    public GameObject yN;
    private const string achiv1 = "CgkI08aGiuocEAIQAw";
    private const string achiv2 = "CgkI08aGiuocEAIQBA";
    private const string achiv3 = "CgkI08aGiuocEAIQBQ";
    private const string achiv4 = "CgkI08aGiuocEAIQBg";
    private const string achiv6 = "CgkI08aGiuocEAIQCA";
    private const string achiv8 = "CgkI08aGiuocEAIQCg";
    private const string leaderboard1 = "CgkI08aGiuocEAIQAQ";
    private const string leaderboard2 = "CgkI08aGiuocEAIQAg";
    int kolvo;
    int pokup;

    void Start()
    {
        scoreT.text = score.ToString();
        lvlT.text = lvl.ToString();
        score = PlayerPrefs.GetFloat("Score");
        lvl = PlayerPrefs.GetInt("Lvl");
        x = PlayerPrefs.GetFloat("X");
        countpot = PlayerPrefs.GetFloat("Countpot");
        countpot2 = PlayerPrefs.GetFloat("Countpot2");
        countpot3 = PlayerPrefs.GetFloat("Countpot3");
        extralvl = PlayerPrefs.GetInt("Extralvl");
        exitint = PlayerPrefs.GetInt("Exitint");
        count = score;
        Invoke("fix", 5);
        Invoke("fix2", 2);
        Invoke("fix3", 1);
        if (Monetization.isSupported) Monetization.Initialize("3597679", true);
        //CheckOffline();
    }

    void Update()
    {
        PlayerPrefs.SetFloat("Score", score);
        PlayerPrefs.SetInt("Lvl", lvl);
        PlayerPrefs.SetFloat("X", x);
        PlayerPrefs.SetFloat("Countpot", countpot);
        PlayerPrefs.SetFloat("Countpot2", countpot2);
        PlayerPrefs.SetFloat("Countpot3", countpot3);
        PlayerPrefs.SetInt("Extralvl", extralvl);
        PlayerPrefs.SetInt("Exitint", exitint);
        if (score >= 1000)
        {
            but1.SetActive(true);
            but11.SetActive(false);
            but5.SetActive(true);
            but51.SetActive(false);
        }
        if (score >= 500)
        {
            but2.SetActive(true);
            but21.SetActive(false);
            but4.SetActive(true);
            but41.SetActive(false);
        }
        if (score >= 300)
        {
            but3.SetActive(true);
            but31.SetActive(false);
        }
        if (score < 1000)
        {
            but11.SetActive(true);
            but51.SetActive(true);
        }
        if (score < 500)
        {
            but2.SetActive(false);
            but21.SetActive(true);
            but4.SetActive(false);
            but41.SetActive(true);
        }
        if (score < 300)
        {
            but3.SetActive(false);
            but31.SetActive(true);
        }
        extralvlT.text = extralvl.ToString();
        scoreT.text = score.ToString();
        lvlT.text = lvl.ToString();
        count = score;
        tap1 = x + 1;
        tap.text = tap1.ToString();
        pps1 = countpot3 + pps2 + pps3;
        pps2 = countpot2 / 2;
        pps3 = countpot / 5;
        pps.text = pps1.ToString();
        if(score >= 1000)
        {
            scoreT.text = score / 1000 + "K";
        }
        if (score >= 1000000)
        {
            scoreT.text = score / 1000000 + "KK";
        }
        if (score >= 1000000000)
        {
            scoreT.text = score / 1000000000 + "KKK";
        }
        if (score >= 1000000000000)
        {
            scoreT.text = score / 1000000000000 + "KKKK";
        }
    }

    public void ok2()
    {
        startbonus.SetActive(false);
    }

    void CheckOffline()
    {
        if(exitint == 0)
        {
            if (PlayerPrefs.HasKey("LastSession"))
            {
                ts = DateTime.Now - DateTime.Parse(PlayerPrefs.GetString("LastSession"));
                print(string.Format("Игровой бонус начислен за отсутствие: {0} часов {1} минут {2} секунд", ts.Hours, ts.Minutes, ts.Seconds));
                startbonus.SetActive(true);
            }
            if (ts.Hours >= 4)
            {
                bon = 14400;
            }
            else
            {
                bon = (float)ts.TotalSeconds;
            }
            totalbon = bon * (countpot3 + (countpot2 / 2) + (countpot / 5));
            print(string.Format("он составил:" + totalbon));
            score = score + totalbon;
            count = count + totalbon;
            bonusscore.text = totalbon.ToString();
            exitint = 2;
        }
    }

    void OnApplicationQuit()
    {
        exitint = 0;
        PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
    }

    void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            exitint = 0;
            PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
        }
    }

    public void v5050btn()
    {
        v50505.SetActive(true);
    }

    public void box3btn()
    {
        box3.SetActive(true);
    }
    public void box4btn()
    {
        box4.SetActive(true);
    }
    public void box5btn()
    {
        box5.SetActive(true);
    }

    public void LastButtn1()
    {
        SceneManager.LoadScene(4);
        exitint = 2;
    }

    public void NextButtn1()
    {
        SceneManager.LoadScene(3);
        exitint = 2;
    }

    public void PrevButtn1()
    {
        SceneManager.LoadScene(1);
        exitint = 2;
    }
    public void EXTRASHOP()
    {
        SceneManager.LoadScene(5);
        exitint = 2;
    }

    void sec30()
    {
        x = (x - 1) / 2;
    }

    public void ppstap()
    {
        ppstappan.SetActive(true);
        closebtn.SetActive(false);
    }
    public void ppstap2()
    {
        ppstappan.SetActive(false);
        closebtn.SetActive(true);
    }

    public void OnClick()
    {
        count = count + 1;
        score = count + x;
    }

    void komar()
    {
        Application.Quit();
    }
    public void exit()
    {
        Invoke("komar", 0.05f);
        PlayerPrefs.SetString("LastSession", DateTime.Now.ToString());
        exitint = 0;
    }
    public void shop()
    {
        SceneManager.LoadScene(1);
        exitint = 2;
    }
    public void home()
    {
        SceneManager.LoadScene(0);
        exitint = 2;
    }
    public void play()
    {
        menu.SetActive(false);
    }
    public void menu1()
    {
        menu.SetActive(true);
    }
    public void casino()
    {
        SceneManager.LoadScene(2);
        exitint = 2;
    }
    public void lvlup()
    {
        if (score >= 1000)
        {
            lvl++;
            score = score - 1000;
        }
        else
        {
            failbuy.SetActive(true);
        }
    }
    public void lvlup2()
    {
        if (score >= 45000)
        {
            lvl = lvl + 50;
            score = score - 45000;
        }
        else
        {
            failbuy.SetActive(true);
        }
    }
    public void lvlup3()
    {
        if (score >= 80000)
        {
            lvl = lvl + 100;
            score = score - 80000;
        }
        else
        {
            failbuy.SetActive(true);
        }
    }
    public void ok()
    {
        failbuy.SetActive(false);
    }
    public void roulettess()
    {
        roulettes.SetActive(true);
    }
    public void mnozh()
    {
        if (score >= 500)
        {
            x = x + mno;
            score = score - 500;
        }
        else
        {
            failbuy.SetActive(true);
        }
    }
    public void mnozh1()
    {
        if (score >= 2000)
        {
            x = x + 1;
            score = score - 2000;
        }
        else
        {
            failbuy.SetActive(true);
        }
    }
    public void mnozh2()
    {
        if (score >= 15000)
        {
            x = x + 10;
            score = score - 15000;
        }
        else
        {
            failbuy.SetActive(true);
        }
    }
    public void mnozh3()
    {
        if (score >= 60000)
        {
            x = x + 50;
            score = score - 60000;
        }
        else
        {
            failbuy.SetActive(true);
        }
    }
    public void mnozh4()
    {
        if (score >= 100000)
        {
            x = x + 100;
            score = score - 100000;
        }
        else
        {
            failbuy.SetActive(true);
        }
    }
    public void freepotato()
    {
        if (score >= 300)
        {
            countpot++;
            score = score - 300;
        }
        else
        {
            failbuy.SetActive(true);
        }
    }

    public void freepotato2()
    {
        if (score >= 500)
        {
            countpot2++;
            score = score - 500;
        }
        else
        {
            failbuy.SetActive(true);
        }
    }

    public void freepotato3()
    {
        if (score >= 1000)
        {
            countpot3++;
            score = score - 1000;
        }
        else
        {
            failbuy.SetActive(true);
        }
    }

    public void freepotato4()
    {
        if (score >= 45000)
        {
            countpot3 = countpot3 + 50;
            score = score - 45000;
        }
        else
        {
            failbuy.SetActive(true);
        }
    }

    public void freepotato5()
    {
        if (score >= 80000)
        {
            countpot3 = countpot3 + 100;
            score = score - 80000;
        }
        else
        {
            failbuy.SetActive(true);
        }
    }

    public void extralvlbtn()
    {
        if(score >= 160000)
        {
            extralvl++;
            score = score - 160000;
        }
        else
        {
            failbuy.SetActive(true);
        }
    }

    public void extralvlbtn2()
    {
        if(score >= 100000 && lvl >= 100)
        {
            extralvl++;
            score = score - 100000;
            lvl = lvl - 100;
        }
        else
        {
            failbuy.SetActive(true);
        }
    }

    void fix()
    {
        StartCoroutine(potato());
    }

    void fix2()
    {
        StartCoroutine(potato2());
    }

    void fix3()
    {
        StartCoroutine(potato3());
    }
    
    public void Potato200()
    {
        if (Monetization.IsReady("rewardedVideo"))
        {
            ShowAdCallbacks options = new ShowAdCallbacks();
            options.finishCallback = HandleShowResult;
            ShowAdPlacementContent ad = Monetization.GetPlacementContent("rewardedVideo") as ShowAdPlacementContent;
            ad.Show(options);
        }
    }

    public void potato5k()
    {
        if (lvl >= 20)
        {
            Potato5000();
        }
        else
        {
            yN.SetActive(true);
        }
    }

    public void OK5K()
    {
        yN.SetActive(false);
    }

    public void potato50K()
    {
        if(extralvl >= 1)
        {
            Potato50000();
        }
        else
        {
            yN.SetActive(true);
        }
    }

    void Potato5000()
    {
        if (Monetization.IsReady("rewardedVideo"))
        {
            ShowAdCallbacks options = new ShowAdCallbacks();
            options.finishCallback = HandleShowResult3;
            ShowAdPlacementContent ad = Monetization.GetPlacementContent("rewardedVideo") as ShowAdPlacementContent;
            ad.Show(options);
        }
    }

    void Potato50000()
    {
        if (Monetization.IsReady("rewardedVideo"))
        {
            ShowAdCallbacks options = new ShowAdCallbacks();
            options.finishCallback = HandleShowResult4;
            ShowAdPlacementContent ad = Monetization.GetPlacementContent("rewardedVideo") as ShowAdPlacementContent;
            ad.Show(options);
        }
    }

    void HandleShowResult4(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            score = score + 50000;
        }
        else if (result == ShowResult.Skipped)
        {
            Debug.Log("skipped");
        }
        else if (result == ShowResult.Failed)
        {
            Debug.Log("failed");
        }
    }

    void HandleShowResult(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            score = score + 500;
        }
        else if (result == ShowResult.Skipped)
        {
            Debug.Log("skipped");
        }
        else if (result == ShowResult.Failed)
        {
            Debug.Log("failed");
        }
    }

    void HandleShowResult3(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            score = score + 5000;
        }
        else if (result == ShowResult.Skipped)
        {
            Debug.Log("skipped");
        }
        else if (result == ShowResult.Failed)
        {
            Debug.Log("failed");
        }
    }

    public void DoubleClick()
    {
        if (Monetization.IsReady("rewardedVideo"))
        {
            ShowAdCallbacks options = new ShowAdCallbacks();
            options.finishCallback = HandleShowResult2;
            ShowAdPlacementContent ad = Monetization.GetPlacementContent("rewardedVideo") as ShowAdPlacementContent;
            ad.Show(options);
        }
    }

    void HandleShowResult2(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            x = (x * 2) + 1;
            Invoke("sec30", 30);
        }
        else if (result == ShowResult.Skipped)
        {
            Debug.Log("skipped");
        }
        else if (result == ShowResult.Failed)
        {
            Debug.Log("failed");
        }
    }

    IEnumerator potato()
    {
        while (true)
        {
            score += countpot;
            yield return new WaitForSeconds(5);
        }
    }
    IEnumerator potato2()
    {
        while (true)
        {
            score += countpot2;
            yield return new WaitForSeconds(2);
        }
    }
    IEnumerator potato3()
    {
        while (true)
        {
            score += countpot3;
            yield return new WaitForSeconds(1);
        }
    }
}
