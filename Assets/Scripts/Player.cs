using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{

    [SerializeField] private float _moveSpeed = 7f;

    private bool _isWalking = false;
    private void Update()
    {
        Vector2 inputVector = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            inputVector.y = 1f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector.x = -1f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector.y = -1f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector.x = 1f;
        }

        inputVector = inputVector.normalized;

        Vector3 moveDir = new Vector3 (inputVector.x, 0f, inputVector.y);

        transform.position += moveDir * _moveSpeed * Time.deltaTime;
        _isWalking = moveDir != Vector3.zero;

        float rotationSpeed = 10f;
        transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * rotationSpeed);
    }

    public bool IsWalking()
    {
        return _isWalking;
    }
}
