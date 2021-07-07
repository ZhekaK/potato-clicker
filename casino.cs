using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Monetization;

public class casino : MonoBehaviour
{
    public bool openCase = false;
    public GameObject[] prefabs;
    public GameObject sp;
    public float scrollSpeed = -20f;
    public float velocity = 6f;
    public Image finalDrop;
    public GameObject dropPan;
    public GameObject v5050;
    public GameObject notpot;
    public Controller cs;
    public Button roll;
    public Button rollad;
    public GameObject exit;

    // Start is called before the first frame update
    void Start()
    {
        if (Monetization.isSupported) Monetization.Initialize("3597679", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (openCase == true)
        {
            scrollSpeed = Mathf.MoveTowards(scrollSpeed, 0f, velocity * Time.deltaTime);
            RaycastHit2D hit = Physics2D.Raycast(Vector2.down, Vector2.up);
            exit.SetActive(false);
            if (hit.collider != null)
            {
                if (scrollSpeed == 0)
                {
                    dropPan.SetActive(true);
                    finalDrop.sprite = hit.collider.gameObject.GetComponent<Image>().sprite;
                }
            }
            else if(scrollSpeed == 0)
            {
                scrollSpeed = Mathf.MoveTowards(scrollSpeed, -5f, velocity * Time.deltaTime);
            }
        }
    }
    public void casebttn(int caseInt)
    {
        if(cs.score >= 200)
        {
            openCase = true;
            gameObject.SetActive(true);
            casinocntrl();
            velocity = Random.Range(6f, 7f);
            cs.score = cs.score - 200;
            rolling();
        }
        else
        {
            notpot.SetActive(true);
        }
    }
    public void ok()
    {
        if (finalDrop.sprite.name.Equals("401"))
        {
            cs.score = cs.score + 400;
        }
        Invoke("zd", 0.1f);
    }

    public void ok2()
    {
        notpot.SetActive(false);
    }

    public void zd()
    {
        v5050.SetActive(false);
        SceneManager.LoadScene(Application.loadedLevel);
    }
    void casinocntrl()
    {
        for (int a = 0; a < 20; a++)
        {
            int rand = Random.Range(0, 1000);
            int randWeapon = 0;
            if (rand <= 500)
            {
                randWeapon = 0;
            }
            else if (rand > 500 && rand <= 1000)
            {
                randWeapon = 1;
            }
            GameObject obj = Instantiate(prefabs[randWeapon], new Vector2(0, 0), Quaternion.identity) as GameObject;
            obj.transform.SetParent(sp.transform);
            obj.transform.localScale = new Vector2(1f, 1f);
        }
    }
    void rolling()
    {
        roll.interactable = false;
        rollad.interactable = false;
    }
    public void rollbtnad()
    {
        if (Monetization.IsReady("rewardedVideo"))
        {
            ShowAdCallbacks options = new ShowAdCallbacks();
            options.finishCallback = HandleShowResult;
            ShowAdPlacementContent ad = Monetization.GetPlacementContent("rewardedVideo") as ShowAdPlacementContent;
            ad.Show(options);
        }
    }
    void HandleShowResult(ShowResult result)
    {
        if (result == ShowResult.Finished)
        {
            openCase = true;
            gameObject.SetActive(true);
            casinocntrl();
            velocity = Random.Range(6f, 7f);
            rolling();
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
}
