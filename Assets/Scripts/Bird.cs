using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    Vector2 _startPos;
    [SerializeField] float launchForce = 500;
    // Start is called before the first frame update
    void Start()
    {
        _startPos = GetComponent<Rigidbody2D>().position;
        GetComponent<Rigidbody2D>().isKinematic = true;
    }
 
    void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().color = new Color(255,255,0);

    }
     void OnMouseUp()
    {
        GetComponent<Rigidbody2D>().isKinematic = false;
        Vector2 currentpos = GetComponent<Rigidbody2D>().position;
        Vector2 direction =  _startPos- currentpos;
        direction.Normalize();
        GetComponent<Rigidbody2D>().AddForce(direction*launchForce);
        GetComponent<SpriteRenderer>().color = Color.white;

    }
   
    void OnMouseDrag()
    {
        // // Vector2 position = ;
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        GetComponent<Transform>().position  = new Vector3(pos.x,pos.y,transform.position.z);
        
        
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
