﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SettingScheduleImportPro
/// </summary>
public class SettingScheduleImportPro
{
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    private string _DateType;
    public string DateType { get { return _DateType; } set { _DateType = value; } }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    private string _EmlServerID;
    public string EmlServerID { get { return _EmlServerID; } set { _EmlServerID = value; } }

    private string _EmlPortNo;
    public string EmlPortNo { get { return _EmlPortNo; } set { _EmlPortNo = value; } }

    private string _EmlSenderEmail;
    public string EmlSenderEmail { get { return _EmlSenderEmail; } set { _EmlSenderEmail = value; } }

    private string _EmlSenderPassword;
    public string EmlSenderPassword { get { return _EmlSenderPassword; } set { _EmlSenderPassword = value; } }

    private string _EmlSsl;
    public string EmlSsl { get { return _EmlSsl; } set { _EmlSsl = value; } }

    private string _EmlCredential;
    public string EmlCredential { get { return _EmlCredential; } set { _EmlCredential = value; } }

    private string _EmlCountDaysForSend;
    public string EmlCountDaysForSend { get { return _EmlCountDaysForSend; } set { _EmlCountDaysForSend = value; } }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    private string _TransactionBy;
    public string TransactionBy { get { return _TransactionBy; } set { _TransactionBy = value; } }

    private string _TransactionDate;
    public string TransactionDate { get { return _TransactionDate; } set { _TransactionDate = value; } }
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}