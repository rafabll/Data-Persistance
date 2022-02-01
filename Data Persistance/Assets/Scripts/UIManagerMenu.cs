using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManagerMenu : MonoBehaviour
{
    public static UIManagerMenu sharedInstance;
    public TMP_InputField inputField;
  
    private void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    } 

    private void Start()
    {
        string existingUserName = PlayerPrefs.GetString("USER_NAME");
        if(existingUserName != "")
        {
            inputField.placeholder.GetComponent<TextMeshProUGUI>().text = existingUserName;
        }
    }
    
    public void SaveUserName()
    {
        string userName = inputField.text;

        if(userName == "")
        {
          DataPersistent.sharedInstance.userName = inputField.placeholder.GetComponent<TextMeshProUGUI>().text;
        }
        else
        {
            DataPersistent.sharedInstance.userName = userName;
        }

        PlayerPrefs.SetString("USER_NAME", DataPersistent.sharedInstance.userName);
    }
}
