using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using System.Globalization;

public class MonthCalendar : MonoBehaviour
{
    public TextMeshProUGUI textYear;
    public TextMeshProUGUI textMonth;
    public TextMeshProUGUI textTime;

    public DateTime currentDateTime = DateTime.Now;

    int daysInMonth = 0;
    public DateTime firstDay;
    public DateTime lastDay;
    public List<DayElement> days;

    void Start()
    {
        InvokeRepeating("UpdateTime", 0, 1);
        InitMonth(currentDateTime);
    }

    void InitMonth(DateTime __dateTime)
    {
        Debug.Log(__dateTime);
        textYear.text = __dateTime.ToString("yyyy");        // 연도 4자리 숫자 셋팅
        textMonth.text = __dateTime.ToString("MMMM", new CultureInfo("en-US"));     // 달 영어 이름으로 셋팅

        daysInMonth = (int)DateTime.DaysInMonth(__dateTime.Year, __dateTime.Month);

        Debug.Log("daysInMonth check : " + daysInMonth);

        firstDay = new DateTime(__dateTime.Year, __dateTime.Month, 1);
        lastDay = firstDay.AddMonths(1).AddDays(-1);

        int firstDayOfWeek = (int)firstDay.DayOfWeek;

        Debug.Log($"first, last day check : {(int)firstDay.DayOfWeek}, {lastDay.DayOfWeek}");

        for(int i = 0; i < days.Count; i++)
        {
            days[i].gameObject.SetActive(false);
            if(i >= firstDayOfWeek && i <= daysInMonth + firstDayOfWeek - 1)
            {   
                days[i].gameObject.SetActive(true);
                days[i].Init(i, firstDayOfWeek);
            }
        }
    }

    /// <summary>
    /// 다음 달 보기
    /// </summary>
    public void OnClickNextMonth()
    {
        DateTime TargetDateTime = currentDateTime.AddMonths(1);
        InitMonth(TargetDateTime);
        currentDateTime = TargetDateTime;
    }

    /// <summary>
    /// 이전 달 보기
    /// </summary>
    public void OnClickPrevMonth()
    {
        DateTime TargetDateTime = currentDateTime.AddMonths(-1);
        InitMonth(TargetDateTime);
        currentDateTime = TargetDateTime;
    }

    /// <summary>
    /// 현재 달 보기
    /// </summary>
    public void OnClickCurrentMonth()
    {
        currentDateTime = DateTime.Now;
        InitMonth(currentDateTime);
    }

    void UpdateTime()
    {
        DateTime currentTime = DateTime.Now;
        textTime.text = currentTime.ToString(@"hh:mm:ss tt", new CultureInfo("es-US"));
    }
}
