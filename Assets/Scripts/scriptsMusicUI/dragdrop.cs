using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

public class dragdrop : MonoBehaviour
{
    public Vector3 startpos;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();//set rigidbody
    }
    void OnMouseDrag()//drag object
    {
        Vector3 position = GetPos();
        transform.position = position;
        rb.MovePosition(position);
    }
    private void OnMouseUp()//return to starting position
    {
        gameObject.transform.position = startpos;
        rb.MovePosition(startpos);
    }

    private Vector3 GetPos()//get new position 
    {
        Vector3 mouse_adj = Input.mousePosition;
        mouse_adj.z = 880f;
        return Camera.main.ScreenToWorldPoint(mouse_adj);
    }
}
