using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;

public class DataBase
{
    // Start is called before the first frame update
    DatabaseReference _mDatabaseRef;
    public DataBase()
    {
        _mDatabaseRef = FirebaseDatabase.DefaultInstance.RootReference;
    }
    public void writeNewUser(string userId, string name, string email, string password) {
        User user = new User(name, email, password);
        string json = JsonUtility.ToJson(user);

        _mDatabaseRef.Child("users").Child(userId).SetRawJsonValueAsync(json);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
