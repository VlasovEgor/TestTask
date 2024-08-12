using UnityEngine;

public class MovementArea : MonoBehaviour
{
    [SerializeField] private Transform _upperRightPoint;
    [SerializeField] private Transform _lowerLeftPoint;

    public bool IsPlayerInArea(Vector3 playerPosition)
    {
        if (playerPosition.x <= _upperRightPoint.position.x && playerPosition.y <= _upperRightPoint.position.y &&
            playerPosition.x >= _lowerLeftPoint.position.x && playerPosition.y >= _lowerLeftPoint.position.y)
        {
            Debug.Log("IN");
            return true;
        }

        Debug.Log("OUT");
        return true;

    }
}
