using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseService : IService
{
    public void StartService()
    {
        
    }

    public void StopService()
    {
        
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void UnPause()
    {
        Time.timeScale = 1;
    }
}
