Imports System.Xml
Public Class Form1

    Public Enum KurKodu As Byte

        USD
        CAD
        DKK
        SEK
        NOK
        CHF
        JPY
        SAR
        KWD
        AUD
        EUR
        GBP
        IRR
        SYP
        JOG
        BGL
        ROL
        ILS

    End Enum

    Public Enum Tur As Byte

        ForexBuying '//Döviz alış
        ForexSelling '//Döviz satış
        BanknoteBuying '//Efektif  alış
        BanknoteSelling ' //Efektif satış

    End Enum
    Private Sub btn_kur_al_Click(sender As Object, e As EventArgs) Handles btn_kur_al.Click


        Dim dovizBilgi As New XmlDocument

        Dim ds As New DataSet

        dovizBilgi.Load("http://www.tcmb.gov.tr/kurlar/today.xml")

        '        Dim DovizOku As XmlTextReader(dovizBilgi)

        Dim dovizler As XmlNodeList
        For i = 0 To 17
            dovizler.dovizBilgi.SelectNodes("/Tarih_Date/Currency[@Kod ='" + i.ToString + "']/" + "ForexBuying")
        Next


        'dovizBilgi.SelectNodes("/Tarih_Date/Currency[@Kod ='" + "USD" + "']/" + "ForexBuying")

        'ds.ReadXml(dovizBilgi)

        'MsgBox(tekDoviz.Item(0).InnerXml.ToString())
    End Sub
End Class
