using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseStuff;
    public GameObject realExplosive1, realExplosive2, realExplosive3;
    public GameObject fakeExplosive1, fakeExplosive2, fakeExplosive3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause2();
            }
        }
    }

    public void Pause2()
    {
        pauseStuff.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Resume()
    {
        pauseStuff.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Detonate()
    {
        StartCoroutine(DetonateTime());
    }

    public IEnumerator DetonateTime()
    {
        realExplosive1.SetActive(true);
        realExplosive2.SetActive(true);
        realExplosive3.SetActive(true);
        fakeExplosive1.SetActive(false);
        fakeExplosive2.SetActive(false);
        fakeExplosive3.SetActive(false);
        yield return new WaitForSeconds(1);
        realExplosive1.SetActive(false);
        realExplosive2.SetActive(false);
        realExplosive3.SetActive(false);
        fakeExplosive1.SetActive(true);
        fakeExplosive2.SetActive(true);
        fakeExplosive3.SetActive(true);
    }

}
