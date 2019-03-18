using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.XPath;
using System.Text.RegularExpressions;
using System;
using System.IO;

public class CreditLoader:MonoBehaviour
{
    // Start is called before the first frame update

    public string path = "Assets/XMLFiles/Credits.xml";
    public string finalp = "Assets/XMLFiles/finalCredits.xml";
    private ArrayList names = new ArrayList();
    private ArrayList killed = new ArrayList();
    private creditreader cr = new creditreader();
    void Start()
    {
       
        cr.read();
        cr.write("");
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  
    
}
