using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class CongratScript : MonoBehaviour
{
    public TextMesh Text;
    public ParticleSystem SparksParticles;
    
    public List<string> TextToDisplay;
    
    private float RotatingSpeed;
    private float TimeToNextText;

    private int CurrentText;
    
    // Start is called before the first frame update
    void Start()
    {
        TimeToNextText = 0.0f;
        CurrentText = 0;
        
        RotatingSpeed = 50.0f;

        TextToDisplay.Add("Congratulations");
        TextToDisplay.Add("All Errors Fixed");

        Text.text = TextToDisplay[0];

        SparksParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        TimeToNextText += Time.deltaTime;

        if (TimeToNextText > 1.5f)
        {
            TimeToNextText = 0.0f;
            
            CurrentText++;
            if (CurrentText >= TextToDisplay.Count)
            {
                CurrentText = 0;


            Text.text = TextToDisplay[CurrentText];
             }
           
        }
        SparksParticles.transform.RotateAround(Text.transform.position, Vector3.up, Time.deltaTime * RotatingSpeed);
    }
}