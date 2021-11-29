using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField, Range(1, 100)]
    private float _moveSpeed;


    void LateUpdate()
    {
        transform.Translate(_moveSpeed * Time.deltaTime * Vector3.forward);
    }
}
