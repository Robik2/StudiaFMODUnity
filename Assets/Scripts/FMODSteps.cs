using System.Collections.Generic;
using FMOD.Studio;
using UnityEngine;
using UnityEngine.UI;

public class FMODSteps : MonoBehaviour {
    [SerializeField] private LayerMask whatIsGround;
    [SerializeField] private Slider hpSlider;
    private readonly List<string> tags = new List<string> { "stone", "wood" };
    private float lastTimePlayed;
    
    public void PlayStepSound() {
        if (Time.time - lastTimePlayed < .2f) { return; }

        EventInstance eventInstance = AudioManager.instance.CreateInstance(FMODEvents.instance.steps, gameObject, GetComponent<Rigidbody2D>());
        eventInstance.setParameterByName("surface", CheckSurface());
        eventInstance.setParameterByName("ambController", hpSlider.value);
        eventInstance.start(); 
        eventInstance.release();
        lastTimePlayed = Time.time;
    }

    private int CheckSurface() {
        Collider2D hit = Physics2D.OverlapBox(transform.position, new Vector2(0.1f, 0.1f), 0, whatIsGround);
        return hit == null ? 0 : tags.IndexOf(hit.tag);
    }
}
