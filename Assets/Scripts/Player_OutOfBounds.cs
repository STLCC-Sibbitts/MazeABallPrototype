/*
 * If the ball falls of the board, return it to the starting postion
 */
using UnityEngine;
using System.Collections;

public class Player_OutOfBounds : MonoBehaviour
{
    void Update()
    {
        //Return the ball if it fell off the board.
        if (rigidbody.position.y < 0)       //If the ball fell off the board....
        {
            transform.position = new Vector3(0, 40, 0);  //Return player's sphere to the default starting postion
        }

    }//END Update
}//END Class