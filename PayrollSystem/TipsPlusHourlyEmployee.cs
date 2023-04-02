// GRADING ID HERE: Kelechi Ragland 5379658

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Make the following changes/additions:
// 1. TipsPlusHourlyEmployee IS-A HourlyEmployee
// 2. Add public decimal property named TotalTips with get and set accessors
//    for the new field. Be sure to validate the value being set to ensure
//    that it is non-negative. Otherwise, throw an ArgumentOutOfRangeException.
// 3. Add public decimal property named TipTake with get and set accessors for
//    the new field. Be sure to validate the value being set to ensure that
//    it is between 0-1 (inclusive). Otherwise, throw an ArgumentOutOfRangeException.
// 4. Add a constructor that initializes the TipsPlusHourlyEmployee with the
//    given values for first name, last name, social security number,
//    hourly wage, hours worked, total tips, and tip take percentage.
// 5. Override method Earnings so that it calculates the employee’s earnings
//    by adding their tip take percentage of the total tips earned (the product
//    of their tip take and total tips) onto their earnings as an hourly employee.
//    You must use base.Earnings() in your implementation.
// 6. Override the ToString method to return a String that will display all
//    data fields neatly. You must use base.ToString() in your implementation.
public class TipsPlusHourlyEmployee : HourlyEmployee
{
    private decimal tipTotal;
    private decimal tipTale;

    public TipsPlusHourlyEmployee(string firstName, string lastName,
      string socialSecurityNumber, decimal hourlyWage,
      decimal hoursWorked, decimal totalTips, decimal tipTake) : base(firstName, lastName,
       socialSecurityNumber, hourlyWage,
      hoursWorked)
    {
        TotalTips = totalTips;
        TipTake = tipTake;
    }

    public decimal TotalTips
    {
        get { return tipTotal; }
        set
        {
            if (value >= 0)
            {
                tipTotal = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"{nameof(TotalTips)}", value, $"{nameof(TotalTips)} must be >= 0");
            }
        }
    }

    public decimal TipTake
    {
        get { return tipTale; }
        set
        {
            if (value >= 0 && value <= 1)
            {
                tipTale = value;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"{nameof(TipTake)}", value, $"{nameof(TipTake)} must be >= 0");
            }
        }
    }

    public override decimal Earnings()
    {
        return (TipTake * TotalTips) + base.Earnings();
    }

    public override string ToString()
    {
        string NL = Environment.NewLine;

        return $"Tips{base.ToString()}{NL}Total Tips: {TotalTips}{NL}Tip Take: {TipTake}";
    }


}

