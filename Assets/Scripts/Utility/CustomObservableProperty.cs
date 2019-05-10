using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomObservableProperty<T>
{
    public delegate void CustomOservablePropertyEvent<T>(T item);

    protected T item;

    public T Item
    {
        get
        {
            if (GetEvent != null)
                GetEvent(item);
            return item;
        }
        set
        {
            item = value;

            if (SetEvent != null)
                SetEvent(item);
        }
    }

    public event CustomOservablePropertyEvent<T> SetEvent;
    public event CustomOservablePropertyEvent<T> GetEvent;

    public override string ToString()
    {
        return item.ToString();
    }
}

public class ObservableInt : CustomObservableProperty<int>
{
    public override string ToString()
    {
        return item.ToString();
    }
}

public class ObservableString : CustomObservableProperty<string>
{
    public override string ToString()
    {
        return item;
    }
}

public class ObservableFloat : CustomObservableProperty<float>
{
    public override string ToString()
    {
        return item.ToString();
    }
}
