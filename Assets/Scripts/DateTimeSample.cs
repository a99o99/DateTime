using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Globalization;

public class DateTimeSample : MonoBehaviour
{
    void Start()
    {
        DateTime dateTime = new DateTime(2024, 01, 21);     // 년, 월, 일
        DateTime dateTime_second = new DateTime(2024, 01, 21, 22, 20, 30);     // 년, 월, 일, 시, 분, 초
        DateTime dateTime_millisecond = new DateTime(2024, 01, 21, 10, 20, 30, 500);     // 년, 월, 일, 시, 분, 초, 밀리초
        DateTime dateTime_kindLocal = new DateTime(2022, 1, 16, 10, 30, 45, 500, DateTimeKind.Local); // 년, 월, 일, 시, 분, 초, 밀리초, 특정 국가/지역의 시간대
        // DateTime dateTime_kindLocalCalendar = new DateTime(2022, 1, 16, 12, 30, 45, 500, DateTimeKind.Local, new GregorianCalendar());  // 년, 월, 일, 시, 분, 초, 밀리초, 특정 국가/지역의 시간대, 캘린더

        long currentTicks = DateTime.Now.Ticks;
        DateTime dateTime_ticks = new DateTime(currentTicks);

        Debug.Log("dateTime : "+ dateTime);
        Debug.Log("dateTime_second : "+ dateTime_second);
        Debug.Log("dateTime_millisecond : "+ dateTime_millisecond);
        Debug.Log("dateTime_kindLocal : "+ dateTime_kindLocal);

        Debug.Log("currentTicks : "+ currentTicks + ", dateTime_ticks : "+ dateTime_ticks);

        DateTime current = DateTime.Now;
        DateTime utcTime = DateTime.UtcNow;

        Debug.Log("current : "+ current);


        // year 
        string year_1 = current.ToString("y");  // => 2024년 1월
        string year_2 = current.ToString("yy");  // => 24
        string year_3 = current.ToString("yyyy");  // => 2024
        Debug.Log($"year check : {year_1}, {year_2}, {year_3}");


        // month 
        string month_1 = current.ToString("M");  // => 1월 22일
        string month_2 = current.ToString("MM");  // => 01
        string month_3 = current.ToString("MMM", new CultureInfo("en-US"));  // => 1월 (Jan)
        string month_4 = current.ToString("MMMM", new CultureInfo("en-US"));  // => 1월 (January)
        Debug.Log($"Month check : {month_1}, {month_2}, {month_3}, {month_4}");


        // day
        string day_1 = current.ToString("d");  // => 2024-01-22
        string day_2 = current.ToString("dd");  // => 22
        string day_3 = current.ToString("ddd", new CultureInfo("en-US"));  // => 월 (MON)
        string day_4 = current.ToString("dddd", new CultureInfo("en-US"));  // => 월요일 (Monday)
        Debug.Log($"day check : {day_1}, {day_2}, {day_3}, {day_4}");


        // hour
        string hour_1 = current.ToString("h tt");  // 3 오후   "h" 하나만 쓰면 못 읽음 
        string hour_2 = current.ToString("hh");  // 03
        string hour_3 = current.ToString("H tt");  // 15 오후   "H" 하나만 쓰면 못 읽음
        string hour_4 = current.ToString("HH");  // 15
        Debug.Log($"hour check : {hour_1}, {hour_2}, {hour_3}, {hour_4}");


        // minute
        string minute_1 = current.ToString("m");  // => 2024년 1월
        string minute_2 = current.ToString("mm");  // => 48
        Debug.Log($"minute check : {minute_1}, {minute_2}");


        // second
        string second_1 = current.ToString("s");  // => 2024-01-22T15:48:14
        string second_2 = current.ToString("ss");  // => 14
        Debug.Log($"second check : {second_1}, {second_2}");


        // am, pm
        string meridiem_1 = current.ToString("t");  // => 오후 3:48
        string meridiem_2 = current.ToString("tt");  // => 오후
        Debug.Log($"meridiem check : {meridiem_1}, {meridiem_2}");
        
    }
    
}
