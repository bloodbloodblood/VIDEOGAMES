using UnityEngine;
using System.Collections;

public class SpawnObjects : MonoBehaviour {
	
	public GameObject spawnObject;

	
	public float spawnAreaWidth;
	public float spawnAreaHeight;
	public int xTiles;
	public int yTiles;
	public int randomThreshold; 
	
	public GameObject[,] tileMap; //make 3d array later for tileheights?
	public TileProperties TileProperties;
	
	// Use this for initialization
	void Start () 
	{

		int random;
		tileMap = new GameObject[xTiles,yTiles];
		

		for(int i = 0; i < xTiles; i++)
		{
			for(int j = 0; j < yTiles; j++)
			{
				Vector3 spawnPosition = transform.position;
				spawnPosition.x += i * (spawnAreaWidth/xTiles);
				spawnPosition.y += j * (spawnAreaHeight/yTiles);
				GameObject newObject = Instantiate(spawnObject,spawnPosition,spawnObject.transform.rotation) as GameObject;
				
				//generates random grid of tiles
				random = Random.Range(0,100);
				if(random >= randomThreshold)
				{
					newObject.renderer.material.color = Color.black;	
					TileProperties = newObject.GetComponent<TileProperties>();
					TileProperties.walkable = false; //does this change only one tiles walkable or all?
				}
				else
				{
					newObject.renderer.material.color = Color.white;
					TileProperties = newObject.GetComponent<TileProperties>();
					TileProperties.walkable = true;
				}
				newObject.transform.parent = transform; //makes objects children of manager
				
				//s.i = i; //save indexes of squares
				//s.j = j;
				//newObject.GetComponent<SelectPath>().i = i;
				//newObject.GetComponent<SelectPath>().j = j;
				

				//print ("bef array i,j:"+i.ToString()+ ":" +j.ToString());

				tileMap[i,j] = newObject;;
				//print ("after array i,j:"+i.ToString()+ ":" +j.ToString());
			}
		}	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnDrawGizmos() 
	{		
		for(int i = 0; i < xTiles; i++)
		{
			for(int j = 0; j < yTiles; j++)
			{
				Vector3 spawnPosition = transform.position;
				spawnPosition.x += i * (spawnAreaWidth/xTiles);
				spawnPosition.y += j * (spawnAreaHeight/yTiles);
				Gizmos.DrawLine(spawnPosition + Vector3.left,spawnPosition + Vector3.right);
				Gizmos.DrawLine(spawnPosition + Vector3.up,spawnPosition + Vector3.down);
				Gizmos.DrawLine(spawnPosition + Vector3.forward,spawnPosition + Vector3.back);
			}
		}
	}	
}
