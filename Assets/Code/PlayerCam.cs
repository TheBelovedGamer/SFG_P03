using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    //player camera movement script

    //how sensititive the mouse movement to rotation is
    public float sensX;
    public float sensY;

    //camera rotation variables
    float xRotation;
    float yRotation;

    public Transform camOrientation;



    private void Start()
    {
        //locking the cursor & making it invisible
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        //get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        //Applying rotations
        yRotation += mouseX;
        xRotation -= mouseY;

        //clamping x to not look too far up or down
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //rotate camera & player
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        camOrientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
