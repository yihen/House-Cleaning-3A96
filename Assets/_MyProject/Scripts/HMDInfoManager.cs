﻿using UnityEngine;
using UnityEngine.XR;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;


//---------------------------------------------------------------------------------
// Author		: Vincent Goh
// Date  		: 2021-01-29
// Modified By	: Vincent Goh
// Modified Date: 2021-01-29
// Youtube      : https://www.youtube.com/watch?v=UlqdHrfXppo
// Description	: This will check which HMD is available. If not try to use MockHMD.
//---------------------------------------------------------------------------------
public class HMDInfoManager : MonoBehaviour
{
    //===================
    // Private Variables
    //===================
    [SerializeField] GameObject mockSimulator;
    [SerializeField] GameObject XRrigcam;

    //---------------------------------------------------------------------------------
    // Start is when Script is active
    //---------------------------------------------------------------------------------
    protected void Start()
    {
        Debug.Log("Is Device Active: " + XRSettings.isDeviceActive);
        Debug.Log("Device Name is : " + XRSettings.loadedDeviceName);

        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No Headset plugged in");
            mockSimulator.SetActive(true);
        }
        else if (XRSettings.isDeviceActive && (XRSettings.loadedDeviceName == "Mock HMD"
            || XRSettings.loadedDeviceName == "MockHMD Display"))
        {
            Debug.Log("Using Mock HMD");
            mockSimulator.SetActive(true);
            XRrigcam.GetComponent<TrackedPoseDriver>().rotationAction.ApplyBindingOverride("<XRSimulatedHMD>/centerEyeRotation");
        }
        else
        {
            Debug.Log("We Have a Headset " + XRSettings.loadedDeviceName);
            mockSimulator.SetActive(false);
            XRrigcam.GetComponent<TrackedPoseDriver>().rotationAction.RemoveAllBindingOverrides();
        }
        // Lock Mouse Cursor at center of Game Window and hide it. Press ESC to see cursor
        Cursor.lockState = CursorLockMode.Locked;
    }

}
