using System;

class Program{
    static void Main(string[] args){

      // Exam1Water();
       Exam2Money();

    }

    static void Exam1Water(){
        
         Console.WriteLine("Enter Vmax : ");
        float vMax = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter Vdrink : ");
        float vDrink = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter Vfill : ");
        float vFill = float.Parse(Console.ReadLine());

 
        Console.WriteLine("Enter TDrink : ");
        float tDrink = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter Tfill : ");
        float tFill = float.Parse(Console.ReadLine());

        Console.WriteLine("Enter Tday : ");
        float tDay = float.Parse(Console.ReadLine());

        
        float sumDrink = 0;
        float sumFill = 0;
        float vCurrent = vMax;
        float countTFIll = tFill ;
        float countTDrink = tDrink;
        float hourCount = 0;

        bool isOverFlow = false;

         while(true){
                //  Console.WriteLine("Hour : " + hourCount);

                if(vCurrent <= 0 ){
            
                    Console.WriteLine("Not Enough Water");
                    break;
                }

                if(hourCount > tDay){
                    break;
                }

               
                 if(hourCount%tDrink == 0 && hourCount != 0){
                  //  Console.WriteLine("Drink");
                       vCurrent -= vDrink;
                 }
                 if(hourCount%tFill == 0 && hourCount != 0){
                   // Console.WriteLine("Fill");
                    vCurrent += vFill;
                    if(vCurrent > vMax){
                          vCurrent = vMax;
                          isOverFlow = true;
                    }
                }
                //Console.WriteLine("count Drink : "+countTDrink);
                //Console.WriteLine("count Fill : "+countTFIll);
               
               // Console.WriteLine("VCurrent : "+vCurrent);
                countTDrink += tDrink;
                countTFIll += tFill;
                hourCount++;
          
         
         }

         if(vCurrent > 0){
            if(vCurrent < 0.001){
                vCurrent = 0;
            }
            Console.WriteLine("Enough Water, " + vCurrent + " left" );
         }

         if(isOverFlow){
            Console.WriteLine("Overflow Water");
         }

   
  


        
    }

    struct Account{
        public float balance1;
        public float balance2;
        public float balance3;
        public float left;

        public Account(float balance1,float balance2,float balance3){
            this.balance1 = balance1;
            this.balance2 = balance2;
            this.balance3 = balance3;
        }
    }
    static void Exam2Money(){

        Account acc = new Account(0,0,0);
        
        int count = 1;
        while(true){
            float num = float.Parse(Console.ReadLine());

            if(num <= 0){
                break;
            }

            if(count == 1){
                acc.balance1 += num;
            }else if(count == 2){
                acc.balance2 += num;
            }else if(count == 3){
                acc.balance3 += num;
            }

            count++;
            
        }

        Console.WriteLine("Balance 1 : {0}, Balance 2 : {1}, Balance 3 : {2}",acc.balance1,acc.balance2,acc.balance3);
    }
}

