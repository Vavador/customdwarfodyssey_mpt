using UnityEngine;
using Assets;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class Dworf : MonoBehaviour {

    //attributs

    public string nom;
    public string description;
    public int beauty;
    public int drunkness;
    public int mood;
    public int energy;
    public int money;
    public Text dayText;
    public int globalScore;
    public int day = 1;
    public AudioClip ouch;

    public float timeLeft = 600.0f;
    public Text buyedTEXT;


    //UI
    public Text statsTEXT;
    public Text drinkText;
    public GameObject youEatPANEL;
    public GameObject noEatPANEL;
    public GameObject barPANEL;
    public GameObject workPANEL;
    public GameObject descriptionPANEL;
    public GameObject sportPANEL;
    public GameObject actionPANEL;
    public GameObject tutorielPANEL;
    public GameObject shopPANEL;


    //constructeur
    public Dworf ()
    { }

    public Dworf(string unNom, string uneDescription, int aBeauty, int aDrunkness, int aMood)
    {
        this.nom = unNom;
        this.description = uneDescription;
        this.beauty = aBeauty;
        this.drunkness = aDrunkness;
        this.mood = aMood;
        this.energy = 100;
        this.money = 0;
    }

    //methodes
    public int toBuy(int objet)
    {
        if (this.money - objet >= 0)
        {
            this.money = this.money - objet;
            return 0;
        }
        else
        {
            return 1;
        }
    }

    public int testMoney(int cost)
    {
        if (this.money - cost >= 0)
        {
            
            return 0;
        }
        else
        {
            Debug.Log("Va bosser sale pauvre");
            return 1;
        }
    }

    public int testEnergy(int energyCost)
    {
        if (this.energy - energyCost >= 0)
        {
            //this.energy = this.energy - energyCost;
            return 0;
        }
        else
        {
            Debug.Log("Too Bad Energy");
            return 1;
        }
    }

   /* public int testDrunkness(int drunk)
    {
        if (this.drunkness - drunk >= 0)
        {
            
            return 0;
        }
        else
        {
            Debug.Log("T'es trop bourrÃ©e ma grosse");
            return 1;
        }
    }*/
    public void toGoDrink()
    {
        actionPANEL.SetActive(false);
        barPANEL.SetActive(true);
    }
    public void toGoWork()
    {
        actionPANEL.SetActive(false);
        workPANEL.SetActive(true);
    }
    public void toDrink()
    {
        drinkText.text = "";
                if (toBuy(10) == 0)
                {
                drinkText.text = "Ta encore bu comme une pochtronne";
                    Debug.Log(statsTEXT.text);
                    if (this.beauty >= 5)
                    {
                        this.beauty = this.beauty - 5;
                    }
                    else
                    {
                        this.beauty = 0;
                    }
                    if (this.drunkness <= 80)
                    {
                        this.drunkness = this.drunkness + 20;
                    }
                    else
                    {
                        this.drunkness = 100;
                    }
                    if (this.mood <= 70)
                    {
                        this.mood = this.mood + 30;
                    }
                    else
                    {
                        this.mood = 100;
                    }
                    if (this.drunkness >= 50)
            {
                drinkText.text = "T'a trop bu rentre chez toi";
            }
                   
                    UpdateStats();
                }
                else
                {
                   //pas d'argent
                            // ajouter message
                drinkText.text = "Pas d'argent casse toi morue !";
            }
        
               
    }


    public void toDress1()
    {
        if (testMoney(50) == 0)
        {
            Debug.Log("habillÃ©");
            if (this.mood <= 95)
            {
                this.mood = this.mood + 5;
            }
            else
            {
                this.mood = 100;
            }
            if (this.beauty <= 75)
            {
                this.beauty = this.beauty + 15;
            }
            else
            {
                this.mood = 100;
            }
            this.money -= 50;
            UpdateStats();
        }
        else
        {
            Debug.Log("pas habillÃ©");

            buyedTEXT.text = "Vous n'avez pas d'argent va bosser sale feignasse !";
            //ajouter popup
        }
    }
    public void toDress2()
    {
        if (testMoney(100) == 0)
        {
            Debug.Log("habillÃ©");
            this.money -= 100;
            if (this.mood <= 90)
            {
                this.mood = this.mood + 10;
            }
            else
            {
                this.mood = 100;
            }
            if (this.beauty <= 80)
            {
                this.beauty = this.beauty + 20;
            }
            else
            {
                this.beauty = 100;
            }
            UpdateStats();
        }
        else
        {
            Debug.Log("pas habillÃ©");

            buyedTEXT.text = "T'as pas d'argent va bosser sale feignasse";
            //ajouter popup
        }
    }

    public void toDress3()
    {
        if (testMoney(200) == 0)
        {
            Debug.Log("habillÃ©");
            this.money -= 200;
            if (this.mood <= 90)
            {
                this.mood = this.mood + 10;
            }
            else
            {
                this.mood = 100;
            }
            if (this.beauty <= 80)
            {
                this.beauty = this.beauty + 20;
            }
            else
            {
                this.beauty = 100;
            }
            if (this.drunkness >= 5)
            {
                this.drunkness = this.drunkness - 5;
            }
            else
            {
                this.mood = 100;
            }
            UpdateStats();
        }
        else
        {
            Debug.Log("pas habillÃ©");

            buyedTEXT.text = "T'as pas d'argent va bosser sale feignasse";
            //ajouter popup
        }
    }

    public void toHat1()
    {
        if (testMoney(100) == 0)
        {
            Debug.Log("habillÃ©");
            this.money -= 100;
            buyedTEXT.text = "Merci pour votre achat";
            Debug.Log(buyedTEXT);
            if (this.mood <= 90)
            {
                this.mood = this.mood + 10;
            }
            else
            {
                this.mood = 100;
            }
            if (this.beauty <= 90)
            {
                this.beauty = this.beauty + 10;
            }
            else
            {
                this.beauty = 100;
            }
            UpdateStats();
        }
        else
        {
            Debug.Log("pas habillÃ©");
            
            buyedTEXT.text = "T'as pas d'argent va bosser sale feignasse";
            //ajouter popup
        }
    }

    public void toHat2()
    {
        if (testMoney(150) == 0)
        {
            buyedTEXT.text = "Merci pour votre achat";
            if (this.mood <= 90)
            {
                this.mood = this.mood + 10;
            }
            else
            {
                this.mood = 100;
            }
            if (this.beauty <= 85)
            {
                this.beauty = this.beauty + 15;
            }
            else
            {
                this.beauty = 100;
            }
            if (this.drunkness <= 95)
            {
                this.drunkness = this.drunkness + 5;
            }
            else
            {
                this.drunkness = 100;
            }
            UpdateStats();
        }
        else
        {
            Debug.Log("pas habillÃ©");

            buyedTEXT.text = "T'as pas d'argent va bosser sale feignasse";
            //ajouter popup
        }
    }

    public void toHat3()
    {
        if (testMoney(200) == 0)
        {
            Debug.Log("habillÃ©");
            this.money -= 200;
            this.drunkness -= 10;
            if (this.mood <= 85)
            {
                this.mood = this.mood + 15;
            }
            else
            {
                this.mood = 100;
            }
            if (this.beauty <= 85)
            {
                this.beauty = this.beauty + 15;
            }
            else
            {
                this.beauty = 100;
            }
            if (this.drunkness >= 10)
            {
                this.drunkness = this.drunkness - 10;
            }
            else
            {
                this.drunkness = 0;
            }
            UpdateStats();
        }
        else
        {
            Debug.Log("pas habillÃ©");

            buyedTEXT.text = "T'as pas d'argent allez bosser sale feignasse";
            //ajouter popup
        }
    }









    /*
    public void toDress(Clothes aCloth)
    {
        if (testEnergy(aCloth.energyCost) == 0)
        {
            if (toBuy(aCloth) == 0)
            {
                this.beauty = this.beauty + aCloth.beauty;
                this.drunkness = this.drunkness + aCloth.drunkness;
                this.mood = this.mood + aCloth.mood;
                this.energy = this.energy - aCloth.energyCost;
            }
            else
            {
                return; //pas d'argent
                //ajouter message
            }
        }
        else
        {
            return; //pas d'Ã©nergie
            //ajouter message
        }
    } */



    public void toWork()
    {
        if (testEnergy(25) == 0)
        {
            
            Debug.Log("Energy is ok");
            this.money = this.money + 250;
            this.energy = this.energy - 25;

            if (this.mood >= 5)
            {
                this.mood = this.mood - 5;
            }
            else
            {
                this.mood = 0;
            }
            Debug.Log(energy);
            UpdateStats();
        }
        else
        {
            
        }
    }
    public void toGoSport()
    {
        actionPANEL.SetActive(false);
        sportPANEL.SetActive(true);



}
    public void toSport()
    {
        if (testEnergy(30) == 0)
        {
            this.energy = this.energy - 30;
            if (this.beauty <= 80)
            {
                this.beauty = this.beauty + 20;
            }
            else
            {
                this.beauty = 100;
            }

            if (this.drunkness >= 10)
            {
                this.drunkness = this.drunkness - 10;
            }
            else
            {
                this.drunkness = 0;
            }

            if (this.mood >= 5)
            {
                this.mood = this.mood - 5;
            }
            else
            {
                mood = 0;
            }
            UpdateStats();
        }
        else
        {
            return; //pas d'Ã©nergie
            //ajouter message
        }
    }

    public void toHit()
    {
      if(this.mood >= 10)
        {
            this.mood = this.mood - 10;
        }
      else
        {
            this.mood = 0;
        }
            if(this.beauty >= 5)
        {
            this.beauty = this.beauty - 5;
        }
            else
        {
            this.beauty = 0;
        }
            Debug.Log("You're hitted bitch");
            UpdateStats();
            GetComponent<AudioSource>().clip = ouch;
            GetComponent<AudioSource>().Play();

    }

    public void toEat()
    {
        if (testMoney(100) == 0)
        {
            Debug.Log("Eat bitch");
            if (this.beauty >= 5)
            {
                this.beauty = this.beauty - 5;
            }
            else
            {
                this.beauty = 0;
            }

            if (this.mood <= 80)
            {
                this.mood = this.mood + 20;
            }
            else
            {
                this.mood = 100;
            }//drunkness -15
            if (this.drunkness >= 15)
            {
                this.drunkness = this.drunkness - 15;
            }
            else
            {
                this.drunkness = 0;
            }//drunkness -15
            if (this.energy <= 80)
            {
                this.energy = this.energy + 20;
            }
            else
            {
                this.energy = 100;
            }

            this.money -= 100;
            youEatPANEL.SetActive(true);
            UpdateStats();
        }
        else
        {
            Debug.Log("T'as pas de fric tu peux pas bouffer va bosser feignasse !");

            noEatPANEL.SetActive(true);
            //ajouter popup
        }
    }


    public void toDress()
    {
        Clothes nCloth = new Clothes("Robe de divorcÃ©e", "La premiÃ¨re robe du reste de ta vie", 30, 0, 20, 15, 0);
        if (testMoney(nCloth.cost) == 0)
        {
            Debug.Log("habillÃ©");
            this.money -= nCloth.cost;
            this.mood += nCloth.mood;
            this.beauty += nCloth.beauty;
            this.energy -= nCloth.energyCost;
            UpdateStats();
        }
        else
        {
            Debug.Log("pas habillÃ©");
            return; //pas d'argent
            //ajouter popup
        }
    }

    public void openDoor()
    {

    }

    // Use this for initialization
    void Start () {
        quitPanel();
        descriptionPANEL.SetActive(true);
        UpdateStats();
        buyedTEXT.text = "";
       

    }
	
	// Update is called once per frame
	void Update () {
        if(this.mood<=10)
        {
            toDrink();
        }
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            goToPaegent();
        }

    }
    void UpdateStats()
    {
        statsTEXT.text = "Beauté: " + "\n" + beauty + "\n" + "Ebriété: " + "\n" + drunkness + "\n" + "Humeur: " + "\n" + mood + "\n" + "Energie:" + "\n" + energy + "\n" + "Argent: " + money;
    }

    public void EndOfTheDay()
    {
        if(energy <= 0)
        {
            day = day + 1;
            dayText.text = day.ToString();
        }
        if (day >= 3)
        {
            SceneManager.LoadScene("missPaegent");
        }
    }
    public void openActions()
    {
        actionPANEL.SetActive(true);
    }
    public void quitPanel()
    {
        noEatPANEL.SetActive(false);
        youEatPANEL.SetActive(false);
        barPANEL.SetActive(false);
        workPANEL.SetActive(false);
        descriptionPANEL.SetActive(false);
        sportPANEL.SetActive(false);
        actionPANEL.SetActive(false);
        tutorielPANEL.SetActive(false);
        shopPANEL.SetActive(false);

}
    public void goToPaegent()
    {
        globalScore = (this.beauty + this.mood + this.energy) - this.drunkness;
        Debug.Log(globalScore);
        PlayerPrefs.SetInt("globalScore", globalScore);
        
        SceneManager.LoadScene("paegentScene");
    }
    public void toSleep()
    {
        if (this.mood <= 85)
        {
            this.mood = this.mood + 15;
        }
        else
        {
            this.mood = 100;
        }
        if (this.energy <= 50)
        {
            this.energy = this.energy + 50;
        }
        else
        {
            this.energy = 100;
        }
        if (this.drunkness >= 10)
        {
            this.drunkness = this.drunkness - 10;
        }
        else
        {
            this.drunkness = 0;
        }
        UpdateStats();
    }
    public void tutorial()
    {
        tutorielPANEL.SetActive(true);
    }

    public void openShop()
    {
        shopPANEL.SetActive(true);
    }
}

