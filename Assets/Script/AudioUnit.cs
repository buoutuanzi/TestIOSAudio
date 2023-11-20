using System;
using AOT;
using FMOD;
using FMOD.Studio;
using FMODUnity;
using Unity.VisualScripting;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class AudioUnit : MonoBehaviour
{
    private bool needRelease = false;
    private StudioEventEmitter _audioSource;
    private GenSkillAudio mgr;
    public void SetMgr(GenSkillAudio mgr)
    {
        this.mgr = mgr;
    }

    public void Awake()
    {
        _audioSource = GetComponent<StudioEventEmitter>();
    }

    public void Play()
    {
        _audioSource.Play();
    }
}
