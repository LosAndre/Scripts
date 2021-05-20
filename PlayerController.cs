using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector2 target;


    // Update is called once per frame
    void Update()
    {
        //tracks mouse position
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(mousePos);

        //Move to mouse position along x axis on left click/ move speed
        if (Input.GetMouseButtonDown(0))
        {
            target = new Vector2(mousePos.x, transform.position.y);
        }

        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * 5f);
    }
}
