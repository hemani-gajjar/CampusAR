using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using GoogleSheetsToUnity;

public class UpdateGPS : MonoBehaviour
{

    //public Image img = GameObject.Find("Photo").GetComponent<Image>();

    public string coordinates;
    public Text Info;
    public Text Head;
    private float currlat;
    private float currlon;

    private void Update()
    {

        Info = GameObject.Find("Para").GetComponent<Text>();
        Head = GameObject.Find("Head").GetComponent<Text>();

        currlat = GPS.Instance.latitude;
        currlon = GPS.Instance.longitude;
        coordinates = "\nlatitude : " + GPS.Instance.latitude.ToString() + "\nLongitude : " + GPS.Instance.longitude.ToString() ;
        
        

        
        float[] lat = new float[7];
        lat[0] = 26.47066f;
        lat[1] = 26.47143f;
        lat[2] = 26.47279f;
        lat[3] = 26.47492f;
        lat[4] = 26.47485f;
        lat[5] = 26.47542f;
        lat[6] =  26.47541f;

        float[] lon = new float[7];
        lon[0] = 73.11359f;
        lon[1] = 73.11346f;
        lon[2] = 73.11380f;
        lon[3] = 73.11436f;
        lon[4] = 73.11484f;
        lon[5] = 73.11454f;
        lon[6] = 73.11485f;


        int minDistLocation = -1;
        
        string[] headText = new string[7];
        headText[0] = "Administration Building";
        headText[1] = "Library";
        headText[2] = "Lecture Hall Building";
        headText[3] = "Department of Computer Science and Engineering";
        headText[4] = "Basic Labs";
        headText[5] = "Department of Bioscience and Bioengineering";
        headText[6] = "Department of Chemistry" ;



        
        string[] bodyText = new string[7];
        bodyText[0] = @"The Office of Administration facilitates the following 
        \n(a) Performance of Statutory Duties 
        \n      1.Organization of meetings of BoG, FC, Senate, BWC; Agenda & Minutes of above bodies;
        \n      2.Notification of membership of Standing Committees of the BoG, FC, Senate and BWC; and
        \n      3.Notification of appointments of Deans, Coordinators, Heads of Areas of Study, Centers of Technologies, Academic Service Facilities.
        \n(b)Legal
        \n      1.Handling of legal matters including preparation of briefs as required in legal cases involving Institute;
        \n      2.Liaison with Institute’s Legal Counselor and any lawyers engaged commercially by the Institute;
        \n      3.Cases of Arbitration; and
        \n      4.Support to Chief Vigilance Officer, and other Statutorily appointed Officers of the Institute.
        \n      5.Academic discipline & academic integrity;
        \n(c)Public Relations & Institute Publication
        \n      1.Liaison with public / news media; and
        \n      2.Publications of the Institute(Annual Report, Newsletter, and others).";
        bodyText[1] = @"The Learning Hub (TLH), i.e., the Library, supports the teaching 
and research activities of the Institute by facilitating acquisition, 
organization and dissemination of knowledge resources, and also providing library & information services to IIT Jodhpur community. 
Marking the starting of Innovation Street, Library is sited pre-eminently at the entrance of the academic area of the Institute. 
It stands as the tallest structure, keeping time for the entire campus with a 4-way clock at the clock tower.";
        bodyText[2] = @"The Institute Lecture Hall Building (LHB) hosts classrooms of various sizes from a large auditorium to small tutorial rooms. Booking of regular lecture slots is done by the academic office. Faculty and certain other officers can book free slots for additional lectures or other academic activity. Apart from being used for lectures, seminars and conferences, the auditorium (Room No. 110) that can seat 600 people is also used for used for a variety of purposes like cultural activities (Performing Arts Festival, Socials etc), the year end Convocation and weekend movies.";
        bodyText[3] = @"The Computer Science and Engineering Department Building also houses Mathematics Department and Department of Humanities and Social Sciences. The Building consists of Computer Labs which are used by the students for computing activities and Laboratory purposes. Wi-Fi service is enabled in the building and surrounding areas.";
        bodyText[4] = @"The Department of Bioscience & Bioengineering operates it's laboratory courses in fully equipped state-of-the-art teaching laboratories (205 & 206) in the basic laboratory building. These basic & advanced bioscience & bioengineering labs provide access to a host of equipment required for teaching bioscience & bioengineering at the undergraduate and post-graduate levels.";
        bodyText[5] = @"The Department of Bioscience & Bioengineering operates several research laboratories catering to the following core research areas:

        Cell & Molecular Physiology
        Environmental Biotechnology
        Biomaterials & Tissue Engineering
        Chemical BIology & Drug Design
        Molecular Microbiology & Microbial Genomics
        Biophysics
        Computational Biology & Bioinformatics
        Molecular Motos & Cell Motility
        Neuroscience & Neuroengineering";
        bodyText[6] = @"Chemistry Department Building is where UG and PG level chemistry courses are taught. Chemistry labs 
are two hours long, every other week. They are designed to complement and reinforce course material presented in lectures. One can expect to see many 
different types of experiments including titrations, organic reactions, synthesis of nylon, electrochemical reactions, study of color in complexes, fluorescence 
and functional groups identification using spectrometers, to name a few. The focus is on developing hands-on-skills required for solving various scientific problems.
        \nThere are two teaching laboratories for carrying out wet and dry chemistry experiments.
        \nLab No. 105, Organic and Inorganic Chemistry Laboratory
        \nLab No. 106, Analytical and Physical Chemistry Laboratory";





        
        float max = 5f;
        for (int i = 0; i < 7; i++)
        {
            float tempdist = Mathf.Abs(currlat - lat[i]) + Mathf.Abs(currlon - lon[i]);
            if (max > tempdist)
            {
                max = tempdist;
                minDistLocation = i;
            }
        }
        
        if(minDistLocation == -1)
        {
            Info.text = "You have not reach the location!" + coordinates;
            Head.text = "Location not found!";
        } 
        else
        {
           Info.text = bodyText[minDistLocation] + coordinates;
           Head.text = headText[minDistLocation];
        }

        /*
        else if(minDistLocation == 0 )
        {
            Info.text = @"" + coordinates;
            Head.text = "";
        }
        else if(minDistLocation == 1)
        {
            Info.text = @"" + coordinates;
            Head.text = "";
        }
        else if (minDistLocation ==2)
        {
            Info.text = @"" + coordinates;
            Head.text = "";
        }
        else if (minDistLocation == 3)
        {
            Info.text = @"" + coordinates;
            Head.text = "";
        }
        else if (minDistLocation == 4)
        {
            Info.text = @"" + coordinates;
            Head.text = "";
        }
        else if (minDistLocation == 5)
        {
            Info.text = @"" + coordinates;
            Head.text = "";
        }
        else if (minDistLocation == 6)
        {
            Info.text = @"" + coordinates;
            Head.text = "";
        }
        */
    }
}
