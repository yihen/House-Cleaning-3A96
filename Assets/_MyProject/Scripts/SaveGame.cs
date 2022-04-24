using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGame : MonoBehaviour
{
    public SaveGame_SO data;
    public PlayerInfo playerInfo;
    public CountdownTimer countdownTimer;
    public Health HealthInfo;

    public void OnUserSaved()
    {
        // For saving time & health
        data.TimeLeft = countdownTimer.timer;
        data.PlayerHealth = HealthInfo.currentHealth;

        //For Saving Player Position
        data.PlayerPosition = new float[3];
        (data.PlayerPosition)[0] = playerInfo.VRSetup.transform.position.x;
        (data.PlayerPosition)[1] = playerInfo.VRSetup.transform.position.y;
        (data.PlayerPosition)[2] = playerInfo.VRSetup.transform.position.z;

        //Boxes Positions
        data.Box1Position = new float[3];
        (data.Box1Position)[0] = playerInfo.Box1.transform.position.x;
        (data.Box1Position)[1] = playerInfo.Box1.transform.position.y;
        (data.Box1Position)[2] = playerInfo.Box1.transform.position.z;

        data.Box2Position = new float[3];
        (data.Box2Position)[0] = playerInfo.Box2.transform.position.x;
        (data.Box2Position)[1] = playerInfo.Box2.transform.position.y;
        (data.Box2Position)[2] = playerInfo.Box2.transform.position.z;

        data.Box3Position = new float[3];
        (data.Box3Position)[0] = playerInfo.Box3.transform.position.x;
        (data.Box3Position)[1] = playerInfo.Box3.transform.position.y;
        (data.Box3Position)[2] = playerInfo.Box3.transform.position.z;

        //Saving Water
        if (!playerInfo.Water1)
        {
            data.Water1 = 0;
        }
        else
        {
            data.Water1 = 1;
        }

        if (!playerInfo.Water2)
        {
            data.Water2 = 0;
        }
        else
        {
            data.Water2 = 1;
        }

        if (!playerInfo.Water3)
        {
            data.Water3 = 0;
        }
        else
        {
            data.Water3 = 1;
        }

        if (!playerInfo.Water4)
        {
            data.Water4 = 0;
        }
        else
        {
            data.Water4 = 1;
        }


        //Saving Fires
        if (!playerInfo.Fire1)
        {
            data.Fire1 = 0;
        }
        else
        {
            data.Fire1 = 1;
        }

        if (!playerInfo.Fire2)
        {
            data.Fire2 = 0;
        }
        else
        {
            data.Fire2 = 1;
        }

        if (!playerInfo.Fire3)
        {
            data.Fire3 = 0;
        }
        else
        {
            data.Fire3 = 1;
        }
    }
}
