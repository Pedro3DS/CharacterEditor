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
    public void writeNewUser(string userId, string name, string email, string password, int points, string characterId) {
        User user = new User(name, email, password, points, characterId);
        string json = JsonUtility.ToJson(user);

        _mDatabaseRef.Child("users").Child(userId).SetRawJsonValueAsync(json);
    }
    public void writeNewCharacter(string characterId ,string color) {
        Character character = new Character(color);
        string json = JsonUtility.ToJson(character);

        _mDatabaseRef.Child("characters").Child(characterId).SetRawJsonValueAsync(json);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
