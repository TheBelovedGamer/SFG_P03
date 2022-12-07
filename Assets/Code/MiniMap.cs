using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap : MonoBehaviour
{

    public Transform player;
    public Transform playerOrientation;


    private void LateUpdate()
    {
        //setting up basic following
        Vector3 newPosition = player.position;
        newPosition.y = transform.position.y;
        transform.position = newPosition;

        //adding rotation
        transform.rotation = Quaternion.Euler(90f, playerOrientation.eulerAngles.y, 0f);
    }
}
