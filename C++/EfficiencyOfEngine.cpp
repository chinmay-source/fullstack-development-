#include <iostream>
#include<conio.h>
using namespace std;
class Engine			//abstract base class 
{
protected:
  float input, output;
public:
  void getInput ()
  {
    cin >> input;
  }
  void getOutput ()
  {
    cin >> output;
  }
  virtual float GetEfficiency () = 0;	//pure virtual function
};

class InternalCombustineEngine:public Engine
{
public:
  float GetEfficiency ()
  {

    return output / input;	//calculation of efficience of engine 
  }
};

class PetrolEngine:public InternalCombustineEngine
{
public:
float GetEfficiency ()
  {

    return output / input;
  }
};


class DieselEngine : public InternalCombustineEngine
  {
public:
 float GetEfficiency ()
  {

    return output / input;	
  }
  }; 
  class ExternalCombustineEngine : public Engine
  {
      public:
  float GetEfficiency ()
  {

    return output / input;	//calculation of efficiency of engine 

   }
  };
  class SteamEngine : public ExternalCombustineEngine
  {
    public:
    float GetEfficiency ()
  {

    return output / input;
  }
  }; 

int main ()
{

  int num;
  cout << "Enter 1 for Petrol Engine" << endl;
  cout << "Enter 2 for Diesel Engine" << endl;
  cout << "Enter 3 for Steam Engine" << endl;
  cin >> num;
  switch (num)
    {
    case 1:
      {
	PetrolEngine pt;
	cout << "Enter the input for Petrol Engine: " << endl;
	pt.getInput();
	cout << "Enter the output for Petrol Engine: " << endl;
	pt.getOutput();
	cout << "Efficiency of Petrol Engine is: " << 
	pt.GetEfficiency() <<endl;
      }
      break;
      case 2:
      {
	DieselEngine di;
	cout << "Enter the input for Diesel Engine: " << endl;
	di.getInput ();
	cout << "Enter the output for Diesel Engine: " << endl;
	di.getOutput ();
	cout << "Efficiency of Petrol Engine is: " << 
	di.GetEfficiency () <<endl;
      }
      break;
      case 3:
      {
	SteamEngine st;
	cout << "Enter the input for Steam Engine: " << endl;
	st.getInput ();
	cout << "Enter the output for Steam Engine: " << endl;
	st.getOutput ();
	cout << "Efficiency of Steam Engine is: " << 
	st.GetEfficiency () <<endl;
      }
      break;
    default:
      cout << "please choose between 1 to 3" << endl;
      break;
    }
}


