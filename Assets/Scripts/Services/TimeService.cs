using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeService : MonoBehaviour, IService
{
    public enum EndlesTime
    {
        Finite,
        Endless
    }

    public void StartCount(Action<int> startCallback, int frequentCallTime, Action<int> frequenCallback,
                                            int duration, Action<int> endDurationCallback, EndlesTime EndlessTime)
    {
        StartCoroutine(StartCountCoroutine(startCallback,  frequentCallTime,  frequenCallback,
                                             duration,  endDurationCallback, EndlessTime));
    }

    public void StartService()
    {
        gameObject.SetActive(true);
    }

    public void StopService()
    {
        StopAllCoroutines();
        //gameObject.SetActive(false);
    }

    private IEnumerator StartCountCoroutine(Action<int> startCallback, int frequentCallTime, Action<int> frequenCallback,
                                            int duration, Action<int> endDurationCallback, EndlesTime EndlessTime)
    {
        float currentTime = 0;

        int integerTime = frequentCallTime;

        if (startCallback != null)
        {
            startCallback.Invoke((int)currentTime);
        }

        while (EndlessTime == EndlesTime.Endless || currentTime < duration)
        {
            currentTime += Time.deltaTime;

            if (EndlessTime != EndlesTime.Endless && currentTime >= duration)
            {
                currentTime = duration;
            }

            if ((int) currentTime == integerTime )
            {
                if (frequenCallback != null)
                {
                    frequenCallback.Invoke((int)currentTime);
                }

                integerTime += frequentCallTime;
            }

            yield return null;
        }

        if (endDurationCallback != null)
        {
            endDurationCallback.Invoke((int)currentTime);
        }
    }
}
