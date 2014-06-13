/*
 * If the ball falls of the board, return it to the starting postion
 */
using UnityEngine;
using System.Collections;

public class Player_OutOfBounds : MonoBehaviour
{
	public float returnThreshold;
	public float returnMeToX;
	public float returnMeToY;
	public float returnMeToZ;

    void Update()
    {
        //Return the ball if it fell off the board.
        if (rigidbody.position.y < returnThreshold)       //If the ball fell off the board....
        {
			transform.position = new Vector3(returnMeToX, returnMeToY, returnMeToZ);  //Return player's sphere to the default starting postion
        }

    }//END Update
}//END Class