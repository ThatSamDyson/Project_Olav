using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class S_playerController : MonoBehaviour
{
    //input fields
    private PlayerControls playerControl;
    private InputAction move;

    //Movement Fields
    private Rigidbody rb;
    [SerializeField] private float movementForce = 1f;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float maxSpeed = 5f;
    [SerializeField] private float launchForce = 1f;
    private Vector3 forceDirection = Vector3.zero;
    public AudioSource jumpSound;

    [SerializeField] private Camera playerCamera;

    Collider collider;

    private void Awake()
    {
        collider = GetComponent<Collider>();
        rb = this.GetComponent<Rigidbody>(); 
        playerControl = new PlayerControls();
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (PauseMenu.GameIsPaused == true)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    private void OnEnable()
    {
        playerControl.Player.Jump.started += DoJump;
        move = playerControl.Player.Move;
        playerControl.Player.Enable();
    }

    private void OnDisable()
    {
        playerControl.Player.Jump.started -= DoJump;
        playerControl.Player.Disable();
    }

    private void FixedUpdate()
    {
        forceDirection += move.ReadValue<Vector2>().x * GetCameraRight(playerCamera) * movementForce;
        forceDirection += move.ReadValue<Vector2>().y * GetCameraForward(playerCamera) * movementForce;


        rb.AddForce(forceDirection, ForceMode.Impulse);
        forceDirection = Vector3.zero;

        if (rb.velocity.y < 0f)
            rb.velocity -= Vector3.down * Physics.gravity.y * Time.fixedDeltaTime;

        Vector3 horizontalVelocity = rb.velocity;
        horizontalVelocity.y = 0;
        if (horizontalVelocity.sqrMagnitude > maxSpeed * maxSpeed)
            rb.velocity = horizontalVelocity.normalized * maxSpeed + Vector3.up * rb.velocity.y;

        LookAt();
    }

    private void LookAt()
    {
        Vector3 direction = rb.velocity;
        direction.y = 0f;

        if (move.ReadValue<Vector2>().sqrMagnitude > 0.1f && direction.sqrMagnitude > 0.1f)
            this.rb.rotation = Quaternion.LookRotation(direction, Vector3.up);
        else
            rb.angularVelocity = Vector3.zero;
    }

    private Vector3 GetCameraForward(Camera playerCamera)
    {
        Vector3 forward = playerCamera.transform.forward;
        forward.y = 0;
        return forward.normalized;
    }

    private Vector3 GetCameraRight(Camera playerCamera)
    {
        Vector3 right = playerCamera.transform.right;
        right.y = 0;
        return right.normalized;
    }

    private void DoJump(InputAction.CallbackContext obj)
    {
        if(IsGrounded())
        {
            Debug.Log("Grounded");
            forceDirection += Vector3.up * jumpForce;
            jumpSound.Play();
        }
    }

    private bool IsGrounded()
    {
        //return true;

        //collider.bounds.extents.y;
        Ray ray = new Ray(this.transform.position, Vector3.down);
        Debug.DrawLine(this.transform.position, transform.position + (Vector3.down * 50), color: Color.green, 30f);
        if (Physics.Raycast(ray, out RaycastHit hit, 1f))
            return true;
        else
            return false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "JumpPad")
        {
            rb.AddForce(new Vector3(0f, launchForce, 0f), ForceMode.Impulse);
        }

        
    
    }
} 
