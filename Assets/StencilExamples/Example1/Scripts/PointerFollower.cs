using UnityEngine;

public class PointerFollower : MonoBehaviour
{
    [SerializeField, Range(0,10)] private float _distanceToCamera = 1;

    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        Vector3 pointerPosition = Input.mousePosition;

        pointerPosition.z = _distanceToCamera;

        transform.position = _camera.ScreenToWorldPoint(pointerPosition);
    }
}
