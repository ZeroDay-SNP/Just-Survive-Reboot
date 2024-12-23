using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class WeaponModNode : MonoBehaviour
{
    [SerializeField] private List<WeaponModPart> modOptions;
    [SerializeField] private WeaponModPart selectedPart;
    [SerializeField] private TextMeshProUGUI modTitle;
    [SerializeField] private TextMeshProUGUI modDesc;
    [SerializeField] private TextMeshProUGUI modStats;
    private bool isActive = false;
    public AudioSource audioSrc;
    public AudioClip selectSound;
    public Material activeMaterial;
    public Material inactiveMaterial;

    public WeaponModPart GetSelectedPart()
    {
        return selectedPart;
    }

    public void SetSelectedPart(string modName)
    {
        if(modName != selectedPart.GetModName())
        {
            audioSrc.PlayOneShot(selectSound);
            foreach (WeaponModPart part in modOptions)
            {
                if (part.GetModName() == modName)
                {
                    selectedPart = part;
                    break;
                }
            }
        }
    }

    public void ActivateNode()
    {
        GetComponent<Renderer>().material = activeMaterial;
        isActive = true;
    }

    public void DeactivateNode()
    {
        GetComponent<Renderer>().material = inactiveMaterial;
        isActive = false;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RefreshNode();

        if(isActive)
        {
            modTitle.text = GetSelectedPart().GetModName();
            modDesc.text = GetSelectedPart().GetModDescription();
            modStats.text = GetSelectedPart().GetModStatLines();
        }
    }

    /// <summary>
    /// Call this when a part is selected. The models will be shown and hidden according to the selection.
    /// </summary>
    public void RefreshNode()
    {
        foreach(WeaponModPart part in modOptions)
        {
            if(part != null && part == selectedPart)
            {
                part.gameObject.SetActive(true);
            }
            else
            {
                if(part != null)
                {
                    part.gameObject.SetActive(false);
                }
            }
        }
    }

    /// <summary>
    /// Getter for mod options
    /// </summary>
    /// <returns>
    /// List of possible parts
    /// </returns>
    public List<WeaponModPart> GetModOptions()
    {
        return modOptions;
    }
}
