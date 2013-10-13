using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//implements the A* pathfinding algorithm
public class AStarPathFind : MonoBehaviour 
{
	private GameObject start, finish, current;
	
	List<GameObject> closedList = new List<GameObject>();
	List<GameObject> openList = new List<GameObject>();
	
	private TileProperties TileProperties;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void SearchPath(GameObject start, GameObject finish)
	{
		this.start = start;
		this.finish = finish;
		
		bool canSearch = true;
		if(start.renderer.material.color == Color.black) // check if start tile is invalid to walk
		{
			canSearch = false;
		}
		if(start.renderer.material.color == Color.black) // check if end tile is invalid to walk
		{
			canSearch = false;
		}
		
		//start A* algorithm
		if(canSearch)
		{
			openList.Add(start);
			current = Instantiate(start) as GameObject; //init current
			
			while(openList.Count != 0)
			{
				current = GetTileWithLowestTotal(openList);	//ended off here
			}
		}
	}
	
	
	public GameObject GetTileWithLowestTotal(List<GameObject> openList)
	{
		//temp var
		GameObject tileWithLowestTotal = Instantiate(start) as GameObject;
		int lowestTotal = int.MaxValue;
		
		//search all open tiles and get the tile with the lowest total cost
		foreach( GameObject openTile in openList)
		{
			if(openTile.GetComponent<TileProperties>().cost <= lowestTotal)
			{
				lowestTotal = openTile.GetComponent<TileProperties>().cost;
				tileWithLowestTotal = openTile;
			}
		}
		return tileWithLowestTotal;
	}
}
