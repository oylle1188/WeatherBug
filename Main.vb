Imports System.Xml



Public Class Main
    Private Sub btnGetTheWeather_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetTheWeather.Click
 
        Dim reader As XmlReader = XmlReader.Create("http://weather.yahooapis.com/forecastrss?w=2502265")

        reader.ReadToFollowing("yweather:condition")
        Dim temp As String = reader.GetAttribute("temp")
        MessageBox.Show("The temp is: " + temp)

    End sub


End Class
