using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadGame : MonoBehaviour
{
    public SaveGame_SO data;
    public PlayerInfo playerInfo;
    public CountdownTimer countdownTimer;
    public Health HealthInfo;
    public Text HealthText;

    public void OnUserLoaded()
    {
        // For loading time & hdalth
        countdownTimer.timer = data.TimeLeft;
        var HealthInt = data.PlayerHealth;
        HealthInfo.currentHealth = data.PlayerHealth;
        HealthText.text = HealthInt.ToString();

        // Loading Position of Player
        Vector3 newPlayerPosition;

        newPlayerPosition.x = (data.PlayerPosition)[0];
        newPlayerPosition.y = (data.PlayerPosition)[1];
        newPlayerPosition.z = (data.PlayerPosition)[2];
        playerInfo.VRSetup.transform.position = newPlayerPosition;

        //Loading Position of Boxes
        Vector3 newBox1Position;

        newBox1Position.x = (data.Box1Position)[0];
        newBox1Position.y = (data.Box1Position)[1];
        newBox1Position.z = (data.Box1Position)[2];
        playerInfo.Box1.transform.position = newBox1Position;

        Vector3 newBox2Position;

        newBox2Position.x = (data.Box2Position)[0];
        newBox2Position.y = (data.Box2Position)[1];
        newBox2Position.z = (data.Box2Position)[2];
        playerInfo.Box2.transform.position = newBox2Position;

        Vector3 newBox3Position;

        newBox3Position.x = (data.Box3Position)[0];
        newBox3Position.y = (data.Box3Position)[1];
        newBox3Position.z = (data.Box3Position)[2];
        playerInfo.Box3.transform.position = newBox3Position;

        // Delete the water if =0, (setted water = 0, if destroyed when saving)
        if (data.Water1 == 0)
        {
            Destroy(playerInfo.Water1);
        }

        if (data.Water2 == 0)
        {
            Destroy(playerInfo.Water2);
        }

        if (data.Water3 == 0)
        {
            Destroy(playerInfo.Water3);
        }

        if (data.Water4 == 0)
        {
            Destroy(playerInfo.Water4);
        }


        //Delete fires if alr put out
        if (data.Fire1 == 0)
        {
            Destroy(playerInfo.Fire1);
        }
        if (data.Fire2 == 0)
        {
            Destroy(playerInfo.Fire2);
        }
        if (data.Fire3 == 0)
        {
            Destroy(playerInfo.Fire3);
        }
    }
}
