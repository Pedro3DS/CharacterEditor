using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Xml;
using TMPro;
using UnityEngine;


public class CreateUser : MonoBehaviour
{
    private DataBase _db;
    [SerializeField] private TMP_InputField email;
    [SerializeField] private TMP_InputField password;
    void Start()
    {
        _db = new DataBase();
    }
    public void CreateNewUser() {
        _db.writeNewUser(Guid.NewGuid().ToString(),null, email.text.ToString(), password.text.ToString());
        // Debug.Log(email.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}