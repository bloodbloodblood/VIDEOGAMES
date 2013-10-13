using UnityEngine;
using System.Collections;

public class SelectPath : MonoBehaviour 
{
	//public int i, j;
	
	private bool firstCube, secondCube;
	private int firstI, firstJ, secondI, secondJ;
	
	
	// Use this for initialization
	void Start () 
	{
		//print ("even starting??? in here??? ");
		//firstCube = false;
		//secondCube = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	//void Clicked()
	//{
	//	renderer.material.color = Color.green;
	//}
	
 	void OnMouseDown()
	{
		if(!firstCube && (renderer.material.color != Color.black))
		{
			print ("first: " + firstCube);
			renderer.material.color = Color.green;
			//firstI = i;
			//firstJ = j;
			this.firstCube = true;
		}
		else if(renderer.material.color != Color.black && firstCube && !secondCube)
		{
			print ("2nd");			
			renderer.material.color = Color.green;
			//secondI = i;
			//secondJ = j;
			this.secondCube = true;
		}
 	}   	
}
