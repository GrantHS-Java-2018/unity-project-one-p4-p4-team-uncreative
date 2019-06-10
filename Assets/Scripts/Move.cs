using UnityEngine;

public class Move : MonoBehaviour { //moves the character icon to each waypoint

    public Transform[] waypoints;

    [SerializeField]
    private float moveSpeed = 1f;//speed at which icon moves

    [HideInInspector]
    public int waypointIndex = 0;

    public bool moveAllowed = false;//automatically sets the movement to not happen at first 

    // Use this for initialization
    private void Start () {
        transform.position = waypoints[waypointIndex].transform.position; //initializes the waypoints
    }
	
    // Update is called once per frame
    private void Update () {
        if (moveAllowed)
            FollowThePath(); //follows path of waypoints once it is allowed to move
    }

    private void FollowThePath()
    {
        if (waypointIndex <= waypoints.Length - 1) //to compensate with index naming convention which starts at 0
        {
            transform.position = Vector2.MoveTowards(transform.position, //stuff that makes movement work correctly
                waypoints[waypointIndex].transform.position,
                moveSpeed * Time.deltaTime);

            if (transform.position == waypoints[waypointIndex].transform.position)
            {
                waypointIndex += 1;
            }
        }
    }
} 