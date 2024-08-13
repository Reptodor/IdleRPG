using System;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private Image _clock;
    [SerializeField] private float _timeForChoosing;

    private float _remainingTime;

    public bool Chossing;

    public Action TimeExpired;

    private void OnEnable()
    {
        _remainingTime = _timeForChoosing;
    }

    private void Update()
    {
        if (Chossing)
        {
            _remainingTime -= Time.deltaTime;

            if(_remainingTime <= 0)
            {
                TimeExpired.Invoke();
                _remainingTime = _timeForChoosing;
            }
        }
    }
}
