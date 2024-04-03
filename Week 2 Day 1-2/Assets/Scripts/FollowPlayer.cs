using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour

{
    public GameObject Player;// Created component to add Player to script.
    public Vector3 thirdPersonOffset = new Vector3(0, 8, -10);
    public Vector3 firstPersonOffset;
    private Vector3 currentOffset;
    private bool isfirstPerson = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (isfirstPerson) currentOffset = Player.transform.position + firstPersonOffset;
        else currentOffset = Player.transform.position + thirdPersonOffset;

        if (Input.GetMouseButtonDown(0))
        {
            if (!isfirstPerson) isfirstPerson = true;
            else isfirstPerson = false;
        }


        transform.position = currentOffset;

    }
}