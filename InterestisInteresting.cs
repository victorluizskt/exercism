﻿using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if(balance < 0) return 3.213f;
        if(balance >= 0 && balance < 1000) return 0.5f;
        if(balance >= 1000 && balance < 5000) return 1.621f;
        return 2.475f;
    }

    public static decimal Interest(decimal balance)
    {
        return (decimal)InterestRate(balance) * balance * 0.01M;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return Interest(balance) + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        decimal sum = 0;
        while(balance < targetBalance)
        {
            sum = AnnualBalanceUpdate(balance) - balance;
            balance += sum;
            years++;
            sum = 0;
        }

        return years;
    }
}
