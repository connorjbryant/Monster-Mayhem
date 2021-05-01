using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, gameOver, RestartBtn, QuitBtn;
    public GameObject jaguar1, jaguar2, jaguar3, gameOver1, RestartBtn1, QuitBtn1;
    public static int health;
    public static int soicHealth;

    // Start is called before the first frame update
    void Start()
    {
        health = 3;
        soicHealth = 3;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
        jaguar1.gameObject.SetActive(true);
        jaguar2.gameObject.SetActive(true);
        jaguar3.gameObject.SetActive(true);
        gameOver1.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 3)
            health = 3;

        else if (soicHealth > 3)
            soicHealth = 3;

        switch (health)
        {
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                RestartBtn.gameObject.SetActive(true);
                QuitBtn.gameObject.SetActive(true);

                break;
        }

        switch (soicHealth)
        {
            case 3:
                jaguar1.gameObject.SetActive(true);
                jaguar2.gameObject.SetActive(true);
                jaguar3.gameObject.SetActive(true);
                break;
            case 2:
                jaguar1.gameObject.SetActive(true);
                jaguar2.gameObject.SetActive(true);
                jaguar3.gameObject.SetActive(false);
                break;
            case 1:
                jaguar1.gameObject.SetActive(true);
                jaguar2.gameObject.SetActive(false);
                jaguar3.gameObject.SetActive(false);
                break;
            case 0:
                jaguar1.gameObject.SetActive(false);
                jaguar2.gameObject.SetActive(false);
                jaguar3.gameObject.SetActive(false);
                gameOver1.gameObject.SetActive(true);
                RestartBtn1.gameObject.SetActive(true);
                QuitBtn1.gameObject.SetActive(true);

                break;
        }
    }
}
