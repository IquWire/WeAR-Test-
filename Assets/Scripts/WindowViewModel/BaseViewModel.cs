using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseViewModel
{
    public virtual void Init() { LoadView();}
    public virtual void LoadView() { }
    public virtual void OpenWindow() { }
    public virtual void CloseWindow() { }
    public virtual void SetupWindow() { }
}
