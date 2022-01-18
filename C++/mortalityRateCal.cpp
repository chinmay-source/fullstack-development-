#include <iostream>
#include<conio.h>
using namespace std;
class virus //abstract base class 
{
protected:
    float cases, deaths;
public:
    void getCase() {
        cin >> cases;
    }
    void getDeaths() {
        cin >> deaths;
    }
    virtual float getMortalityRate() = 0;  //pure virtual function
};

class covidVirus : public virus
{
public:
    virtual float getMortalityRate() {

        return deaths / cases; //mortality rate for covid virus
    }
};

class hivVirus : public virus
{
public:
    float getMortalityRate() {

        return deaths / cases; //mortality rate  for HIV virus
    }
};

class birdFlu : public virus
{
public:
    float getMortalityRate() {

        return deaths / cases; //mortality rate for bird flu
    }
};


int main() {

    int num;
    cout << "Enter 1 for Covid virus" << endl;
    cout << "Enter 2 for HIV virus" << endl;
    cout << "Enter 3 for Bird flu virus" << endl;
    cin >> num;
    switch (num)
    {
    case 1: {
        covidVirus c;
        cout << "Enter Covid virus cases" << endl;
        c.getCase();
        cout << "Enter Covid virus deaths" << endl;
        c.getDeaths();
        cout << "Covid virus mortality rate is :" << c.getMortalityRate() << "%" << endl;
    }
          break;
    case 2:
    {
        hivVirus hiv;
        cout << "Enter HIV virus cases" << endl;
        hiv.getCase();
        cout << "Enter HIV virus deaths" << endl;
        hiv.getDeaths();
        cout << "HIV virus mortality rate is :" << hiv.getMortalityRate() << "%" << endl;
    }
    break;
    case 3:
    {
        birdFlu flu;
        cout << "Enter Bird flu virus cases" << endl;
        flu.getCase();
        cout << "Enter Bird flu virus deaths" << endl;
        flu.getDeaths();
        cout << "Bird Flu virus mortality rate is :" << flu.getMortalityRate() << "%" << endl;
    }
    break;

    default:
        cout << "please choose between 1 to 3" << endl;
        break;
    }
}
