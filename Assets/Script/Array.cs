using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour

{
    public int width;
    public int height;
    public GameObject BackgroudTile;
    private Square[,] squares;
    public List<GameObject> objects;
    // Start is called before the first frame update
    void Start()
    {
        
        squares = new Square[width, height];
        
        SetUp();
       
    }

    private void Update()
    {
    
    }
    private void SetUp()
    {
        for (int i = 0; i < 1; i++)
        {
            for (int j = -3; j < 4; j++)
            {
                Vector3 tempPosition = new Vector3(j,0.2f,-7);
                
                
                GameObject squares =  Instantiate(BackgroudTile, tempPosition, Quaternion.Euler(90,0,0)) as GameObject;
                squares.transform.parent = this.transform;
                squares.transform.localScale = new Vector3(5.2f, 5.2f, 5.2f);
                squares.name = "(" + i + "," + j + ")";
            }
        }
    }

    
}
