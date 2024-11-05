using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public GameObject wall;
    public GameObject platform;
    public int MaxHealth = 100;
    public int currentHealth;
    public static int appleNum = 0;
    public static int platformCounter = 0;
    private bool isPlayerDead = false;

    public GameObject platformCounterTrigger;


    public TextMeshProUGUI appleText;
    public TextMeshProUGUI platformCounterText;

    private void OnTriggerEnter(Collider other)
    {

        if (other.transform.tag == "Apple")
        {
            appleNum++;
            appleText.text = "Apples: " + appleNum.ToString();
            other.gameObject.SetActive(false);
        }


        if (other.transform.tag == "platformCounter")
        {

            other.gameObject.SetActive(false);
            platformCounter++;
            platformCounterText.text = platformCounter.ToString();
        }

        if (other.transform.tag == "enemy")
        {
            Debug.Log("Player is dead now");
            isPlayerDead = true;
        }

    }

    void Update()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if (appleNum >= 10)
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            wall.SetActive(false);
        }

        if (transform.position.y <= -20 || isPlayerDead)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
