using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Pool;
using UnityEngine.UI;

public class GenSkillAudio : MonoBehaviour
{
    private void Awake()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(GenAudioGo);;
    }

    private ObjectPool<GameObject> audioPool = new ObjectPool<GameObject>(CreateFunc, o =>
    {
        o.SetActive(true);
    }, o =>
    {
        o.SetActive(false);
    }, o => DestroyImmediate(o), true, 8, 8);

    private static GameObject CreateFunc()
    {
        GameObject prefab = Resources.Load<GameObject>("SkillAudioGO");
        return Instantiate(prefab);
    }

    public void ReturnAudioGO(GameObject go)
    {
        audioPool.Release(go);
    }

    public void GenAudioGo()
    {
        var o = audioPool.Get();
        o.GetComponent<AudioUnit>().SetMgr(this);
        o.GetComponent<AudioUnit>().Play();
    }
}
