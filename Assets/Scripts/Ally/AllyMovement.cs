using UnityEngine;
using DG.Tweening;

public class AllyMovement : MonoBehaviour
{
    [SerializeField, Range(1, 100)]
    private float _moveSpeed;

    [SerializeField]
    private AllyAnimationController _allyAnimation;

    private PlayerInput _playerInput;

    private bool _isColumnAlly;

    private const float LOOK_AT_OFFSET = 0.65f;
    private const float LOOK_AT_ROTATE_DURATION = 0.45f;


    private void Awake()
    {
        _playerInput = FindObjectOfType(typeof(PlayerInput)) as PlayerInput;
    }


    void Update()
    {
        if (_isColumnAlly)
        {
            MoveForward();
            MoveToTouchPosition(_playerInput.GetTouchPosition());
        }
    }


    public void BecomeColumnAlly()
    {
        _isColumnAlly = true;
        _allyAnimation.StartRunningAnim();

        CrowdCount.Instance.IncreaseCrowdAmount();
    }


    private void MoveForward()
    {
        transform.Translate(_moveSpeed * Time.deltaTime * Vector3.forward);
    }


    public void MoveToTouchPosition(Vector3 touchPosition)
    {
        if (touchPosition != Vector3.zero)
        {
            touchPosition.y = transform.position.y;

            transform.position = Vector3.MoveTowards(transform.position, touchPosition, Time.deltaTime * _moveSpeed);

            if (Vector3.Distance(transform.position, touchPosition) >= LOOK_AT_OFFSET)
            {
                transform.DOLookAt(touchPosition, LOOK_AT_ROTATE_DURATION);
            }
        }
        else
        {
            if (transform.rotation != Quaternion.identity)
                transform.rotation = Quaternion.identity;
        }
    }


    public bool IsColumnAlly
    {
        get { return _isColumnAlly; }
    }
}
