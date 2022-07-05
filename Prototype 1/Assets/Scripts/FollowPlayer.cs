using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offsetBackView = new Vector3(0, 5, -7);
    private Vector3 offsetFirstPersonView = new Vector3(0, 2.5f, 1);
    private Vector3 offset;
    public bool isKeyPressedEvenV;
    // Start is called before the first frame update
    void Start()
    {
        offset = offsetBackView;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            setOffset();
        }
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

    void setOffset()
    {
        if (isKeyPressedEvenV)
        {
            isKeyPressedEvenV = false;
            offset = offsetBackView;
        }
        else
        {
            offset = offsetFirstPersonView;
            isKeyPressedEvenV = true;
        }
    }
}
