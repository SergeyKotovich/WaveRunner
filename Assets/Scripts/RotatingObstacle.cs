using System;
using UnityEngine;

public class RotatingObstacle : MonoBehaviour
{
    [SerializeField]
    private float _oneTurnTime = 3f;
    private float _currentTime;
    private float _angleOfRotation = 0.5f;
    private Vector3 _directionOfRotation = Vector3.forward;
    
    

    private void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = _currentTime / _oneTurnTime;
        transform.Rotate(_directionOfRotation*_angleOfRotation*progress);
       
    }
}
