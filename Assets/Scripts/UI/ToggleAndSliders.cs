using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ToggleAndSliders : MonoBehaviour
{
    public Slider MusicSlider;
	public Slider EffectsSlider;
    public Toggle MusicToggle;
    
    void Update()
    {
		if (MusicToggle.isOn==false)
		{
			AudioManager.instance.SetVolume("MenuMusic",0);
		}
		else
		{
			AudioManager.instance.SetVolume("MenuMusic",MusicSlider.value);
		}
		
		AudioManager.instance.SetVolume("MenuSelect",EffectsSlider.value);
        AudioManager.instance.SetVolume("MenuHover",EffectsSlider.value);

        print(MusicToggle.isOn);
    }
    
}
