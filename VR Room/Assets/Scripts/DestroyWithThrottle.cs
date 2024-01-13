using System;
using System.Timers;
using UnityEngine;

public class DestroyWithThrottle : MonoBehaviour
{
    [Tooltip("Time before destroying in seconds")]
    public float throttleTime = 5.0f;

    private Timer _timer;
    private bool _isTimeElapsed = false;

    private void Start()
    {
        _timer = new Timer(throttleTime * 1000);

        var foo = gameObject;
        _timer.Elapsed += OnTimeElapsed;
        _timer.AutoReset = false;
        _timer.Start();
    }

    private void OnTimeElapsed(object sender, ElapsedEventArgs e)
    {
        _isTimeElapsed = true;
    }

    private void Update()
    {
        if (_isTimeElapsed)
        {
            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        _timer.Stop();
    }
}
