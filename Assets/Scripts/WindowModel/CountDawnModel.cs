using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class CountDawnModel
{
    public int duration;
    public int frequentInt;

    public ObservableString ObservableCountString = new ObservableString();

    public Action<int>EndCountAction;

    public void Setup(int dur, int frequent)
    {
        duration = dur;
        frequentInt = frequent;
        ServicesHolder.Instance.TimeService.StartCount(StartCount, frequentInt, Frequent, duration, EndCallback, TimeService.EndlesTime.Finite);
    }

    private void StartCount(int time)
    {
        ObservableCountString.Item = (duration - 1).ToString();
    }

    private void Frequent(int time)
    {
        if (time != (duration - 1) && (duration - 1) >= 0)
        {
            ObservableCountString.Item = ((duration -1)- time).ToString();
        }
        else
        {
            ObservableCountString.Item = "Start";
        }
    }

    private void EndCallback(int time)
    {
        if (EndCountAction != null)
        {
            EndCountAction.Invoke(time);
        }
    }
}
