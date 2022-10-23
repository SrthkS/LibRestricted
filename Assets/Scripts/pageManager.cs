using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class pageManager : MonoBehaviour
{
    public GameObject page;
    public GameObject deletionPage;
    public pageFlipper pF;
    public pageNumber pN;
    public TKAB tkab;
    public code1984 c1984;
    public Quran quran;
    public Bible bible;
    public Rigveda rigveda;
    GameObject newPage;
    public int currentPage;
    public TextMeshProUGUI pageText;

    // Start is called before the first frame update
    void Start()
    {
        currentPage = 0;
        tkab.pullBooks();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("k"))
        {
            currentPage++;
            SpawnPage(currentPage);
            pF.FlipPage(currentPage);
            RemovePage(currentPage);
        }

    }

    void SpawnPage(int currentPage)
    {
        Scene scene = SceneManager.GetActiveScene();
        if(scene.name == "TKAB")
        {
            newPage = Instantiate(page, Vector3.zero, Quaternion.identity) as GameObject;
            newPage.name = "Page " + currentPage;
            newPage.GetComponent<pageNumber>().pageNum = currentPage;
            Debug.Log(tkab.bookPages[currentPage - 1]);
            pageText = newPage.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>();
            pageText.text = tkab.bookPages[currentPage - 1].ToString();
        }
        if(scene.name == "1984")
        {
            newPage = Instantiate(page, Vector3.zero, Quaternion.identity) as GameObject;
            newPage.name = "Page " + currentPage;
            newPage.GetComponent<pageNumber>().pageNum = currentPage;
            Debug.Log(c1984.bookPages[currentPage - 1]);
            pageText = newPage.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>();
            pageText.text = tkab.bookPages[currentPage - 1].ToString();
        }
        if(scene.name == "Bible")
        {
            newPage = Instantiate(page, Vector3.zero, Quaternion.identity) as GameObject;
            newPage.name = "Page " + currentPage;
            newPage.GetComponent<pageNumber>().pageNum = currentPage;
            Debug.Log(bible.bookPages[currentPage - 1]);
            pageText = newPage.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>();
            pageText.text = tkab.bookPages[currentPage - 1].ToString();
        }
        if(scene.name == "Quran")
        {
            newPage = Instantiate(page, Vector3.zero, Quaternion.identity) as GameObject;
            newPage.name = "Page " + currentPage;
            newPage.GetComponent<pageNumber>().pageNum = currentPage;
            Debug.Log(quran.bookPages[currentPage - 1]);
            pageText = newPage.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>();
            pageText.text = tkab.bookPages[currentPage - 1].ToString();
        }
        if(scene.name == "Rigveda")
        {
            newPage = Instantiate(page, Vector3.zero, Quaternion.identity) as GameObject;
            newPage.name = "Page " + currentPage;
            newPage.GetComponent<pageNumber>().pageNum = currentPage;
            Debug.Log(rigveda.bookPages[currentPage - 1]);
            pageText = newPage.transform.GetChild(1).GetChild(0).GetComponent<TextMeshProUGUI>();
            pageText.text = tkab.bookPages[currentPage - 1].ToString();
        }

        
    }

    void RemovePage(int currentPage)
    {
        if(currentPage>2)
        {
            deletionPage = GameObject.Find("Page " + (currentPage - 3));
            if(deletionPage.name != "Page 0")
            {
                Destroy(deletionPage);
            }
        }
    }
}
