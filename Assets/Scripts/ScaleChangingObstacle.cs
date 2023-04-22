using System;
using UnityEngine;

public class ScaleChangingObstacle : MonoBehaviour
{
    [SerializeField] private float _timeOfOneChange = 1f;
    [SerializeField] private float _maximumSizeIncrease = 2f;
    private Vector2 _startState;
    private Vector2 _endState;
    private float _currentTime;
    

    private void Awake()
    {
        _startState = GetComponent<Transform>().localScale;
        _endState = _startState + new Vector2(_maximumSizeIncrease, _maximumSizeIncrease);
    }

    private void Update()
    {
        _currentTime += Time.deltaTime;
        var progress = Mathf.PingPong(_currentTime, _timeOfOneChange)/_timeOfOneChange;
        transform.localScale = Vector3.Lerp(_startState, _endState, progress);
    }
}
