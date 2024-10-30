using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleFunctionality : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool eaten = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(){
        eaten = true;
        this.gameObject.SetActive(false);
    }
}
