using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter.Views;

public partial class WeightPage : ContentPage
{
    private double KeyValue = 0;
    
    private double dbl_p2p = 1.0;
    private double dbl_p2k = 0.453593;
    private double dbl_p2o = 16;
    private double dbl_p2s = 0.0714286;
    private double dbl_p2g = 453.593;
    public WeightPage()
    {
        InitializeComponent();
        Title = "Weight Converter";
    }

    private void ClearWeight_OnClicked(object sender, EventArgs e)
    {
        txtGrams.Text = "";
        txtKilograms.Text = "";
        txtOunces.Text = "";
        txtPounds.Text = "";
        txtStones.Text = "";
    }

    private void ConvertWeight_OnClicked(object sender, EventArgs e)
    {
        txtGrams.Text = (KeyValue*dbl_p2g).ToString("g9");
        txtKilograms.Text = (KeyValue*dbl_p2k).ToString("g9");
        txtPounds.Text =(KeyValue*dbl_p2p).ToString("g9") ;
        txtOunces.Text =(KeyValue*dbl_p2o).ToString("g9");
        txtStones.Text =(KeyValue*dbl_p2s).ToString("g9");
        
    }

    private void TxtPounds_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //p2p
        double dblNumber;
        var isvalid= double.TryParse(txtPounds.Text, out dblNumber);
        if (isvalid && dblNumber!=0)
        {
            KeyValue = dblNumber / dbl_p2p;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtKilograms_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //p2k
        double dblNumber;
        var isvalid= double.TryParse(txtKilograms.Text, out dblNumber);
        if (isvalid && dblNumber!=0)
        {
            KeyValue = dblNumber / dbl_p2k;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtGrams_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //p2g
        double dblNumber;
        var isvalid= double.TryParse(txtGrams.Text, out dblNumber);
        if (isvalid && dblNumber!=0)
        {
            KeyValue = dblNumber / dbl_p2g;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtOunces_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //p2o
        double dblNumber;
        var isvalid= double.TryParse(txtOunces.Text, out dblNumber);
        if (isvalid && dblNumber!=0)
        {
            KeyValue = dblNumber / dbl_p2o;
        }
        else
        {
            KeyValue = 0;
        }
    }

    private void TxtStones_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        //p2s
        double dblNumber;
        var isvalid= double.TryParse(txtStones.Text, out dblNumber);
        if (isvalid && dblNumber!=0)
        {
            KeyValue = dblNumber / dbl_p2s;
        }
        else
        {
            KeyValue = 0;
        }
    }
}