using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPersistent : MonoBehaviour
{
    public static DataPersistent sharedInstance;
    public string userName;

    private void Awake()
    {
        if(sharedInstance == null)
        {
            sharedInstance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
