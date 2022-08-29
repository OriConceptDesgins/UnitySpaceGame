using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipStats : MonoBehaviour
{

// Class made to store and manage the stats for all ships.
    #region Singletone
    public static ShipStats Instance { get; private set;}
    private void Awake()
    {
        if (Instance == null) 
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            Destroy(gameObject);
        }
    }
#endregion

    public readonly struct SpaceShipStats
    {
        public SpaceShipStats(float speed)
        {
            TurnSpeed = speed;
        }
        public float TurnSpeed { get; }
    }

    public SpaceShipStats PlayerShipStats { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        PlayerShipStats = new SpaceShipStats(0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
