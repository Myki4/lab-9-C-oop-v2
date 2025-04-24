using System;

public class Date
{
    private int _day;
    private int _month;
    private int _year;

    public Date(int day, int month, int year)
    {
        SetDate(day, month, year);
    }

    public void SetDate(int day, int month, int year)
    {
        if (!IsValidDate(day, month, year))
        {
            throw new ArgumentException("Недопустима дата.");
        }
        _day = day;
        _month = month;
        _year = year;
    }

    private bool IsValidDate(int day, int month, int year)
    {
        if (year < 1 || month < 1 || month > 12 || day < 1)
        {
            return false;
        }

        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        return day <= daysInMonth[month - 1];
    }

    public void SetDay(int day)
    {
        SetDate(day, _month, _year);
    }

    public void SetMonth(int month)
    {
        SetDate(_day, month, _year);
    }

    public void SetYear(int year)
    {
        SetDate(_day, _month, year);
    }

    public void AddDays(int days)
    {
        DateTime dt = new DateTime(_year, _month, _day).AddDays(days);
        SetDate(dt.Day, dt.Month, dt.Year);
    }

    public void AddMonths(int months)
    {
        DateTime dt = new DateTime(_year, _month, _day).AddMonths(months);
        SetDate(dt.Day, dt.Month, dt.Year);
    }

    public void AddYears(int years)
    {
        DateTime dt = new DateTime(_year, _month, _day).AddYears(years);
        SetDate(dt.Day, dt.Month, dt.Year);
    }

    public override string ToString()
    {
        return $"{_day:D2}/{_month:D2}/{_year}";
    }
}