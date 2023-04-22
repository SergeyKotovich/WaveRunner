using System;
using UnityEngine;

public class VerticalMovingObstacle : MonoBehaviour
{
   [SerializeField] private float _travelTimeOneWay = 1f;
   [SerializeField] private float _maximumObstaclePathLength = 4f;
   private const float _obstacleOffsetAlongTheXAxis = 0;
   private Vector2 _startPosition;
   private Vector2 _endPosition;
   private float _currentTime;

   private void Awake()
   {
      _startPosition = GetComponent<Transform>().position;
      _endPosition = _startPosition + new Vector2(_obstacleOffsetAlongTheXAxis, _maximumObstaclePathLength);
   }

   private void Update()
   {
      _currentTime += Time.deltaTime;
      var progress = Mathf.PingPong(_currentTime, _travelTimeOneWay) / _travelTimeOneWay;
      transform.position = Vector3.Lerp(_startPosition, _endPosition, progress);
   }
}
