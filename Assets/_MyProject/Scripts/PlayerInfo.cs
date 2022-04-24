using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo : MonoBehaviour
{
    //Contain Objects regarding the Save
    public SaveGame_SO data;

    [Header("Player")]
    public GameObject VRSetup;

    [Header("Boxes")]
    public GameObject Box1;
    public GameObject Box2;
    public GameObject Box3;

    [Header("Water")]
    public GameObject Water1;
    public GameObject Water2;
    public GameObject Water3;
    public GameObject Water4;

    [Header("Fires")]
    public GameObject Fire1;
    public GameObject Fire2;
    public GameObject Fire3;
}
