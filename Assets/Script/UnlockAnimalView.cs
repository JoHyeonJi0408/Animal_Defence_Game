using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class UnlockAnimalView : MonoBehaviour
{
    public GameObject unlockAnimalView;
    public Image AnimalImage;
    public Text subTextB;
    public Text subTextW;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            unlockAnimalView.SetActive(false);
        }
    }

    public void setImageAndText(int index)
    {
        var missionData = DataManager.GetInstance().GetData<MissionData>(index);
        subTextB.text = "새로운 동물 " + missionData.animal_name + " 해금!";
        subTextW.text = subTextB.text;
        AnimalImage.sprite = Resources.Load<Sprite>(string.Format("Animals/{0}", missionData.animal_sprite_name));
        //var result = Array.Exists(AnimalArr.AnimalArray,i => i.Equals(missionData.animal_sprite_name));
        if (!AnimalArr.AnimalArray.Contains("missionData.animal_sprite_name"))
        {
            AnimalArr.animalArrayString = string.Format("{0},{1}", AnimalArr.animalArrayString, missionData.animal_sprite_name);
            PlayerPrefs.SetString("AnimalArray", AnimalArr.animalArrayString);
            PlayerPrefs.Save();
            AnimalArr.callAnimalArr();
        }
    }



}
