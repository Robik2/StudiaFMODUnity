using FMOD.Studio;
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
        amb.setParameterByName("ambController", hpSlider.value);
    }
}
