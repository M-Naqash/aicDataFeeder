﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for NationalityPro
/// </summary>
public class NationalityPro
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    private string _DateType;
    public string DateType { get { return _DateType; } set { _DateType = value; } }
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    private string _PKID;
    public string PKID { get { return _PKID; } set { _PKID = value; } }

    private string _NameEn;
    public string NameEn { get { return _NameEn; } set { _NameEn = value; } }

    private string _NameAr;
    public string NameAr { get { return _NameAr; } set { _NameAr = value; } }

    private string _CountryNameEn;
    public string CountryNameEn { get { return _CountryNameEn; } set { _CountryNameEn = value; } }

    private string _CountryNameAr;
    public string CountryNameAr { get { return _CountryNameAr; } set { _CountryNameAr = value; } }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    private string _TransactionBy;
    public string TransactionBy { get { return _TransactionBy; } set { _TransactionBy = value; } }

    private string _TransactionDate;
    public string TransactionDate { get { return _TransactionDate; } set { _TransactionDate = value; } }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}