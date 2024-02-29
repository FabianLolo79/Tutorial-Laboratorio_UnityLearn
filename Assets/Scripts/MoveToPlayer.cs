using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    public GameObject player;

    public float speed = 5f;

    private Rigidbody _objectRb;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        _objectRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        FindPlayer();
    }

    void FindPlayer ()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;

        _objectRb.AddForce(lookDirection * speed);
    }
}
