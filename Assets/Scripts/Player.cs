using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public int MaxHealth = 100;
    public int currentHealth;
    private int appleNum = 0;

    public TextMeshProUGUI appleText;

    private void OnTriggerEnter(Collider other){

        if(other.transform.tag == "Apple"){
            appleNum++;
            appleText.text = "Apples: " + appleNum.ToString();
            other.gameObject.SetActive(false);
        }
    }

    void Update(){
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if (appleNum >= 10){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
