using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    
    private Rigidbody rigid;
    private CapsuleCollider collider;
    private List<GameObject> array;
    private int row;

  
    void Start()
    {
        collider = GetComponent<CapsuleCollider>();
        rigid = GetComponent<Rigidbody>();
        array = GameObject.FindObjectOfType<Array>().objects;
 
        row = (int)transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {


        
            GameObject left = array[row-1];
            GameObject right = array[row+1];


            if (left.tag == this.gameObject.tag && right.tag == this.gameObject.tag)
            {
                DestroyObject(left);
                DestroyObject(array[row].gameObject);
                DestroyObject(right);

  
                array.Remove(left);
                array.RemoveAt((int)array[row].transform.position.x+1);
                array.Remove(right);

                
                

                for (int i = (int)left.GetComponent<Transform>().position.x; i < (int)right.GetComponent<Transform>().position.x; i++)
                {

                    GameObject square = GameObject.Find("(" + 0 + "," + i + ")");

                    if (square.GetComponent<Square>().isNEmpty == true)
                    {
                        square.GetComponent<Square>().isNEmpty = false;
                    }

                }
            ScoreManager.count += 1;
        }

        

    }


    private void OnMouseDown()
    {

        this.gameObject.transform.localScale = new Vector3(-0.5f, -0.5f, -0.5f);

        for(int i  = -3; i < 4; i++)
        {
            GameObject square = GameObject.Find("(" + 0 + "," + i + ")");

            if(square.GetComponent<Square>().isNEmpty == false)
            {
                Vector3 tempPosition = new Vector3(i, 0.1f, -7);
                this.gameObject.transform.position = square.GetComponent<Square>().transform.position;
                
                array.Add(this.gameObject);

                break;
            }
            
            
        }

    }


    

}
