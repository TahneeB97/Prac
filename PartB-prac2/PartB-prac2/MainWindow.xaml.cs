using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ThinkLib;

namespace PartB_prac2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int length(string s)
        {
            int l = 0;
            foreach(char a in s)
            {
                l++;
            }
            return l;
        }

        private void length_btn_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(length("xxx"), 3);
            Tester.TestEq(length("hello"), 5);
            Tester.TestEq(length("Hello how are you"), 17);
            Tester.TestEq(length("blah blah blah blahblah "), 24);
            Tester.TestEq(length(""), 0);
        }

        bool contains(string s,string subs)
        {
            string x = "";
            
            foreach (char a in subs)
            {
                foreach(char b in s)
                {
                    if (a == b)
                    {
                        x = x + a;
                    }                    
                }

            }
            if (x == subs)
            {
                return true;
            }
            return false;
        }
        private void contain_btn_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(contains("xxyxx", "y"), true);
            Tester.TestEq(contains("yes no", "ye"), true);
            Tester.TestEq(contains("xxyxx", "no"), false);
            Tester.TestEq(contains("hello", "h"), true);
            Tester.TestEq(contains("", "y"), false);

        }
        int IndexOf(string s,string subs) //need to do this
        {
            int l = 0; 
            int x = 0;
            string y = "";
            foreach (char a in s)
            {
                l++;
            }
            while (x < l)
            {
                if (s[x] == subs[x])
                {
                    y = y + s[x];
                }
            }
            
            foreach(char a in s)
            {

            }
            return x;
        }
        private void indexof_btn_Click(object sender, RoutedEventArgs e)
        {

        }

        string InsertSubString(string s,string x,int pos)
        {
            int i = 0;
            string newS = "";
            int l = 0;
            foreach (char a in s)
            {
                l++;
            }
            if (pos > l)
            {
                return "error";
            }
            
                foreach (char a in s)
                {
                    if (i == pos)
                    {
                        newS = newS + x;
                    }
                    newS = newS + a;
                    i++;
                }               
                        
            return newS;
        }
        private void insertsubstring_btn_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(InsertSubString("xxxx", "y", 2), "xxyxx");
            Tester.TestEq(InsertSubString("helo", "l", 3), "hello");
            Tester.TestEq(InsertSubString("hello how you", "are ",10 ), "hello how are you");
            Tester.TestEq(InsertSubString("yes or no", "ssss", 3), "yesssss or no");
            Tester.TestEq(InsertSubString("", "y", 2), "error");
        }

        string replaceSubString(string s, string New, string old)
        {
            string x = "";
            int l = 0;
            int l2 = 0;
            int i = 0;
            int start = 0;
            int ii = 0;
            foreach (char a in s)
            {
                l++;
            }           
            foreach (char b in old)
            {
                l2++;
            }
            if (l2 == 1)
            {
                foreach(char a in s)
                {
                    if (a == old[0])
                    {
                        x = x + New;
                        continue;
                    }
                    x = x + a;
                }
            }
            else
            {
                foreach (char a in s)
                {
                    if (old[i] == a)
                    {
                        start = i;
                        if (i < l2 - 1)
                        {
                            i++;
                        }
                        continue;
                    }
                    
                    else
                    {
                        
                        

                    }

                }
                foreach (char a in s)
                {
                    if (ii == (start - l2))
                    {
                        x = x + New;
                    }
                    x = x + a;
                }
            }
            
            return x;
        }
        private void replaceSubString_btn_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(replaceSubString("xxyxx", "ooo", "y"), "xxoooxx");
            Tester.TestEq(replaceSubString("hello", "p", "lo"), "help");
        }
        char Lower(char s)
        {

            char a = s;
                switch (s)
            {
                case 'A':return 'a';
                case 'B': return 'b';
                case 'C': return 'c';
                case 'D': return 'd';
                case 'E': return 'e';
                case 'F': return 'f';
                case 'G': return 'g';
                case 'H': return 'h';
                case 'I': return 'i';
                case 'J': return 'j';
                case 'K': return 'k';
                case 'L': return 'l';
                case 'M': return 'm';
                case 'N': return 'n';
                case 'O': return 'o';
                case 'P': return 'p';
                case 'Q': return 'q';
                case 'R': return 'r';
                case 'S': return 's';
                case 'T': return 't';
                case 'U': return 'u';
                case 'V': return 'v';
                case 'W': return 'w';
                case 'X': return 'x';
                case 'Y': return 'y';
                case 'Z': return 'z';
                
            }
            return a;
        }
         string toLower(string s)
        {
            string x = "";
            foreach (char a in s)
            {
                x = x + Lower(a);

            }
            return x;
        } 

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(toLower("HeLLo"), "hello");
        }

        char Upper(char s)
        {
            char a = s;
            switch (s)
            {
                case 'a': return 'A';
                case 'b': return 'B';
                case 'c': return 'C';
                case 'd': return 'D';
                case 'e': return 'E';
                case 'f': return 'F';
                case 'g': return 'G';
                case 'h': return 'H';
                case 'i': return 'I';
                case 'j': return 'J';
                case 'k': return 'K';
                case 'l': return 'L';
                case 'm': return 'M';
                case 'n': return 'N';
                case 'o': return 'O';
                case 'p': return 'P';
                case 'q': return 'Q';
                case 'r': return 'R';
                case 's': return 'S';
                case 't': return 'T';
                case 'u': return 'U';
                case 'v': return 'V';
                case 'w': return 'W';
                case 'x': return 'X';
                case 'y': return 'Y';
                case 'z': return 'Z';

            }
            return a;
        }
        string toUpper(string s)
        {
            string x = "";
            foreach (char a in s)
            {
                x = x + Upper(a);

            }
            return x;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Tester.TestEq(toUpper("HeLLo"), "HELLO");
        }

        List <string> Split(string s, char c)
        {
            List<string> a = new List<string>();
            string x = "";
            foreach(char a in s)
            {
                if (a == c)
                {
                    
                }
            }
        }
        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
