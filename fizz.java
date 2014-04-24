/* Name: Weems
 *  File: Fizz.java
 *  Purpose: To Demonstrate the Execution of a 
 *           Fizz/Buzz/FizzBuzz Implementation
 *  Date: 24 April 2014
 */

package fizz;

/**
 *
 * @author weems
 */
public class Fizz {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
        int fizzcalc = 0;
        for (int i = 0; i < 100; i++)
        {
            if(i%3==0 && i%5==0)
            {
               System.out.println( Integer.toString(i + 1) + " -- Fizz Buzz!");
            }
            else if(i%3==0)
                    {
                      System.out.println( Integer.toString(i + 1) + " -- Fizz!");  
                    }
            else if(i%5==0)
            {
                System.out.println( Integer.toString(i + 1) + " -- Buzz!");
            }
            
        }
        System.out.println("This Simulation of the Fizz or the Buzz or the combined FizzBuzz is now Complete");
    }
    
}
