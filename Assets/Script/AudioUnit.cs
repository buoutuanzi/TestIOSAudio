using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioUnit : MonoBehaviour
{
    private AudioSource _audioSource;
    private GenSkillAudio mgr;
    private float waitTime = 0;
    public void SetMgr(GenSkillAudio mgr)
    {
        this.mgr = mgr;
    }

    public void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
        AudioClip clip = _audioSource.clip;
        waitTime = clip.length;
    }

    public void Play()
    {
        _audioSource.Play();
        StartCoroutine(StopAndReturn());
    }

    IEnumerator StopAndReturn()
    {
        yield return new WaitForSeconds(waitTime);
        _audioSource.Stop();
        mgr.ReturnAudioGO(gameObject);
        yield break;
    }
}
