using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class books : MonoBehaviour
{
    // Start is called before the first frame update
    string url = "https://raw.githubusercontent.com/UltraVaporizer/makeuc2022/main/to_kill_a_mockingbird-harper_lee.txt";
    void Start()
    {
        pullBooks();
    }
    void pullBooks()
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
            Debug.Log(books);
        }
    }
    // public void LoadJson()
    // {
    //     using (StreamReader r = new StreamReader("books.json"))
    //     {
    //         string json = r.ReadToEnd();
    //         List<Item> items = JsonConvert.DeserializeObject<List<Item>>(json);
    //     }
    // }

    // dynamic array = JsonConvert.DeserializeObject(json);
    // foreach(var item in array)
    // {
    //     Console.WriteLine("{0}", item.Book1);
    // }
}