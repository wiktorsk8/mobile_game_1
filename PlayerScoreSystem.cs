using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreSystem : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] private int maxFat;
    [SerializeField] private int currentFat;

    [SerializeField] GameObject leftLeg;
    [SerializeField] GameObject rightLeg;
    [SerializeField] GameObject spine;

    [SerializeField] public Text txt;

    [SerializeField] float growth = 10f;

    int gateValue;
    

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("dupa");

        if (other.tag == "GATE") gateValue = other.GetComponent<GateConfig>().FAT_LEVEL;

        currentFat += gateValue;

        if(other.tag == "RING")
        {
            if(currentFat > 300)
            {

            }
        }
      

    }

    private void Update()
    {
        //txt.text = "FAT LEVEL: " + currentFat.ToString();

        if (currentFat <= 100)
        {
            currentFat = 100;
        }

        if (currentFat >= maxFat)
        {
            currentFat = maxFat;
        }
    }

    private void FixedUpdate()
    {
        if (currentFat % 20 == 0)
        {
            int multiplier = (currentFat + 100) / 20;

            leftLeg.transform.localScale = new Vector3(1 + (multiplier * growth) / 100f, 1f, 1 + (multiplier * growth) / 100f);
            rightLeg.transform.localScale = new Vector3(1 + (multiplier * growth) / 100f, 1f, 1 + (multiplier * growth) / 100f);
            spine.transform.localScale = new Vector3(1 + (multiplier * growth) / 150f, 1f, 1 + (multiplier * growth) / 150f);
        }
    }



}
