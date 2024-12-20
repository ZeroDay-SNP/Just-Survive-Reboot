using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponModPart : MonoBehaviour
{
    [field: SerializeField] private string modName;     //  the name of the mod
    [field: SerializeField] private float recoilMultiplier;     //  multiply the amount of kick
    [field: SerializeField] private float fireRateMultiplier;   //  multiply the speed of firing
    [field: SerializeField] private float accuracyMultiplier;   //  multiply the bloom spread
    [field: SerializeField] private float ammoCount;    //  set the ammo count
    [field: SerializeField] private float zoomMultiplier;   //  multiply the zoom amount
    [field: SerializeField] private float reloadMultiplier; // multiply the reload speed
    [field: SerializeField] private float equipMultiplier;  // multiply the equip speed


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
