using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Character Save Data", menuName = "Player/Data", order = 1)]
public class SaveGame_SO : ScriptableObject
{
    [Header("Data")]
    [SerializeField]
    public float TimeLeft = 240;
    public float[] PlayerPosition;
    public int PlayerHealth = 100;

    public float[] Box1Position;
    public float[] Box2Position;
    public float[] Box3Position;

    public int Water1 = 1;
    public int Water2 = 1;
    public int Water3 = 1;
    public int Water4 = 1;

    public int Fire1 = 1;
    public int Fire2 = 1;
    public int Fire3 = 1;
    public int Fire4 = 1;

    [Header("Save Data")]
    string key;



    // Start is called before the first frame update
    void OnEnable()
    {
        JsonUtility.FromJsonOverwrite(PlayerPrefs.GetString(key), this);
    }

    // Update is called once per frame
    void OnDisable()
    {
        if (key == "")
        {
            key = name;
        }

        string jsonData = JsonUtility.ToJson(this, true);
        PlayerPrefs.SetString(key, jsonData);
        PlayerPrefs.Save();
    }
}
