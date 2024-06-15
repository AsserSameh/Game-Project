using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Player;

    private Vector3 offset = new Vector3(0, 5, -12);

    // Start is called before the first frame update
    void Start()
    {
        
    }
  
    void LateUpdate()
    {
        transform.position = Player.transform.position + offset;
    }
}
