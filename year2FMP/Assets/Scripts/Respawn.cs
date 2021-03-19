using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform Player;
    [SerializeField] private Transform RespawnPoint;
    void OnTriggerEnter2D(Collider2D collision)
    {
        Player.transform.position = RespawnPoint.transform.position;
    }
}
