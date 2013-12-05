using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrisKringle
{

    public struct Pair
    {
        public string _personA;
        public string _personB;
    }

    public partial class Form1 : Form
    {
        List<string> _names;
        List<string> _ProcessedNames;
        List<Pair> _pairs;
        Random random;
        public Form1()
        {
            _names = new List<string>();
            random = new Random();
            

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string _tempName = textBox1.Text;
                _names.Add(_tempName);
                label1.Text = "Names : " + _names.Count;
                textBox1.Clear();
                string _nameString = "";
                for (int i = 0; i < _names.Count; i++)
                {
                    _nameString += _names[i] + "\r\n";
                }
                scrollTextBox2.Text = _nameString;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //run algorithm
            if (_names.Count % 2 != 0)
            {
                scrollTextBox1.Text = "Un-even number of participants";
            }
            else
            {
                _pairs = new List<Pair>();
                _ProcessedNames = new List<string>();

                string _next = FindFreePerson();
                int _num = 0;
                bool _found = false;
                for (int i = 0; i < _names.Count; i++)
                {
                    if (_names[i] == _next)
                    {
                        _found = true;
                        _num = i;
                    }
                }
                if (_found == false)
                {
                    Console.WriteLine("Shit");
                }
                _names.Remove(_next);
                ProcessPerson(_num, _next);
            }
        }

        private void ProcessPerson(int _person,string _name)
        {
            for (bool _continue = false; _continue == false; )
            {
                string _pair = FindFreePerson();
                _names.Remove(_pair);
                if (_name == _pair)
                {
                    _continue = false;
                }
                else
                {
                    _continue = true;
                    Pair _newPair;
                    _newPair._personA = _name;
                    _newPair._personB = _pair;
                    _pairs.Add(_newPair);
                    _names.Remove(_pair);
                    if (_names.Count == 0)
                    {
                        PrintPairs();
                    }
                    else
                    {
                        string _next = FindFreePerson();
                        int _num = 0;
                        bool _found = false;
                        for(int i = 0; i < _names.Count; i ++)
                        {
                            if(_names[i] == _next)
                            {
                                _found = true;
                                _names.Remove(_next);
                                _num = i;
                            }
                        }
                        if (_found == false)
                        {
                            Console.WriteLine("Shit");
                        }

                        ProcessPerson(_num, _next);
                    }
                }
            }
            
           
        }
        private void PrintPairs()
        {
            string _pairString = "";
            for (int i = 0; i < _pairs.Count; i++)
            {
                _pairString += _pairs[i]._personA + " is matched with : " + _pairs[i]._personB + "\r\n";
            }
            scrollTextBox1.Clear();
          //  scrollTextBox2.Clear();
            scrollTextBox1.Text = "Results : \r\n" + _pairString;
            //MessageBox.Show(_PairString);
         }
        private string FindFreePerson()
        {
            if (_names.Count == 0)
            {
                return null;
            }
            string _person = "";
            int _randomNumber = 1;
            try
            {
                _randomNumber = random.Next(1, _names.Count - 1);
            }
            catch (ArgumentOutOfRangeException e)
            {
                _randomNumber = 0;
            }
            _person = _names[_randomNumber];
            return _person;
        }
    }
}
