using System;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image _clock;
    [SerializeField] private float _timeForChoosing;

    private float _remainingTime;

    private bool _choosing;

    public static Action TimeExpired;

    private void OnEnable()
    {
        _remainingTime = _timeForChoosing;
        _choosing = true;
    }

    private void Update()
    {
        if (_choosing)
        {
            _remainingTime -= Time.deltaTime;

            if(_remainingTime <= 0)
            {
                TimeExpired?.Invoke();
                _remainingTime = _timeForChoosing;
            }
        }
        _clock.fillAmount = _remainingTime;
    }

    public void StartTimer()
    {
        _remainingTime = _timeForChoosing;
        _choosing = true;
    }

    public void StopTimer(float timeToStart)
    {
        _choosing = false;
        Invoke(nameof(StartTimer), timeToStart);
    }
}
