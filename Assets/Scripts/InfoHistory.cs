using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class InfoHistory : MonoBehaviour
{
    public Text dtext;
    public Image dImage;
    // Start is called before the first frame update
   public void Display(Info obj)
    {
        dtext.text = obj.description;
        dImage.sprite = obj.artwork;
    }

}
