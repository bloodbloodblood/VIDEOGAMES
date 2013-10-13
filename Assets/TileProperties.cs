using UnityEngine;
using System.Collections;

//need to attach these to cubes to respond to clicks and 
public class TileProperties : MonoBehaviour 
{
	public SelectPath SelectPath;
	
    public int cost;
    public int heuristic;
    public int total;
    public bool walkable;
	
	// Use this for initialization
	void Start () 
	{
		SelectPath = gameObject.AddComponent<SelectPath>();
		cost = 0;
		heuristic = 0;
		total = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
	
 	void OnMouseDown() //when this cube is pressed on, execute this
	{
		if(gameObject.renderer.material.color !=  Color.black)
		{
			SelectPath.pathSet(gameObject);
		}
 	}  
}
