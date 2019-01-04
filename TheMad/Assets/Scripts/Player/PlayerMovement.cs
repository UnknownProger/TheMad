using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    #region Fields

    [SerializeField]
    private float _speed = 3f;
    [SerializeField]
    private bool _isMoving = false;
    [SerializeField]
    private bool _isAllowMove = false;

    private Vector3 _direction;
    private Vector3 _lastDirection = Vector3.zero;

    [SerializeField]
    private Transform _legs;

    #endregion Fields
    #region Properties

    public bool GetMovingState
    {
        get { return _isMoving; }
    }

    public bool SetAllowMoving
    {
        get { return _isAllowMove; }
        set { _isAllowMove = value; }
    }

    #endregion Properties
    #region Methods

    private void Update()
    {

        LookAtCursor();

        if (_direction != Vector3.zero)
        {
            _isMoving = true;
        }
        else
        {
            _isMoving = false;
        }

        _direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), transform.position.z).normalized;
        transform.Translate(_direction * _speed * Time.deltaTime, Space.World);

        if (_direction != Vector3.zero)
        {
            _lastDirection = _direction;
        }

        _legs.up = _lastDirection;
    }

    private void LookAtCursor()
    {
        Vector3 lookPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        transform.eulerAngles = new Vector3(0, 0, (Mathf.Atan2((lookPos.y - transform.position.y), (lookPos.x - transform.position.x)) * Mathf.Rad2Deg - 90f));
    }

    #endregion Methods
}
