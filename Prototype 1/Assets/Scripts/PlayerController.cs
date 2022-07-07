using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    private float speed = 15.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInputFirstPlayer;
    private float horizontalInputSecondPlayer;
    private float verticalInputFirstPlayer;
    private float verticalInputSecondPlayer;
   
    GameObject player1;
    GameObject player2;

    // Start is called before the first frame update
    void Awake()
    {
        player1 = GameObject.Find("FirstVehicle");
        player2 = GameObject.Find("SecondVehicle");
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        //This is where we get player input
        verticalInputFirstPlayer = Input.GetAxis("VerticalFirst");
        verticalInputSecondPlayer = Input.GetAxis("VerticalSecond");

        horizontalInputFirstPlayer = Input.GetAxis("HorizontalFirst");
        horizontalInputSecondPlayer = Input.GetAxis("HorizontalSecond");
        
        //Move the vehicle forward based on vertical input
        player1.transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInputFirstPlayer);
        player2.transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInputSecondPlayer);
        //Rotate the vehicle based on horizontal input
        player1.transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInputFirstPlayer);
        player2.transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInputSecondPlayer);

    }
}
