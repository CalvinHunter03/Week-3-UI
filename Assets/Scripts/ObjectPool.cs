using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public static ObjectPool instance;

    private List<GameObject> platformList = new List<GameObject>();
    private List<GameObject> appleList = new List<GameObject>();
    private List<GameObject> applePlatformList = new List<GameObject>();

    private int amountToPool = 20;
    [SerializeField] private GameObject platform;
    [SerializeField] private GameObject apple;
    [SerializeField] private GameObject applePlatform;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //platform loop
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject plat = Instantiate(platform);
            GameObject app = Instantiate(apple);
            GameObject appPlat = Instantiate(applePlatform);
            plat.SetActive(false);
            app.SetActive(false);
            appPlat.SetActive(false);
            platformList.Add(plat);
            appleList.Add(app);
            applePlatformList.Add(appPlat);



        }
    }

    public GameObject GetPlatformObject()
    {
        for (int i = 0; i < platformList.Count; i++)
        {
            if (!platformList[i].activeInHierarchy)
            {
                return platformList[i];
            }
        }
        return null;
    }

    public GameObject GetAppleObject()
    {
        for (int i = 0; i < appleList.Count; i++)
        {
            if (!appleList[i].activeInHierarchy)
            {
                return appleList[i];
            }
        }
        return null;
    }

    public GameObject GetApplePlatformObject()
    {
        for (int i = 0; i < applePlatformList.Count; i++)
        {
            if (!applePlatformList[i].activeInHierarchy)
            {
                return applePlatformList[i];
            }
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
