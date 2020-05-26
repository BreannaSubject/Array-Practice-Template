using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArrayPractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            // Create 2 arrays to hold 10 values each
            int[] array1 = new int[10];
            int[] array2 = new int[10];

            // variables that can be used to determine outcomes of questions
            int samePosition = 0;
            int max;
            double average;
            int averageSum = 0;
            int even = 0;
            int three = 0;


            Random randGen = new Random();

            //1. Generate random values for both pre-created arrays
            for (int i = 0; i < array1.Length; i++)
            {
                
                array1[i] = randGen.Next(0, 10);
                array1Output.Text += Convert.ToString(array1[i]) + " ";
                averageSum += array1[i];
                average = averageSum / 10;
                averageOutput.Text = average.ToString ("0.0");
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    even += array1[i];
                }

                if (array1[i] == 3)
                {
                    three++;
                }

                evenOutput.Text = Convert.ToString(even);
                threeOutput.Text = Convert.ToString(three);

            }
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = randGen.Next(0, 10);
                array2Output.Text += Convert.ToString(array2[i]) + " ";
            }
            //2. Display array 1
            //3. Display array 2
            //4. Display array 1 in reverse order
           for (int i = 0; i < array1.Length; i++)
            {
                Array.Reverse(array1);
                reverseOutput.Text += Convert.ToString(array1[i]) + " ";
                max = array1[0];

                if (array1[i] > max)
                {
                    max = array1[i];
                }

                maxOutput.Text = Convert.ToString(max);
            }

           for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] == array2[i])
                {
                    samePosition++; 
                }
                matchOutput.Text = Convert.ToString(samePosition);
            }
            //5. Determine and display the largest value in array 1          
            //6.Determine and display the average of all values in array 1
            //7. Determine and display the sum of all even values in array 1
            //8. Determine and display the number of 3s in array 1
            //9. Determine and display how many matching numbers in matching positions between the 2 arrays there are


            // ----------------------
            // ##### ENRICHMENT #####
            // ----------------------


            //1. Determine and display at what index is the first 0 in array 1, (show "null" if no 0 exists)


            //2. swap and display all values between array1 and array2

        }
    }
}
