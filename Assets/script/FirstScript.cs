using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    [SerializeField] Camera theCamera;
    [SerializeField] float LockSensitivity;
    [SerializeField] float Speed;

    float currentCameraRotationX;

    Rigidbody myRigid;
    void start()
    {
        if (myRigid == null)    myRi   gid = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;
    }
    

    // Update is called once per frame
    void Update()
    {
        Move();
        CameraRotationX();
        CameraRotationY();
    }

    public void Move()
    {
        float moveDirX = Input.GetAxisRaw("Horizontal");
        float moveDirY = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizontal = transform.right * moveDirX;
        Vector3 moveVertical = transform.forward * moveDirY;

        Vector3 velocity = (moveHorizontal + moveVertical).normalized * Speed;

        myRigid.MovePosition(transform.position + velocity * Time.deltaTime);
        if (Input.GetButtonDown("Jump"))
            myRigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }

    public void CameraRotationX()
    {
        float yRotation = Input.GetAxisRaw("Mouse X");
        Vector3 characterRotationY = new Vector3(0f, yRotation, 0f) * LockSensitivity;
        myRigid.MoveRotation(myRigid.rotation * (Quaternion.Euler(characterRotationY)));
    }

    void CameraRotationY()
    {
        float xRotation = Input.GetAxisRaw("Mouse Y");
        float cameraRotationX = xRotation * LockSensitivity;

        currentCameraRotationX -= cameraRotationX;

        currentCameraRotationX = Mathf.Clamp(currentCameraRotationX, -68, 68);

        theCamera.transform.localEulerAngles = new Vector3(currentCameraRotationX, 0f, 0f);
    }
}
