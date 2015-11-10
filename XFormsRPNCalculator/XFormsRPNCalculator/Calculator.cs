using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFormsRPNCalculator
{
    class Calculator
    {
		//public string kkk = "1237";
        private const int _max = 4;
        private const double _small = 26;
        private const double _large = 40;
        private const string _exp = "0.000000e+00";

        private bool _fix = false;
        private bool _new = true;
        //private double _memory = 0.0;
       // private double _xreg = 0.0;
        private string _format = "0.00";
		private string _output = String.Empty;
		private string _output1 = "°°°°";//"ºººº";  // "....";

       // private CalculatorStack _stack = new CalculatorStack();

		//private CalculatorPage _tmp = new CalculatorPage ();

        public string Output
        {
            get { return _output; }
        }
		public string Output1
		{
			get { return _output1; }
		}


		public async void Execute(string command)
        {
            switch (command)
            {
                case "0":
                case "1":
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                    if (_fix)
                    {
                        // If the user pressed the "FIX" key, then this keypress represents
                        // the desired number of decimal places. Update the _format string and
                        // refresh the display.
                        int digits = Convert.ToInt32(command);
                        StringBuilder sb = new StringBuilder("0.");

                        for (int i = 0; i < digits; i++)
                            sb.Append('0');

                        _format = sb.ToString();
                      //  _output = StringifyXRegister();
                    }
                    else
                    {
					if (_new)
						//if (_new || (_output.Length == 4))
                        {
                            // If this is the first character in a new entry, push the current
                            // value of the X register onto the stack and clear the display
                            _new = false;
                           // _stack.Push(_xreg);
                            _output = String.Empty;
						   _output1 = String.Empty;
					}

                        // Add the new character to the display and update the X register
					if (_output.Length < _max) {
						_output += command;
					//	_xreg = Convert.ToDouble (_output);
					}
						switch (_output.Length) {
						case 0:
						_output1 = "°°°°";//"ºººº";//"....";
							break;
						case 1:
						_output1 = "•°°°";//"•ººº";
							break;
						case 2:
						_output1 = "••°°";//"••ºº";
							break;
						case 3:
						_output1 = "•••°"; //"•••º";
							break;
						case 4:
							{
							//string tmp = "°°°°";
							//await _output1 = "••••";
							//await _output1 = "°°°°";
							//await _output1 = tmp.Substring(0, tmp.Length);
							 _output1 = "••••";
							//await Task.Delay (5000);
							 _output1 = "°°°°";
								_new = true;
							}
							break;
						//default:
						//	{
						//_output1 = "";
						//_output = String.Empty;
						//	}
						//	break;
						}
						//_output1 += command;
						//_output1 += @"\e6c3"; //"\e6ce"; //"@";

						// if (_output1.Length == 4) 
						//CalculatorPage.Navigation.PushAsync (new springBoard ()); //_tmp.Navigation.PushAsync (new springBoard()); //Navigation.PushAsync (new springBoard ());
					//}
					//else {

					//	_output = "aaaa";
					//	_output1 = "....";
					//	}
                    
				}
                    break;
			case "Del":
				{
					if ((_output.Length > 0) && (_output.Length< _max)) {
						_output = _output.Substring (0, _output.Length - 1);
						//_output1 = _output1.Substring (0, _output.Length - 1) + "º";
						switch (_output.Length) {
						case 0:
							_output1 = "°°°°";// "ºººº";//"...."; 
							break;
						case 1:
							_output1 = "•°°°"; //"•ººº";
							break;
						case 2:
							_output1 = "••°°";//"••ºº";
							break;
						case 3:
							_output1 = "•••°";//"•••º";
							break;
						}

					}
				}
					break;

                

                
			}
		}

      
    }
}
