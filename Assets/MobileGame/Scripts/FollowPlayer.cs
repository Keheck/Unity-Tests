using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    private GameManager manager;

    private void Start()
    {
        manager = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        if(!manager.HasEnded)
            transform.position = player.position + offset;
    }
}
