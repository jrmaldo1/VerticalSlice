using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
public class FullScreenController2 : MonoBehaviour
{
    [SerializeField] private ScriptableRendererFeature _FullScreenEffect;

    void Start()
    {
        _FullScreenEffect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
