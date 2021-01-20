package salesPerson;

import java.text.DecimalFormat;

//Author: Michael Harrison

/*Sales calculation program to detect commission received for salesman.
 * Compares 2 salesman
 */

import java.util.*;

public class Commission {

	double sal = 50000;
	double curCom = .05;
	double accelFac = 1.5;
	double salCom;
	double saleChange;
	double comTarget = .8;
	double salesTarget = 110000;
	double annualSales;
	String salesName;
	
	String salesName2;
	double annualSales2;
	double salCom2;
	double saleChange2;
	double curCom2;
	
	double salesDiff;
	
	
	public void comSales(){
		
		Scanner scanName = new Scanner (System.in);
		
		Scanner scanName2 = new Scanner (System.in);
		
		Scanner scan = new Scanner(System.in);	
		
		Scanner scan2 = new Scanner(System.in);														
		
		System.out.println("Please enter the name of the first salesman: ");
			salesName = scanName.next();
			
		System.out.println("Please enter the first sales figure: ");
			
		while (!scan.hasNextDouble()){														//Check for improper input
			System.out.println("Please only enter numbers.");
			scan.nextLine();
		}
		
		 annualSales = scan.nextDouble();

		System.out.println("Please enter the name of the next salesman: ");
			salesName2 = scanName2.next();
			
		System.out.println("Please enter the second sales figure: ");
			
		while (!scan2.hasNextDouble()){
			System.out.println("Please only enter numbers.");
			scan2.nextLine();
		}
		
		 annualSales2 = scan2.nextDouble();
			
		 	scanName.close();
		 	scanName2.close();
			scan.close();
			scan2.close();


			
				if (annualSales >= salesTarget * comTarget && annualSales < salesTarget){				//Check for commission
					
					curCom = .05;
					
				} else if (annualSales >= salesTarget){												
					
					curCom = .075;		
					
				} else if (annualSales < salesTarget * comTarget){									
					
					curCom = 0.0;
				}
				
				if (annualSales >= salesTarget * comTarget && annualSales < salesTarget){			
					
					curCom2 = .05;
					
				} else if (annualSales >= salesTarget){												
					
					curCom2 = .075;		
					
				} else if (annualSales < salesTarget * comTarget){									
					
					curCom2 = 0.0;
				}
					
					saleChange = annualSales * curCom;										  		//Alter sales to compensation
					salCom = sal + saleChange;														//Create total salary with commission
					System.out.printf("Total pay with commission is: " + "$%.2f" , salCom);
					
					int temp = (int) annualSales;
					int lengths= (int) Math.ceil((annualSales*.5)/5000);							
					
					Table[] tables = new Table[lengths];											
					
						for (int counter  = 0; counter < lengths; counter++){						//for loop to generate table
							Table table = new Table();
							table.setPotSales(temp);												
							table.setPotComp((int) (temp * curCom));
							temp = temp + 5000;
							
							
							tables[counter] = table;
						}

					System.out.println("\nSales\t\tCompensation");
			        System.out.println("--------------------------------");


		    for (int i = 0; i < lengths; i++) {
		        System.out.println(tables[i].getPotSales() + "\t\t" + tables[i].getPotComp());		
		    }
		    
		    
		    
		    
		    DecimalFormat df = new DecimalFormat("##.00");											//Formatter for numbers to string
		    
		    salesDiff = annualSales - annualSales2;
		    
		    if (salesDiff > 0 )
		    {
		    	String salesFormat = df.format(salesDiff);
		    	System.out.printf("\n\n" + salesName + " has more sales. " + salesName2 +  " needs at least $" +  salesFormat +  " more in sales to match.");
		    	
		    }else if (salesDiff < 0){
		    	
		   	salesDiff = salesDiff * -1;
	    	String salesFormat = df.format(salesDiff);
		    	System.out.printf("\n\n" + salesName2 + " has more sales. " + salesName +  " needs at least $" +  salesFormat + " more in sales to match.");
		    	
		    } else {
		    	
		    	System.out.printf("\n\nSales are equal between the two.");

		    	
		    }
		    
		
		}
	}
//}
		
	
