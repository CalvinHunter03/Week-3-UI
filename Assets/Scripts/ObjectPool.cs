using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{

    public static ObjectPool instance;

    private List<GameObject> pooledApples = new List<GameObject>();
    private List<GameObject> platform = new List<GameObject>();


    private int appleAmount = 50;
    private int platformAmount = 100;


    [SerializeField] private GameObject applePrefab;
    [SerializeField] private GameObject platformPrefab;


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
        for (int i = 0; i < appleAmount; i++)
        {
            GameObject obj = Instantiate(applePrefab);
            obj.SetActive(false);
            pooledApples.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < pooledApples.Count; i++)
        {
            if (!pooledApples[i].activeInHierarchy)
            {
                return pooledApples[i];
            }
        }
        return null;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
