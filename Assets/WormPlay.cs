using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WormPlay : MonoBehaviour
{
    public Sprite[] WormmonTailGear;
    int index1;
    public Image TGimage;

    public Sprite[] WormmonPants;
    int index2;
    public Image pantsimage;

    public Sprite[] WormmonShirt;
    int index3;
    public Image shirtimage;

    public Sprite[] WormmonJacket;
    int index4;
    public Image jacketimage;

    public Sprite[] WormmonAccessory;
    int index5;
    public Image A1image;
    int index6;
    public Image A2image;
    int index7;
    public Image A3image;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        TGimage.sprite = WormmonTailGear[index1];
        pantsimage.sprite = WormmonPants[index2];
        shirtimage.sprite = WormmonShirt[index3];
        jacketimage.sprite = WormmonJacket[index4];
        A1image.sprite = WormmonAccessory[index5];
        A2image.sprite = WormmonAccessory[index6];
        A3image.sprite = WormmonAccessory[index7];
    }

    public void OnPressHigher1()
    {
        if (index1 < WormmonTailGear.Length - 1)
        {
            index1++;
        }
        else
        {
            index1 = 0;
        }
    }
    public void OnPressLower1()
    {
        if (index1 > 0)
        {
            index1--;
        }
        else
        {
            index1 = WormmonTailGear.Length - 1;
        }
    }

    public void OnPressHigher2()
    {
        if (index2 < WormmonPants.Length - 1)
        {
            index2++;
        }
        else
        {
            index2 = 0;
        }
    }
    public void OnPressLower2()
    {
        if (index2 > 0)
        {
            index2--;
        }
        else
        {
            index2 = WormmonPants.Length - 1;
        }
    }

    public void OnPressHigher3()
    {
        if (index3 < WormmonShirt.Length - 1)
        {
            index3++;
        }
        else
        {
            index3 = 0;
        }
    }
    public void OnPressLower3()
    {
        if (index3 > 0)
        {
            index3--;
        }
        else
        {
            index3 = WormmonShirt.Length - 1;
        }
    }

    public void OnPressHigher4()
    {
        if (index4 < WormmonJacket.Length - 1)
        {
            index4++;
        }
        else
        {
            index4 = 0;
        }
    }
    public void OnPressLower4()
    {
        if (index4 > 0)
        {
            index4--;
        }
        else
        {
            index4 = WormmonJacket.Length - 1;
        }
    }

    public void OnPressHigher5()
    {
        if (index5 < WormmonAccessory.Length - 1)
        {
            index5++;
        }
        else
        {
            index5 = 0;
        }
    }
    public void OnPressLower5()
    {
        if (index5 > 0)
        {
            index5--;
        }
        else
        {
            index5 = WormmonAccessory.Length - 1;
        }
    }

    public void OnPressHigher6()
    {
        if (index6 < WormmonAccessory.Length - 1)
        {
            index6++;
        }
        else
        {
            index6 = 0;
        }
    }
    public void OnPressLower6()
    {
        if (index6 > 0)
        {
            index6--;
        }
        else
        {
            index6 = WormmonAccessory.Length - 1;
        }
    }
    public void OnPressHigher7()
    {
        if (index7 < WormmonAccessory.Length - 1)
        {
            index7++;
        }
        else
        {
            index7 = 0;
        }
    }
    public void OnPressLower7()
    {
        if (index7 > 0)
        {
            index7--;
        }
        else
        {
            index7 = WormmonAccessory.Length - 1;
        }
    }
}

