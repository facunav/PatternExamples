using BehavioralPatterns.CommandPattern;
using BehavioralPatterns.CommandPattern.LightCommands;
using BehavioralPatterns.CommandPattern.StereoCommands;
using BehavioralPatterns.MementoPattern;
using BehavioralPatterns.ObserverPattern.Technique1;
using BehavioralPatterns.ObserverPattern.Technique2;
using BehavioralPatterns.ObserverPattern.Technique3;
using BehavioralPatterns.StatePattern;
using BehavioralPatterns.Strategy;
using BehavioralPatterns.TemplateMethod;
using System;

namespace BehavioralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //COMMAND PATTERN EXAMPLE
            #region CommandPattern
            //Remote control example

            Console.WriteLine("COMMAND PATTERN EXAMPLE");
            Console.ReadKey();

            SimpleRemoteControl remote = new SimpleRemoteControl();
            Light light = new Light();
            Stereo stereo = new Stereo();

            // we can change command dynamically 
            remote.SetCommand(new LightOnCommand(light));
            remote.ButtonWasPressed();
            remote.SetCommand(new StereoOnWithCDCommand(stereo));
            remote.ButtonWasPressed();
            remote.SetCommand(new StereoOffCommand(stereo));
            remote.ButtonWasPressed();
            Console.ReadKey();
            #endregion CommandPattern

            //MEMENTO PATTERN EXAMPLE
            #region MementoPattern
            //Let us first understand the example that we are going to implement using the Memento Design Pattern in C#.

            //I buy one 42inch led TV whose cost is 60000rs and it does not support USB and I placed it on the hall. After some point of 
            //time, I thought let buy 46inch led TV.So, I buy a 46 inch led TV whose cost is 80000rs and it supports USB and I want to 
            //place it in the hall. But already in the hall 42inch led tv is there.So, what I have to do is, I have to place the 42inch 
            //led TV in the storeroom and place this 46inch led TV on the hall.

            //Again after some point of time, I am thinking let buy 50inch led TV whose cost is 100000rs and supports USB. So, 
            //I buy this 46inch led TV and I want to place it in the hall. But in the hall, the 46inch led TV is there.So, what
            //I have to do is, I have to take the 46inch led TV from the hall and put it again in the storeroom and then place the 
            //50inch led TV in the hall.

            //After some point of time, I thought let put the 42inch led TV in the hall as the clarity of the 50inch led TV is not 
            //that good. So, what I have to do is, I have to take the 50inch led TV from the hall and put it on the storeroom and from 
            //the storeroom take thee 42inch led TV and put it on the hall. So, basically we are rollbacking to its previous state.
            Console.WriteLine("\nMEMENTO PATTERN EXAMPLE");
            Console.ReadKey();

            Originator originator = new Originator();
            originator.LedTV = new LedTv("42 inch", "60000Rs", false);

            Caretaker caretaker = new Caretaker();
            caretaker.AddMemento(originator.CreateMemento());
            originator.LedTV = new LedTv("46 inch", "80000Rs", true);
            caretaker.AddMemento(originator.CreateMemento());
            originator.LedTV = new LedTv("50 inch", "100000Rs", true);

            Console.WriteLine("\nOrignator current state : " + originator.GetDetails());
            Console.WriteLine("\nOriginator restoring to 42 inch LED TV");
            originator.LedTV = caretaker.GetMemento(0).LedTV;
            Console.WriteLine("\nOrignator current state : " + originator.GetDetails());
            Console.ReadKey();

            #endregion MementoPattern

            //OBSERVER PATTERN EXAMPLE
            #region ObserverPattern
            //The code below is based on a scenario wherein we have a weather station which records weather data 
            //(temperature, humidity and pressure).

            Console.WriteLine("\nOBSERVER PATTERN EXAMPLE");
            Console.ReadKey();

            Console.WriteLine("\nTECHNIQUE 1: Using Pure Object Oriented(OO) Programming Concepts");
            Console.ReadKey();

            WeatherDataProvider1 weatherData = new WeatherDataProvider1();

            CurrentConditionsDisplay1 currentDisp = new CurrentConditionsDisplay1(weatherData);
            ForecastDisplay1 forecastDisp = new ForecastDisplay1(weatherData);

            weatherData.SetMeasurements(40, 78, 3);
            Console.WriteLine();
            weatherData.SetMeasurements(45, 79, 4);
            Console.WriteLine();
            weatherData.SetMeasurements(46, 73, 6);

            //Remove forecast display
            forecastDisp.Dispose();
            Console.WriteLine();
            Console.WriteLine("Forecast Display removed");
            Console.WriteLine();
            weatherData.SetMeasurements(36, 53, 8);

            Console.Read();
            Console.ReadKey();

            Console.WriteLine("\nTECHNIQUE 2: Using Events and Delegates");
            Console.ReadKey();

            WeatherDataProvider2 provider2 = new WeatherDataProvider2();

            CurrentConditionsDisplay2 current = new CurrentConditionsDisplay2(provider2);
            ForecastDisplay2 forecast = new ForecastDisplay2(provider2);

            provider2.NotifyDisplays(40, 78, 3);
            Console.WriteLine();
            provider2.NotifyDisplays(42, 68, 5);
            Console.WriteLine();
            provider2.NotifyDisplays(45, 68, 8);
            Console.WriteLine();
            forecast.Unsubscribe();
            Console.WriteLine("Forecast Display removed");
            Console.WriteLine();
            provider2.NotifyDisplays(30, 58, 1);

            //Code to call to detach all event handler
            provider2.Dispose();

            Console.Read();
            Console.ReadKey();

            Console.WriteLine("\nTECHNIQUE 3: Using IObservable<T> and IObserver<T>");
            Console.ReadKey();

            WeatherDataProvider3 weatherDataO = new WeatherDataProvider3();

            CurrentConditionsDisplay3 currentDisp3 = new CurrentConditionsDisplay3(weatherDataO);

            ForecastDisplay3 forecastDisp3 = new ForecastDisplay3(weatherDataO);

            weatherDataO.SetMeasurements(40, 78, 3);
            Console.WriteLine();
            weatherDataO.SetMeasurements(45, 79, 4);
            Console.WriteLine();
            weatherDataO.SetMeasurements(46, 73, 6);
            //Remove forecast display
            forecastDisp3.Unsubscribe();

            Console.WriteLine();
            Console.WriteLine("Forecast Display removed");
            Console.WriteLine();
            weatherDataO.SetMeasurements(36, 53, 8);

            Console.Read();
            #endregion ObserverPattern

            //STRATEGY PATTERN EXAMPLE
            #region StrategyPattern
            //we’ll assume that if a person walks into the room, he needs to get cool air from any source (Fan, Cooler or A.C.). 
            //It is up to the person to turn on what he needs of the day.After turning on any of those available sources we will 
            //also output what turned on.

            Console.WriteLine("\nSTRATEGY PATTERN EXAMPLE");
            Console.ReadKey();

            Console.WriteLine("Please select a colling system:");
            Console.WriteLine("\n0 - Fan");
            Console.WriteLine("\n1 - Cooler");
            Console.WriteLine("\n2 - AC");
            int input = int.Parse(Console.ReadKey().KeyChar.ToString());
            Console.WriteLine();

            PrintSelectedCoolingSystem.PrintSelectedCoolingChoice(input);
            Console.Read();
            Console.ReadKey();
            #endregion StrategyPattern

            //TEMPLATE METHOD PATTERN EXAMPLE
            #region TemplateMethodPattern
            //Let us assume that we have a class that reads the data from a data source and then creates a file for reporting purpose

            Console.WriteLine("\nTEMPLATE METHOD PATTERN EXAMPLE");
            Console.ReadKey();

            DataExporter exporter = null;

            // Lets export the data to Excel file
            exporter = new ExcelExporter();
            exporter.ExportFormatedData();

            Console.WriteLine();

            // Lets export the data to PDF file
            exporter = new PDFExporter();
            exporter.ExportFormatedData();
            Console.ReadKey();
            #endregion TemplateMethodPattern

            //STATE PATTERN EXAMPLE
            #region StatePattern

            Console.WriteLine("\nSTATE METHOD PATTERN EXAMPLE");
            Console.ReadKey();

            // Initially ATM Machine in DebitCardNotInsertedState
            AtmMachine atmMachine = new AtmMachine();
            Console.WriteLine("ATM Machine Current state : " + atmMachine.atmMachineState.GetType().Name);
            Console.WriteLine();
            atmMachine.EnterPin();
            atmMachine.WithdrawMoney();
            atmMachine.EjectDebitCard();
            atmMachine.InsertDebitCard();
            Console.WriteLine();
            // Debit Card has been inserted so internal state of ATM Machine
            // has been changed to DebitCardInsertedState
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.atmMachineState.GetType().Name);
            Console.WriteLine();
            atmMachine.EnterPin();
            atmMachine.WithdrawMoney();
            atmMachine.InsertDebitCard();
            atmMachine.EjectDebitCard();
            Console.WriteLine("");
            // Debit Card has been ejected so internal state of ATM Machine
            // has been changed to DebitCardNotInsertedState
            Console.WriteLine("ATM Machine Current state : "
                            + atmMachine.atmMachineState.GetType().Name);
            Console.Read();
            #endregion StatePattern
        }
    }
}
