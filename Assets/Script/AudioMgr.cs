using System;
using System.Collections;
using System.Collections.Generic;
using AOT;
using FMOD;
using FMOD.Studio;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class AudioMgr : MonoBehaviour
{
    public static AudioMgr Instance;
    
    public Dictionary<IntPtr, Action> callBack = new Dictionary<IntPtr, Action>();

    private void Awake()
    {
        Instance = this;
    }
    
}
