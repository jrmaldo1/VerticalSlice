using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour

{
    [SerializeField] private float _torqueForce;
    [SerializeField] private Rigidbody _playerRigidbody;
    [SerializeField] private Animator _animator;
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _jump;
    [SerializeField] private float _mouseSensitivity;

    private Transform _cameraTrans;
    private float _rotationX;
    private float _rotationY;
  //  private bool _isGrounded = false;


    private void Start()
    {
     //   Cursor.lockState = CursorLockMode.Locked;
      //  _cameraTrans = Camera.main.transform;
    }

    private void Update()
    {

        float mouseY = Input.GetAxisRaw("Mouse Y");
        _rotationY += mouseY * _mouseSensitivity;
        _rotationY = Mathf.Clamp(_rotationY, -60.0f, 60.0f);

        float mouseX = Input.GetAxisRaw("Mouse X");
        _rotationX += mouseX * _mouseSensitivity;

      //  _cameraTrans.localEulerAngles = new Vector3(-_rotationY, 0, 0);
        transform.localEulerAngles = new Vector3(0, _rotationX, 0);


        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");


        transform.Translate(
           ((vertical * Vector3.forward) + (horizontal * Vector3.right))
           * _moveSpeed * Time.deltaTime
       );

        if (Input.GetKeyDown(KeyCode.Space)) // && _isGrounded)
        {
           // _animator.SetTrigger("Jump");
            _playerRigidbody.AddForce(Vector3.up * _jump, ForceMode.Impulse);
            Debug.Log(_jump);
            Debug.Log("work");

        }
    }
}

