using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCursor : MonoBehaviour
{
    float angle;

    GameObject player;
    DirectionToCursor dtc;
    Vector3 distance = new Vector3(0f, 1.25f, 0f);

    private void Start()
    {
        player = transform.parent.gameObject;
        dtc = player.GetComponent<DirectionToCursor>();
    }

    private void Update()
    {
        angle = dtc.GetAngle;

        //�@RC�̈ʒu = player�̈ʒu �{ RC�̊p�x �~�@player����̋���
        transform.position = player.transform.position + Quaternion.Euler(0f, 0f, angle) * distance;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
}
