using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class EndScreenScript : MonoBehaviour
{
    // Start is called before the first frame update

    public TextMeshProUGUI appleText;
    public TextMeshProUGUI platformCounterText;
    private int appleNum = Player.appleNum;
    private int platformCounter = Player.platformCounter;


    void Start()
    {
        appleText.text = "Apples Collected: " + appleNum.ToString();
        platformCounterText.text = "Platforms Landed on: " + platformCounter.ToString();


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
        Player.appleNum = 0;
        Player.platformCounter = 0;
    }

}
