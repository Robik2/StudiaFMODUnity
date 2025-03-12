using System;
using FMOD.Studio;
using FMODUnity;
using UnityEngine;
using UnityEngine.UI;

public class FMODAmbience : MonoBehaviour {
    private EventInstance amb;
    [SerializeField] private Slider hpSlider;
    
    private void Start() {
        amb = AudioManager.instance.CreateInstance(FMODEvents.instance.amb);
        amb.start();
    }

    public void UpdateAmbParams() {
        amb.setParameterByName("playerHP", hpSlider.value);
        int bird = Convert.ToInt32(hpSlider.value >= 40);
        print(bird);
        amb.setParameterByName("birdAmb", bird);
    }
    
#if(UNITY_EDITOR)
    private void Update() {
        if (Input.GetKeyDown(KeyCode.C)) {
            amb.setTimelinePosition(83000);
        }
    }
#endif
}
