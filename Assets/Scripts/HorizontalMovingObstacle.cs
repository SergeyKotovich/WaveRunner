
using UnityEngine;

public class HorizontalMovingObstacle  : MonoBehaviour
{
    [SerializeField] private float _travelTimeOneWay = 1f;
    [SerializeField] private float _maximumObstaclePathLength = 2f;
    private const float _obstacleOffsetAlongTheYAxis = 0;
    private Vector2 _startPosition ;
    private Vector2 _endPosition;
    private float _currentTime;
   private void Start()
   {
       _startPosition = GetComponent<Transform>().position;
       _endPosition = _startPosition + new Vector2(_maximumObstaclePathLength, _obstacleOffsetAlongTheYAxis);
   }

    
   private void Update()
   {
       _currentTime += Time.deltaTime;
       var progress = Mathf.PingPong(_currentTime, _travelTimeOneWay)/_travelTimeOneWay;
       transform.position = Vector3.Lerp(_startPosition, _endPosition, progress);
   }
}
