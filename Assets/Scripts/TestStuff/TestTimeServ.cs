using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTimeServ : MonoBehaviour
{
    private TimeService TimeService;
    private PauseService PauseService;

    public int freak;
    public int endTime;

    void Start ()
    {
        PauseService = new PauseService();
        TimeService = GetComponent<TimeService>();
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            TimeService.StartCount(CallbackStart, freak, FreakCallback, endTime, EndCallback, TimeService.EndlesTime.Finite);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            PauseService.Pause();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            PauseService.UnPause();
        }
    }

    public void CallbackStart(int time)
    {
        Debug.Log("StartTime = " + time);
    }

    public void FreakCallback(int time)
    {
        Debug.Log("FreakCallback = " + time);
    }

    public void EndCallback(int time)
    {
        Debug.Log("EndCallback = " + time);
    }
}
