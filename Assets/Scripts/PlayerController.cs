using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	//public float speed;   //Public means it is visible in the Unity Editor and that is where it will be initilized 
	//private int count = 0;//private means I can not view it in the inspector window and must be initlized in the script
	//public GUIText countText;
	void start()
	{
		//count = 0;
		//setCountText(count);
	}

	void FixedUpdate()
	{
        
	}
/* --------------------------------
 * THIS CODE WILL BE MODIFIED LATER
 * --------------------------------
 * 
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Pickup")
		{
			other.gameObject.SetActive(false);
			count++;
			setCountText(count);
		}
	}//END OnTriggerEnter

	void setCountText(int countInherit)
	{
		countText.text = "Count :  " + countInherit.ToString();
        if (countInherit == 7)
        {
            countText.text = "Congratulations! You Win :D :D :D!";
        }
	}//END setCountText
 */
}//END Class
