Imports System.Xml

Public Class Main
    Private Sub btnGetTheWeather_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetTheWeather.Click
 
        Dim reader As XmlReader = XmlReader.Create(New StringReader(xmlData))

    Public Overridable Function ReadToFollowing( _
ByVal name As String _
) As Boolean

        Using reader As XmlReader = XmlReader.Create("books.xml")
            reader.ReadToFollowing("book")
            Do
                Console.WriteLine("ISBN: {0}", reader.GetAttribute("ISBN"))
            Loop While reader.ReadToNextSibling("book")
        End Using

    End Function

    <yweather:condition  text="Mostly Cloudy"  code="28"  temp="65"  date="Fri, 01 Oct 2010 3:53 pm EDT" />

End Class
