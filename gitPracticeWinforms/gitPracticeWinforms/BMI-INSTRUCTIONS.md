# BMI Calculator Rules

1. Let the user choose between **Metric** and **Standard** units.

2. For **Metric**:

   * Height is entered in centimeters.

   * Weight is entered in kilograms.

   * Convert height from centimeters to meters before calculating BMI.

   * Formula for conversion:

     **Height in meters = Height in centimeters ÷ 100**

   * BMI formula:

     **BMI = Weight in kilograms ÷ (Height in meters)²**

3. For **Standard**:

   * Height is entered in inches.
   * Weight is entered in pounds.
   * BMI formula:

     **BMI = 703 × Weight in pounds ÷ (Height in inches)²**

4. Height and weight must:

   * Contain valid numbers.
   * Be greater than zero.
   * Not be left blank.

5. Calculate the BMI using the selected measurement system.

6. Round the BMI result to one decimal place.

7. Classify the result:

   * Below 18.5: Underweight
   * 18.5 to 24.9: Normal weight
   * 25.0 to 29.9: Overweight
   * 30.0 and above: Obesity

8. Display both the BMI value and its category.

9. When the user changes the measurement system, clear the previous inputs and result.
