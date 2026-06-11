using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
public class FullScreenController : MonoBehaviour
{
    [SerializeField] private ScriptableRendererFeature _FullScreenEffect;
    [SerializeField] private float timeRemaining = 2f;
    private bool timerIsRunning = false;

    void Start()
    {
        _FullScreenEffect.SetActive(true);
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                _FullScreenEffect.SetActive(false);
                timerIsRunning = false;
            }
        }
    }
}
