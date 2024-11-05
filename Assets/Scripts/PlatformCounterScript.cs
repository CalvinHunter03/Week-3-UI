using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCounterScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject counterTrigger;

    void OnEnable()
    {

        counterTrigger.SetActive(true);


    }




}
