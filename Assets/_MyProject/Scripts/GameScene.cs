﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void BtnNewScene()
    {
        SceneManager.LoadScene("GameScene 1");
    }

}
