using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Quran : MonoBehaviour
{
    string url = "https://raw.githubusercontent.com/UltraVaporizer/makeuc2022/main/quran.txt";
    string page;
    public ArrayList bookPages;

    void Start()
    {
        pullBooks();
        bookPages = new ArrayList();
    }
    public void pullBooks()
    {
        StartCoroutine(getBooks());
    }
    IEnumerator getBooks()
    {
        UnityWebRequest books_pull = UnityWebRequest.Get(url);
        yield return books_pull.SendWebRequest();
        if (books_pull.error != null)
        {
            Debug.LogError("Couldn't pull books: " + books_pull.error);
        }
        else
        {
            string books = books_pull.downloadHandler.text;
            //Debug.Log(books);
            string[] words = books.Split('\n');
            int count = 0;
            int count1 = 0;
            //Debug.Log(words.Length);
            var pages = Mathf.Floor(words.Length / 20) + 1;
            //Debug.Log(pages);
            for (int i = count1; i <= pages; i++)
            {
                for (int j = count; (j < count+20 && j < words.Length); j++) 
                {
                    if (words[j] != null)
                    {
                        page = page + words[j] + " ";
                    }
                }
                count = count + 20;
                bookPages.Add(page);
                Debug.Log(page);
                page = "";
            }
        }
    }
}
