using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PictureState : MonoBehaviour {

    public Image image;
    public Sprite sprite;
    public TextMeshProUGUI text;
    public int max = 300;
    public List<string> words;
    public List<ParaHolder> paraHolders;
    public bool next;
    public bool done;
    public bool waiting;
    public GameObject textBox;
    public GameObject arrow;
    // Use this for initialization
    void Start() {
        next = false;
        waiting = false;
        done = false;
        textBox.SetActive(true);
        arrow = GameObject.FindObjectOfType<FindMe>().gameObject;
        arrow.SetActive(false);
        textBox.SetActive(false);
        //button.onClick.AddListener(Advance);
        paraHolders = new List<ParaHolder>();
        words = new List<string>();
    }

    // Update is called once per frame
    void Update()
    {
        if (waiting)
        {
            if (Input.anyKey)
            {
                waiting = false;
                Advance();
            }
        }
	}

    public void NewMe(string look)
    {
        sprite = Resources.Load<Sprite>(look);
        image.sprite = sprite;
    }

    public void RemoveMe()
    {
        //image.sprite = null;
        gameObject.SetActive(false);
    }

    public void NewText(string allWords)
    {      
        StartCoroutine(ScrollingText(allWords));
    }

    IEnumerator ScrollingText(string allWords)
    {
        WordBoxMaker(allWords);
        yield return new WaitForSeconds(0.05f);
        textBox.SetActive(true);
        foreach (ParaHolder para in paraHolders)
        {

            foreach (string words in para.paras)
            {
                char[] word = words.ToCharArray();
                for (int i = 0; i < word.Length; i++)
                {
                    
                     text.text += word[i].ToString();                                     
                    yield return new WaitForSeconds(0.05f);
                }
                //button.gameObject.SetActive(true);
                text.text += " ";
               // button.gameObject.SetActive(false);
            }
            waiting = true;
            arrow.SetActive(true);
            yield return new WaitUntil(() => next == true);
            next = false;
            waiting = false;
            arrow.SetActive(false);
            textBox.SetActive(false);
            done = true;
        }
      
    }

    void Advance()
    {
        next = true;
    }

    public void Clear()
    {
        words.Clear();
        paraHolders.Clear();
    }

    public bool ActuallyAWord(int i, char[] fixit)
    {
        bool check = false;
        string[] wordsUsingPeriod = { "Mr", "Mrs", "ect", "Ect", "ie" };
        for (int j = 0; j < wordsUsingPeriod.Length; j++)
        {
            if (fixit[i - 3].ToString() + fixit[i - 2].ToString() + fixit[i - 1].ToString() == wordsUsingPeriod[j]) check = true;
        }
        for (int j = 0; j < wordsUsingPeriod.Length; j++)
        {
            if (fixit[i - 2].ToString() + fixit[i - 1].ToString() == wordsUsingPeriod[j]) check = true;
        }
        return check;

    }

    public void WordBoxMaker(string book)
    {

        List<List<string>> allChapterWordsPerm = new List<List<string>>();
        List<List<string>> allChapterSect = new List<List<string>>();
        //Debug.Log(allWords);

        string paragraph = "";
        bool textPresent = false;
        Debug.Log("get to this point hhhttjv");
        List<string> wordList = new List<string>();

        string sentance = "";
        List<string> sentances = new List<string>();
        List<string> paragraphs = new List<string>();
        string word = "";

        string chapter1 = book;
        char[] fixit = chapter1.ToCharArray();

        Debug.Log(fixit[0].ToString() + fixit[1].ToString());
        int size = fixit.Length;

        for (int i = 0; i < size; i++)
        {
            int j = i;


            if (j + 1 >= fixit.Length)
            {
                if (fixit[i].ToString() == "\n")
                {
                    int e = 0;
                    Debug.Log("faaaaa");

                    if (textPresent)
                    {
                        textPresent = false;
                        if (word != "") wordList.Add(word);

                        if (wordList.Count != 0)
                        {
                            foreach (string words in wordList)
                            {

                                if (e != 0)
                                {
                                    sentance += " " + words;
                                }
                                else if (wordList.Count < 1)
                                {
                                    if (fixit[i].ToString() != " ") sentance += words + fixit[i].ToString();
                                }
                                else sentance += words;
                                e++;
                            }
                            // Debug.Log(sentance + " sent");
                            sentances.Add(sentance);
                            sentance = "";
                            word = "";
                            ///if (localText != null) localText.StoreWord(wordList);
                            wordList.Clear();
                            e = 0;
                        }
                        foreach (string s in sentances)
                        {
                            // Debug.Log(s);
                            paragraph += s + " ";
                        }


                        //  Debug.Log(paragraph + " par");


                        paragraph += "\n";
                        paragraphs.Add(paragraph);
                        paragraph = "";
                        //if (localText != null) localText.StoreWord(wordList);
                        sentances.Clear();
                        wordList.Clear();
                        Debug.Log("Reporting");

                    }

                }
            }
            else if (fixit[i].ToString() == "\n")
            {

                if (textPresent)
                {
                    textPresent = false;
                    if (word != "") wordList.Add(word);

                    if (wordList.Count != 0)
                    {
                        int e = 0;
                        foreach (string words in wordList)
                        {

                            if (e != 0)
                            {
                                sentance += " " + words;
                            }
                            else if (wordList.Count < 1)
                            {
                                if (fixit[i].ToString() != " ") sentance += words + fixit[i].ToString();
                            }
                            else sentance += words;
                            e++;
                        }
                        // Debug.Log(sentance + " sent");
                        sentances.Add(sentance);
                        sentance = "";
                        word = "";
                        ///if (localText != null) localText.StoreWord(wordList);
                        wordList.Clear();
                        e = 0;
                    }
                    Debug.Log("Reporting1");
                    foreach (string s in sentances)
                    {
                        // Debug.Log(s);
                        paragraph += s + " ";
                    }
                    //  Debug.Log(paragraph + " par");
                    paragraph += "\n";
                    paragraphs.Add(paragraph);
                    paragraph = "";
                    // if (localText != null) localText.StoreWord(wordList);
                    sentances.Clear();
                    wordList.Clear();



                }


            }

            if (fixit[i].ToString() == "." && !ActuallyAWord(j, fixit) || fixit[i].ToString() == "!" || fixit[i].ToString() == "?" || fixit[i].ToString() == ";")
            {

                int e = 0;
                if (j + 1 >= size)
                {
                }
                else if (fixit[j + 1].ToString() == "\"")
                {
                    word += fixit[i].ToString() + fixit[j + 1].ToString();
                    //Debug.Log(word + " Norm");
                    i++;
                }
                else
                {
                    word += fixit[i].ToString();
                    //Debug.Log(word + " ELSE");
                }

                // Debug.Log(word + " ggg");
                // textPresent = true;
                wordList.Add(word);
                word = "";

                foreach (string words in wordList)
                {

                    if (e != 0)
                    {
                        sentance += " " + words;
                    }
                    else if (wordList.Count < 1)
                    {
                        if (fixit[i].ToString() != " ") sentance += words + fixit[i].ToString();
                    }
                    else sentance += words;
                    e++;
                }
                // Debug.Log(sentance + " sent");
                sentances.Add(sentance);
                sentance = "";
                // if (localText != null) localText.StoreWord(wordList);
                wordList.Clear();
                word = "";
                e = 0;
            }
            else
            {
                if (fixit[i].ToString() != " " && fixit[i].ToString() != "\n") word += fixit[i].ToString();
                else
                {

                    if (word != " " && word != "")
                    {
                        // if (SeachText(word, wordList)
                        wordList.Add(word);
                        textPresent = true;
                        // Debug.Log(word + " ttk");
                    }
                    word = "";
                }
            }


        }

        if (wordList.Count > 0)
        {
            int e = 0;
            foreach (string words in wordList)
            {
                if (e != 0)
                {
                    sentance += " " + words;
                }
                else sentance += words;
                e++;
            }
            // Debug.Log(sentance + " sent");
            sentances.Add(sentance);
            sentance = "";
            // if (localText != null) localText.StoreWord(wordList);
            wordList.Clear();
            foreach (string s in sentances)
            {
                // Debug.Log(s);
                paragraph += s + " ";
            }
            //  Debug.Log(paragraph + " par");
            paragraph += "\n";
            paragraphs.Add(paragraph);
            paragraph = "";
            // if (localText != null) localText.StoreWord(wordList);
            sentances.Clear();
            wordList.Clear();


        }
        else if (sentances.Count > 0)
        {

            foreach (string s in sentances)
            {
                // Debug.Log(s);
                paragraph += s + " ";
            }
            //  Debug.Log(paragraph + " par");
            paragraph += "\n";
            paragraphs.Add(paragraph);
            paragraph = "";
            // if (localText != null) localText.StoreWord(wordList);
            sentances.Clear();
            wordList.Clear();
        }

        int count = 0;
        foreach (string para in paragraphs)
        {
            char[] fix = para.ToCharArray();
            string wordtemp = "";
            

            List<string> tempList = new List<string>();

            for (int f = 0; f < fix.Length; f++)
            {

                if (fix[f].ToString() != " " && fix[f].ToString() != "\n") wordtemp += fix[f].ToString();
                else
                {

                    if (wordtemp != " " && wordtemp != "")
                    {
                        tempList.Add(wordtemp);
                    }
                    wordtemp = "";
                }

            }
            paraHolders.Add(new ParaHolder(tempList, count));
            count++;
        }

      
    }

    [System.Serializable]
    public class EmotionHolder
    {
        public string sad;
        public string mad;
        public string happy;
        public EmotionHolder()
        {
            sad = "";
            mad = "";
            happy = "";
        }

    }

    [System.Serializable]
    public class ParaHolder
    {

        public List<string> paras;
        public int index;
        // Use this for initialization
        public ParaHolder(List<string> list, int id)
        {
            paras = list;
            index = id;

        }
    }
}
