using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class PlayerController : MonoBehaviour
{
    private CharacterController m_cC;

    public InputActionReference Move;    
    public float Speed;
    [SerializeField]
    private Camera m_playerCamera;
    Animator m_anim;

    private bool m_engaged = false;
    private bool m_moving;

    public float m_turnSpeed;

    private Vector3 m_moveDirection;
    

    private void Awake()
    {
        m_cC = GetComponent<CharacterController>();
        m_anim = GetComponentInChildren<Animator>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void FixedUpdate()
    {        
        if (m_moving)
        {
            Debug.Log("X Input: " + Move.action.ReadValue<Vector2>().x);
            Vector3 rightVector = Move.action.ReadValue<Vector2>().x * getCameraRight(m_playerCamera);
            Vector3 forwardVector = Move.action.ReadValue<Vector2>().y * getCameraForward(m_playerCamera);
            
            m_moveDirection = rightVector + forwardVector;
            m_moveDirection.Normalize();

            transform.forward = m_moveDirection;
            m_cC.SimpleMove(m_moveDirection * Speed);
        }             
    }    

    // Update is called once per frame
    void Update()
    {
        //set facing direction based off of input
        handleOnInput();
    } 
    
    private Vector3 getCameraForward(Camera _playerCamera)
    {
        Vector3 forward = _playerCamera.transform.forward;
        forward.y = 0;
        return forward.normalized;        
    }

    private Vector3 getCameraRight(Camera _playerCamera)
    {
        Vector3 right = _playerCamera.transform.right;
        right.y = 0;
        return right.normalized;
    }

    private void handleOnInput()
    {
        if (Move.action.WasPressedThisFrame())
        {
            m_moving = true;
            m_anim.SetTrigger("Run");
        }
        if (Move.action.WasReleasedThisFrame())
        {
            m_moving = false;
            m_anim.SetTrigger("Idle");
        }
    }

}
