using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //configuration paramaters;
    [SerializeField] float screenWidthinUnits = 16f;
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePosIntUnits = Input.mousePosition.x / Screen.width * screenWidthinUnits;
        Vector2 paddlePos = new Vector2(transform.position.x, transform.position.y) ;
        paddlePos.x = Mathf.Clamp(mousePosIntUnits, minX, maxX);
        transform.position = paddlePos;
    }
}
