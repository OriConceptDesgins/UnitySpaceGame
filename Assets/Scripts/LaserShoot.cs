using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserShoot : MonoBehaviour  //Make abstract class later if I decide to make more weapon types.
{
    [SerializeField]
    private GameObject spaceCraft; // The ship this particular laser belongs to
    [SerializeField]
    private GameObject target; // Implement select target at ship controller
    
    
    LineRenderer laser;
    private const int lineRenderPositions = 2;
    private const int hardpointNumber = 1;   // the weapon group number this  laser responds to.
    private const int angleThreshhold = 30;
    public int LaserHeat { get; private set; }

    private SpacehipController spaceShipController;

    private bool isLaserOn; // huh? why do I want to know if its on? for heat? I don't remember

    void Start()
    {
        laser = GetComponent<LineRenderer>();
        laser.enabled = false;
        spaceShipController = spaceCraft.GetComponent<SpacehipController>();   // gets this specific instance of shipController object
    }


    void Update()
    {

        // Get shoot controls.

        if (spaceShipController.Weapons[hardpointNumber]) 
        { 
            if(spaceShipController.Target is not null)  // could have done with Event but Do I really need event for that? less code here but more code there. Same amount of code really , possibly with slower execution.
            {
                //shootlaser()   
            }
        }
    }

    private void IsTargetInRange(Vector3 target) 
    {
        /// Draw a vector from origin to target. According to test in my VectorLab project.
        /// 
        ///if Dot product of the two vectors is within tolerance, shoot the lasers.
        ///
        Vector3 forewardVector = transform.forward; //suppousedly its with rotation but we will see
        Vector3 vectorCalculation = forewardVector + target; // Vector from origin to target
        Debug.DrawLine(forewardVector, forewardVector * 100, Color.red) ;
        Debug.DrawRay(forewardVector, vectorCalculation , Color.green);
        if (Vector3.Angle(forewardVector, vectorCalculation) <= angleThreshhold)
        {
            Vector3[] positions = new Vector3[lineRenderPositions] {forewardVector, vectorCalculation};
            ShootLaser(positions); // need to find out if it collided with other objects using a raycast so might do that.
        }
        

        // Could move this to the Ship controller instead. for future modularity since target would be used in other scripts
    }
    
    private void ShootLaser(Vector3[] positionArray) 
    {
        laser.enabled = true;
        laser.SetPositions(positionArray);
    }

    //todo coroutine timer.

}
