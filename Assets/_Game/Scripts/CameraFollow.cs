using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float smoothSpeed = 0.125f;
    [SerializeField] private Vector3 offset;

    private void LateUpdate()
    {
        //Vector3 newOffset = offset + (new Vector3(0, 0.5f, 0) * PlayerControl.Instance.ListBrickAdd.Count);

        Vector3 desiredPosition = target.position + offset; // +newoffset
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}
