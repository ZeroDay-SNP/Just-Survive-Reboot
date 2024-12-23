using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponModPart : MonoBehaviour
{
    [field: SerializeField] private string modName;     //  the name of the mod
    [field: SerializeField] private string modDesc;     //  the description of the mod
    [field: SerializeField] private float recoilMultiplier;     //  multiply the amount of kick
    [field: SerializeField] private float fireRateMultiplier;   //  multiply the speed of firing
    [field: SerializeField] private float accuracyMultiplier;   //  multiply the bloom spread
    [field: SerializeField] private float ammoCount;    //  set the ammo count
    [field: SerializeField] private float zoomMultiplier;   //  multiply the zoom amount
    [field: SerializeField] private float reloadMultiplier; // multiply the reload speed
    [field: SerializeField] private float equipMultiplier;  // multiply the equip speed


    public string GetModName()
    {
        return modName;
    }

    public string GetModDescription()
    {
        return modDesc;
    }

    public string GetModStatLines()
    {
        return 
            $"{"Fire Rate",-15} - {fireRateMultiplier.ToString("F2")+"x", 10}\n" +
            $"{"Accuracy",-15} - {accuracyMultiplier.ToString("F2") + "x", 10}\n" +
            $"{"Recoil",-15} - {recoilMultiplier.ToString("F2") + "x", 10}\n" +
            $"{"Ammo",-15} - {ammoCount, 10}\n" +
            $"{"Reload Speed",-15} - {reloadMultiplier.ToString("F2") + "x", 10}\n" +
            $"{"Zoom",-15} - {zoomMultiplier.ToString("F2") + "x", 10}\n" +
            $"{"Equip Speed",-15} - {equipMultiplier.ToString("F2") + "x", 10}\n";
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
