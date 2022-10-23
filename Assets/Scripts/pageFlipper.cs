using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pageFlipper : MonoBehaviour
{
    public pageManager pM;
    public pageNumber pN;
    public Animator flipper;
    GameObject flipPage;
    
    // Start is called before the first frame update
    void Start()
    {
        flipper = GetComponent<Animator>();
    }

    public void FlipPage(int currentPage)
    {
        flipPage = GameObject.Find("Page " + (currentPage - 1));
        if(flipPage.name == "Page 0")
        {
            flipPage.GetComponent<Animator>().Play("Cover Flip");
        }
        else
        {
            flipPage.GetComponent<Animator>().Play("Page Flip");
        }
    }
}
