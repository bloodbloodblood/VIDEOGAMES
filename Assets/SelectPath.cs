using UnityEngine;
using System.Collections;

public class SelectPath : MonoBehaviour 
{
	public AStarPathFind AStarPathFind;
	
	
	//public int i, j;
	
	private bool selectStart;
	private GameObject start, finish;
	
	
	// Use this for initialization
	void Start () 
	{
		selectStart = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void pathSet(GameObject tile)
	{
		if(selectStart)
		{
			tile.renderer.material.color = Color.green;
			selectStart = false;
			start = tile;
			
		}
		else
		{
			tile.renderer.material.color = Color.green;
			selectStart = true;
			finish = tile;
			AStarPathFind.SearchPath(start, finish);
		}
	}
	
	
// 	void OnMouseDown()
//	{
//		if(!selectStart && (renderer.material.color != Color.black))
//		{
//			print ("first: " + selectStart);
//			renderer.material.color = Color.green;
//			//firstI = i;
//			//firstJ = j;
//			this.selectStart = true;
//		}
//		else if(renderer.material.color != Color.black && selectStart && !secondCube)
//		{
//			print ("2nd");			
//			renderer.material.color = Color.green;
//			//secondI = i;
//			//secondJ = j;
//			this.secondCube = true;
//		}
// 	}   
	
}
