using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseClick : MonoBehaviour
{
    public Vector3 telePosition;
    public GameObject Player;
    void OnMouseDown()
        {
            Input.GetMouseButtonDown(0);
            {
                Player.transform.position = telePosition;
        }
    }
}
