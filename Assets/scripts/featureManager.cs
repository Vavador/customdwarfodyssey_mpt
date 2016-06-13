using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

[ExecuteInEditMode]
public class featureManager : MonoBehaviour
{
    public List<Feature> features;
    public int currFeature;

    public void onEnable()
    {
        //LoadFeature ();
    }

    public void onDisable()
    {
        //SaveFeature ();
    }

    public void LoadFeature()
    {
        features = new List<Feature>();
        features.Add(new Feature("naine-corp", transform.FindChild("Corps").GetComponent<SpriteRenderer>()));
        features.Add(new Feature("sprite-robe", transform.FindChild("Robe").GetComponent<SpriteRenderer>()));
        features.Add(new Feature("tête", transform.FindChild("Tête").GetComponent<SpriteRenderer>()));
        int taille = features.Count;
    }

    public void SaveFeature()
    {

    }

    public void choisiChapeau()
    {
        //Feature feat;
        //feat = new Feature("sprite-accessoire-1", transform.FindChild("Accessoire").GetComponent<SpriteRenderer>());
        SpriteRenderer rend = transform.FindChild("Accessoire").GetComponent<SpriteRenderer>();
        rend.sprite = Resources.Load<Sprite>("Sprites/sprite-accessoire+blank_1");

    }

    [System.Serializable]
    public class Feature
    {
        public string ID;
        public int currIndex;
        public Sprite[] choices;
        public SpriteRenderer renderer;

        public Feature(string id, SpriteRenderer rend)
        {
            this.ID = id;
            this.renderer = rend;
            UpdateFeature();
        }

        public void UpdateFeature()
        {
            choices = Resources.LoadAll<Sprite>("Sprites/" + ID);
            if (choices == null || renderer == null)
            {
                return;
            }

            renderer.sprite = choices[currIndex];
        }



    }

}