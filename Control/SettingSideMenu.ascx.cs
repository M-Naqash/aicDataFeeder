﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Control_SettingSideMenu : System.Web.UI.UserControl
{
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    protected void Page_Load(object sender, EventArgs e)
    {
        FormSession.FillSession("", null);
        PermSideMenu();
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    protected void btnSideMenu_Click(object sender, EventArgs e)
    {
        LinkButton lb = (LinkButton)sender;
        Response.Redirect(lb.PostBackUrl);
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    private void PermSideMenu()
    {
        btnImportDBConfig.Enabled = FormSession.getPerm("USet");
        btnWorktimeSet.Enabled = FormSession.getPerm("USet");
        btnImportTimeSch.Enabled = FormSession.getPerm("USet");
        btnDatalogImport.Enabled = FormSession.getPerm("USet");
        btnEmailSetting.Enabled = FormSession.getPerm("USet");
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    public void RedirectPage()
    {
        PermSideMenu();
        foreach (Control ctrl in this.Controls)
        {
            if (ctrl is LinkButton)
            {
                LinkButton lb = (LinkButton)ctrl;
                string id = lb.ID;
                if (lb.Enabled) { Response.Redirect(lb.PostBackUrl); break; }
            }
        }
    }
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}