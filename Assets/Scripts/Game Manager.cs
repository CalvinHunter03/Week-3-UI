using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance{
        get{
            if(_instance == null){
                Debug.LogError("GameManager is NULL");
            }
            return _instance;
        }
    }
    private void Awake(){
        if(_instance){
            Destroy(gameObject);
        } else {
            _instance = this;
        }
        DontDestroyOnLoad(this);
    }

    public Player player;

    void Update(){
        
    }








}

public enum GameState {
    Victory,
    Lose,
}
