using System.Runtime.CompilerServices;
using System.Text;
using System;
namespace Afsluttende_opgave___Cpr__nummer
{
    internal class Program
    {
        
  
        
            static void Main()
            {
                bool keepRunning = true;
                while (keepRunning)
                {
                    Console.Write("Input CPR fx 220805-3434: ");

                    string dato_Time = Console.ReadLine();

                // Remove any spaces
                //ydato_Time = dato_Time.Replace("-", "");

                // Check if input length is valid and contains a hyphen at the correct position
                if (dato_Time.Length >= 11 && dato_Time[6] == '-' && dato_Time.Length <= 11)
                    {
                    // Remove the hyphen
                    dato_Time = dato_Time.Replace("-", "");
                  
                  
                    if (double.TryParse(dato_Time, out double datoTime))
                        {
                            //Console.WriteLine("Passed to int datotime: " + datoTime);

                            // Extract day, month, and last CPR digits
                            string dagIndex = dato_Time.Substring(0, 2);
                            string månedIndex = dato_Time.Substring(2, 2);
                            string lastCprDigits = dato_Time.Substring(9, 1);

                          

                            int day = int.Parse(dagIndex);
                            int month = int.Parse(månedIndex);
                            int lastCprtal = int.Parse(lastCprDigits);

                            // Check if month and day are valid
                            if (month <= 12 && month >= 1)
                            {
                                if (day >= 1 && day <= 31)
                                {
                                Console.WriteLine("Day: " + dagIndex);
                                 Console.WriteLine("Month: " + månedIndex);
                                Console.WriteLine("Last CPR digits: " + lastCprDigits);

                                // Determine gender based on the last CPR digits
                                if (lastCprtal % 2 == 0) { Console.WriteLine("You are a woman"); }
                                    else { Console.WriteLine("You are a man"); }

                                // check vægtsummen

                                string Cpr_index0 = dato_Time.Substring(0, 1);
                                string Cpr_index1 = dato_Time.Substring(1, 1);
                                string Cpr_index2 = dato_Time.Substring(2, 1);
                                string Cpr_index3 = dato_Time.Substring(3, 1);
                                string Cpr_index4 = dato_Time.Substring(4, 1);
                                string Cpr_index5 = dato_Time.Substring(5, 1);
                                string Cpr_index6 = dato_Time.Substring(6, 1);
                                string Cpr_index7 = dato_Time.Substring(7, 1);
                                string Cpr_index8 = dato_Time.Substring(8, 1);
                                string Cpr_index9 = dato_Time.Substring(9, 1);
                               

                                int Cprindex_0 = int.Parse(Cpr_index0);
                                int Cprindex_1 = int.Parse(Cpr_index1);
                                int Cprindex_2 = int.Parse(Cpr_index2);
                                int Cprindex_3 = int.Parse(Cpr_index3);
                                int Cprindex_4 = int.Parse(Cpr_index4);
                                int Cprindex_5 = int.Parse(Cpr_index5);
                                int Cprindex_6 = int.Parse(Cpr_index6);
                                int Cprindex_7 = int.Parse(Cpr_index7);
                                int Cprindex_8 = int.Parse(Cpr_index8);
                                int Cprindex_9 = int.Parse(Cpr_index9);
                             

                                Cprindex_0 = Cprindex_0 * 4;
                                Cprindex_1 = Cprindex_1 * 3;
                                Cprindex_2 = Cprindex_2 * 2;
                                Cprindex_3 = Cprindex_3 * 7;
                                Cprindex_4 = Cprindex_4 * 6;
                                Cprindex_5 = Cprindex_5 * 5;
                                Cprindex_6 = Cprindex_6 * 4;
                                Cprindex_7 = Cprindex_7 * 3;
                                Cprindex_8 = Cprindex_8 * 2;
                                Cprindex_9 = Cprindex_9 * 1;



                                double Vægtsum = Cprindex_0 + Cprindex_1 + Cprindex_2 + Cprindex_3 + Cprindex_4 + Cprindex_5 + Cprindex_6 +
                                    Cprindex_7 + Cprindex_8 + Cprindex_9;




                                if(Vægtsum / 11 == 11) { Console.WriteLine("Vaild CPR number "); Console.WriteLine("Vægtsumen er " + Vægtsum);  }
                                else { Console.WriteLine("Unvaild CPR number"); }
                            }
                                else { Console.WriteLine("Invalid day"); }
                            }
                            else
                            {
                                Console.WriteLine("Invalid month");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Unable to parse: " + dato_Time);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input format. Please enter in the format 'ddmmyy-xxxx'.");
                        Console.WriteLine("");
                    }
                }
            }
        }

    }








/*
                      string Grapfirst6number = Dato_Time.Substring(0, 5);
                      string Checklast4number = Dato_Time.Substring(7, 11);

                      if (Grapfirst6number.All(char.IsDigit))
                      {

                          if(Checklast4number.All(char.IsDigit))
                          {

                          }
                          else
                          {
                              Console.WriteLine("Forkert format input");
                          }

                      }
                      else
                      {
                          Console.WriteLine("Forkert format input");
                      }
                      */

// remove - streg to make  calcuating and check if its a number add it later to display it to the user
// check the first 6 are numbers and a gyldig dato
// check the last are numbers


/*
if ()
{


}

else
{
    Console.WriteLine("Not passed to datotime");
    Console.WriteLine("Forkert format indtast igen");
}


}

// lav en udregning med sidste sidste hvis talet er lige, udskriv kvinde
// hvis ulige tal udskriv mand


// test if(num % 2 == 0) {is lige}
// se numer ikke er lige 


// Indtast af CPR skal overholde regler med formatet  // format krav fx 220805-5345
// skal have den rigite længde og der skal være en - det rigte sted


*/









