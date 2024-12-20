using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponModPart : MonoBehaviour
{
    [field: SerializeField] private float recoilMultiplier { get; }     //  multiply the amount of kick
    [field: SerializeField] private float fireRateMultiplier { get; }   //  multiply the speed of firing
    [field: SerializeField] private float accuracyMultiplier { get; }   //  multiply the bloom spread
    [field: SerializeField] private float ammoCount { get; }    //  set the ammo count
    [field: SerializeField] private float zoomMultiplier { get; }   //  multiply the zoom amount
    [field: SerializeField] private float reloadMultiplier { get; } // multiply the reload speed
    [field: SerializeField] private float equipMultiplier { get; }  // multiply the equip speed


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
