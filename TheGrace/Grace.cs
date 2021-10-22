using System;

namespace TheGrace
{
    public class Grace
    {
        private string name;    //The Name of THE GRACE
        public string Name{
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
                this.Worth = 0;
                this.Danger = 0;
            }
        }

        private int worth;      //How much THE GRACE is worth
        public int Worth
        {
            get
            {
                return this.worth;
            }
            set
            {
                //Set Worth to ammount of 'a' + 'A'x2
                int aCounter = 0;
                foreach (char letter in this.Name)
                {
                    if(letter == 'a')
                    {
                        aCounter++;
                    }
                    if(letter == 'A')
                    {
                        aCounter += 2;
                    }   
                }
                
                this.worth = aCounter;
            }
        }
        private int danger;     //How dangerous THE GRACE is
        public int Danger
        {
            get
            {
                return this.danger;
            }
            set
            {
               foreach (char letter in this.Name)
                {
                    if(letter == 'f' || letter == 'F')
                    {
                        danger = 666;
                        return;
                    }
                    danger = 0;
                } 
            }
        }
    }
}
