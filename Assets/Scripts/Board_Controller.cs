using UnityEngine;
using System.Collections;

public class Board_Controller : MonoBehaviour
{
    private float BoardMaximumAngle = 7.0f;     //Board MaxAngle and Speed have been made private so that the values stay consistant among gameboard-model versions.
    private float BoardMovementSpeed = 0.50f;   //Trial and error was used to determine the best possible to angle and speed. To adjust or optimize, make these variables public and recalibrate 
    private float moveHorizontal;               //Stores horizontal input
    private float moveVertical;                 //Stores vertical input

    void FixedUpdate()
    {
        moveHorizontal = Input.GetAxis("Horizontal");   //Accept and store the horizontal input
        moveVertical = Input.GetAxis("Vertical");       //Accept and store the vertical input
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); //Define the input as a vector3 movement.

        rigidbody.velocity = movement * BoardMaximumAngle * BoardMovementSpeed;                     //Sets the velocity at which the board will rotate
        rigidbody.rotation = Quaternion.Euler(rigidbody.velocity.z, 0.0f, -rigidbody.velocity.x);   //Actuates the rotation, with the set angles, at the determined velocty.

        //DEBUG: displays the current value of the following four variables
        Debug.Log("Max Angle : " + BoardMaximumAngle.ToString()
            + " -- Movement Speed : " + BoardMovementSpeed.ToString()
            + " -- Input : " + movement.ToString()
            + " -- velocity : " + rigidbody.velocity.ToString());
    }//END FixedUpdate
}//END Class