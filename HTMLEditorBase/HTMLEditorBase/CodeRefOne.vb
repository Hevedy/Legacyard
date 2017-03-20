'-----------------------------------------------------------------------------
' Copyright (c) 2014-2017 Hevedy <github.com/Hevedy>
'
' Permission is hereby granted, free of charge, to any person obtaining a copy
' of this software and associated documentation files (the "Software"), to
' deal in the Software without restriction, including without limitation the
' rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
' sell copies of the Software, and to permit persons to whom the Software is
' furnished to do so, subject to the following conditions:
'
' The above copyright notice and this permission notice shall be included in
' all copies or substantial portions of the Software.
'
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
' IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
' FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
' AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
' LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
' FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
' IN THE SOFTWARE.
'----------------------------------------------------------------------------

Module CodeRefOne

    '---------------------
    'Features
    '---------------------


    Public Sub EX_ASCII_ISO_Syn_To()

        'ISO 8859-1 Characters
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("À", "&#192;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Á", "&#193;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Â", "&#194;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Ã", "&#195;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Ä", "&#196;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Å", "&#197;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Æ", "&#198;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Ç", "&#199;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("È", "&#200;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("É", "&#201;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Ê", "&#202;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Ë", "&#203;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Ì", "&#204;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Í", "&#205;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Î", "&#206;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Ï", "&#207;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Ð", "&#208;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Ñ", "&#209;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Ò", "&#210;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Ó", "&#211;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Ô", "&#212;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Õ", "&#213;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Ö", "&#214;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Ø", "&#216;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Ù", "&#217;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Ú", "&#218;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Û", "&#219;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Ü", "&#220;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Ý", "&#221;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("Þ", "&#222;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ß", "&#223;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("à", "&#224;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("á", "&#225;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("â", "&#226;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ã", "&#227;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ä", "&#228;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("å", "&#229;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("æ", "&#230;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ç", "&#231;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("è", "&#232;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("é", "&#233;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ê", "&#234;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ë", "&#235;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ì", "&#236;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("í", "&#237;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("î", "&#238;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ï", "&#239;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ð", "&#240;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ñ", "&#241;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ò", "&#242;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ó", "&#243;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ô", "&#244;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("õ", "&#245;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ö", "&#246;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ø", "&#248;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ù", "&#249;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ú", "&#250;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("û", "&#251;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ü", "&#252;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ý", "&#253;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("þ", "&#254;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ÿ", "&#255;")

        'ISO 8859-1 Symbols
        'MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace(" ", "&#160;") 'non-breaking space (&nbsp;) this is auto
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("¡", "&#161;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("¢", "&#162;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("£", "&#163;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("¤", "&#164;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("¥", "&#165;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("¦", "&#166;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("§", "&#167;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("¨", "&#168;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("©", "&#169;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("ª", "&#170;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("«", "&#171;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("¬", "&#172;")
        'MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("-", "&#173;") 'soft hyphen (&shy;) No idea if this like this...
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("®", "&#174;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("¯", "&#175;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("°", "&#176;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("±", "&#177;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("²", "&#178;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("³", "&#179;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("´", "&#180;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("µ", "&#181;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("¶", "&#182;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("·", "&#183;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("¸", "&#184;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("¹", "&#185;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("º", "&#186;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("»", "&#187;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("¼", "&#188;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("½", "&#189;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("¾", "&#190;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("¿", "&#191;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("×", "&#215;")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("÷", "&#247;")

        'ISO-8859-1 Reserved Characters in HTML
        'No idea if this is needed but is here
        'MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace(""", "&#34;") This is a example of the insane code How??
        'MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("'", "&#39;")
        'MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&", "&#38;")
        'MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("<", "&#60;") If add this, you will have a problem
        'MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace(">", "&#62;")


    End Sub

    Public Sub EX_ASCII_ISO_Syn_Reset()

        'ISO 8859-1 Characters
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#192;", "À")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#193;", "Á")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#194;", "Â")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#195;", "Ã")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#196;", "Ä")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#197;", "Å")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#198;", "Æ")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#199;", "Ç")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#200;", "È")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#201;", "É")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#202;", "Ê")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#203;", "Ë")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#204;", "Ì")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#205;", "Í")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#206;", "Î")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#207;", "Ï")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#208;", "Ð")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#209;", "Ñ")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#210;", "Ò")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#211;", "Ó")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#212;", "Ô")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#213;", "Õ")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#214;", "Ö")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#216;", "Ø")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#217;", "Ù")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#218;", "Ú")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#219;", "Û")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#220;", "Ü")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#221;", "Ý")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#222;", "Þ")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#223;", "ß")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#224;", "à")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#225;", "á")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#226;", "â")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#227;", "ã")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#228;", "ä")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#229;", "å")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#230;", "æ")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#231;", "ç")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#232;", "è")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#233;", "é")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#234;", "ê")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#235;", "ë")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#236;", "ì")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#237;", "í")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#238;", "î")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#239;", "ï")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#240;", "ð")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#241;", "ñ")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#242;", "ò")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#243;", "ó")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#244;", "ô")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#245;", "õ")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#246;", "ö")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#248;", "ø")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#249;", "ù")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#250;", "ú")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#251;", "û")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#252;", "ü")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#253;", "ý")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#254;", "þ")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#255;", "ÿ")

        'ISO 8859-1 Symbols
        'MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#160;", " ") 'non-breaking space (&nbsp;) this is auto
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#161;", "¡")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#162;", "¢")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#163;", "£")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#164;", "¤")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#165;", "¥")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#166;", "¦")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#167;", "§")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#168;", "¨")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#169;", "©")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#170;", "ª")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#171;", "«")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#172;", "¬")
        'MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#173;", "-") 'soft hyphen (&shy;) No idea if this like this...
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#174;", "®")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#175;", "¯")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#176;", "°")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#177;", "±")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#178;", "²")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#179;", "³")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#180;", "´")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#181;", "µ")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#182;", "¶")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#183;", "·")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#184;", "¸")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#185;", "¹")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#186;", "º")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#187;", "»")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#188;", "¼")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#189;", "½")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#190;", "¾")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#191;", "¿")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#215;", "×")
        MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#247;", "÷")

        'ISO-8859-1 Reserved Characters in HTML
        'No idea if this is needed but is here
        'MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#34;", """) This is a example of the insane code How??
        'MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#39;", "'")
        'MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#38;", "&")
        'MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#60;", "<") If add this, you will have a problem
        'MainWindow.RTBE_First.Text = MainWindow.RTBE_First.Text.Replace("&#62;", ">")

    End Sub

    Public Sub EX_BasicColorSintax_Syntax()

        If MainWindow.RTBE_First.Text.Contains("<html>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<html>")
            MainWindow.RTBE_First.SelectionColor = Color.Blue
        End If
        If MainWindow.RTBE_First.Text.Contains("</html>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</html>")
            MainWindow.RTBE_First.SelectionColor = Color.Blue
        End If
        If MainWindow.RTBE_First.Text.Contains("<body>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<body>")
            MainWindow.RTBE_First.SelectionColor = Color.Brown
        End If
        If MainWindow.RTBE_First.Text.Contains("</body>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</body>")
            MainWindow.RTBE_First.SelectionColor = Color.Brown
        End If
        If MainWindow.RTBE_First.Text.Contains("<td>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<td>")
            MainWindow.RTBE_First.SelectionColor = Color.Brown
        End If
        If MainWindow.RTBE_First.Text.Contains("</td>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</td>")
            MainWindow.RTBE_First.SelectionColor = Color.Brown
        End If
        If MainWindow.RTBE_First.Text.Contains("<a>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<a>")
            MainWindow.RTBE_First.SelectionColor = Color.Red
        End If
        If MainWindow.RTBE_First.Text.Contains("</a>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</a>")
            MainWindow.RTBE_First.SelectionColor = Color.Red
        End If
        If MainWindow.RTBE_First.Text.Contains("<ul>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<ul>")
            MainWindow.RTBE_First.SelectionColor = Color.Red
        End If
        If MainWindow.RTBE_First.Text.Contains("</ul>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</ul>")
            MainWindow.RTBE_First.SelectionColor = Color.Red
        End If
        If MainWindow.RTBE_First.Text.Contains("<h1>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<h1>")
            MainWindow.RTBE_First.SelectionColor = Color.Orange
        End If
        If MainWindow.RTBE_First.Text.Contains("</h1>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</h1>")
            MainWindow.RTBE_First.SelectionColor = Color.Orange
        End If
        If MainWindow.RTBE_First.Text.Contains("<h2>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<h2>")
            MainWindow.RTBE_First.SelectionColor = Color.Orange
        End If
        If MainWindow.RTBE_First.Text.Contains("</h2>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</h2>")
            MainWindow.RTBE_First.SelectionColor = Color.Orange
        End If
        If MainWindow.RTBE_First.Text.Contains("<h3>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<h3>")
            MainWindow.RTBE_First.SelectionColor = Color.Orange
        End If
        If MainWindow.RTBE_First.Text.Contains("</h3>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</h3>")
            MainWindow.RTBE_First.SelectionColor = Color.Orange
        End If
        If MainWindow.RTBE_First.Text.Contains("<h4>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<h4>")
            MainWindow.RTBE_First.SelectionColor = Color.Orange
        End If
        If MainWindow.RTBE_First.Text.Contains("</h4>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</h4>")
            MainWindow.RTBE_First.SelectionColor = Color.Orange
        End If
        If MainWindow.RTBE_First.Text.Contains("<h5>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<h5>")
            MainWindow.RTBE_First.SelectionColor = Color.Orange
        End If
        If MainWindow.RTBE_First.Text.Contains("</h5>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</h5>")
            MainWindow.RTBE_First.SelectionColor = Color.Orange
        End If
        If MainWindow.RTBE_First.Text.Contains("<h6>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<h6>")
            MainWindow.RTBE_First.SelectionColor = Color.Orange
        End If
        If MainWindow.RTBE_First.Text.Contains("</h6>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</h6>")
            MainWindow.RTBE_First.SelectionColor = Color.Orange
        End If
        If MainWindow.RTBE_First.Text.Contains("<p>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<p>")
            MainWindow.RTBE_First.SelectionColor = Color.Violet
        End If
        If MainWindow.RTBE_First.Text.Contains("</p>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</p>")
            MainWindow.RTBE_First.SelectionColor = Color.Violet
        End If
        If MainWindow.RTBE_First.Text.Contains("<title>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<title>")
            MainWindow.RTBE_First.SelectionColor = Color.Green
        End If
        If MainWindow.RTBE_First.Text.Contains("</title>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</title>")
            MainWindow.RTBE_First.SelectionColor = Color.Green
        End If
        If MainWindow.RTBE_First.Text.Contains("<li>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<li>")
            MainWindow.RTBE_First.SelectionColor = Color.Pink
        End If
        If MainWindow.RTBE_First.Text.Contains("</li>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</li>")
            MainWindow.RTBE_First.SelectionColor = Color.Pink
        End If
        If MainWindow.RTBE_First.Text.Contains("<table>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<table>")
            MainWindow.RTBE_First.SelectionColor = Color.SkyBlue
        End If
        If MainWindow.RTBE_First.Text.Contains("</table>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</table>")
            MainWindow.RTBE_First.SelectionColor = Color.SkyBlue
        End If
        If MainWindow.RTBE_First.Text.Contains("<hx>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<hx>")
            MainWindow.RTBE_First.SelectionColor = Color.YellowGreen
        End If
        If MainWindow.RTBE_First.Text.Contains("</hx>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</hx>")
            MainWindow.RTBE_First.SelectionColor = Color.YellowGreen
        End If
        If MainWindow.RTBE_First.Text.Contains("<img>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<img>")
            MainWindow.RTBE_First.SelectionColor = Color.Gold
        End If
        If MainWindow.RTBE_First.Text.Contains("</img>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</img>")
            MainWindow.RTBE_First.SelectionColor = Color.Gold
        End If
        If MainWindow.RTBE_First.Text.Contains("<b>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<b>")
            MainWindow.RTBE_First.SelectionColor = Color.LimeGreen
        End If
        If MainWindow.RTBE_First.Text.Contains("</b>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</b>")
            MainWindow.RTBE_First.SelectionColor = Color.LimeGreen
        End If
        If MainWindow.RTBE_First.Text.Contains("<tr>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<tr>")
            MainWindow.RTBE_First.SelectionColor = Color.LimeGreen
        End If
        If MainWindow.RTBE_First.Text.Contains("</tr>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</tr>")
            MainWindow.RTBE_First.SelectionColor = Color.LimeGreen
        End If
        If MainWindow.RTBE_First.Text.Contains("<i>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<i>")
            MainWindow.RTBE_First.SelectionColor = Color.ForestGreen
        End If
        If MainWindow.RTBE_First.Text.Contains("</i>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</i>")
            MainWindow.RTBE_First.SelectionColor = Color.ForestGreen
        End If
        If MainWindow.RTBE_First.Text.Contains("<u>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<u>")
            MainWindow.RTBE_First.SelectionColor = Color.Fuchsia
        End If
        If MainWindow.RTBE_First.Text.Contains("</u>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</u>")
            MainWindow.RTBE_First.SelectionColor = Color.Fuchsia
        End If
        If MainWindow.RTBE_First.Text.Contains("<font size>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<font size>")
            MainWindow.RTBE_First.SelectionColor = Color.DodgerBlue
        End If
        If MainWindow.RTBE_First.Text.Contains("</font size>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</font size>")
            MainWindow.RTBE_First.SelectionColor = Color.DodgerBlue
        End If
        If MainWindow.RTBE_First.Text.Contains("<font color>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<font color>")
            MainWindow.RTBE_First.SelectionColor = Color.Firebrick
        End If
        If MainWindow.RTBE_First.Text.Contains("</font color>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</font color>")
            MainWindow.RTBE_First.SelectionColor = Color.Firebrick
        End If
        If MainWindow.RTBE_First.Text.Contains("<center>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<center>")
            MainWindow.RTBE_First.SelectionColor = Color.DeepSkyBlue
        End If
        If MainWindow.RTBE_First.Text.Contains("</center>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</center>")
            MainWindow.RTBE_First.SelectionColor = Color.DeepSkyBlue
        End If
        If MainWindow.RTBE_First.Text.Contains("<style>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<style>")
            MainWindow.RTBE_First.SelectionColor = Color.DarkSalmon
        End If
        If MainWindow.RTBE_First.Text.Contains("</style>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</style>")
            MainWindow.RTBE_First.SelectionColor = Color.DarkSalmon
        End If
        If MainWindow.RTBE_First.Text.Contains("<ol>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<ol>")
            MainWindow.RTBE_First.SelectionColor = Color.DarkSalmon
        End If
        If MainWindow.RTBE_First.Text.Contains("</ol>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</ol>")
            MainWindow.RTBE_First.SelectionColor = Color.DarkSalmon
        End If
        If MainWindow.RTBE_First.Text.Contains("<ul>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<ul>")
            MainWindow.RTBE_First.SelectionColor = Color.DarkTurquoise
        End If
        If MainWindow.RTBE_First.Text.Contains("</ul>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</ul>")
            MainWindow.RTBE_First.SelectionColor = Color.DarkTurquoise
        End If
        If MainWindow.RTBE_First.Text.Contains("<cite>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<cite>")
            MainWindow.RTBE_First.SelectionColor = Color.IndianRed
        End If
        If MainWindow.RTBE_First.Text.Contains("</cite>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</cite>")
            MainWindow.RTBE_First.SelectionColor = Color.IndianRed
        End If
        If MainWindow.RTBE_First.Text.Contains("<code>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<code>")
            MainWindow.RTBE_First.SelectionColor = Color.LawnGreen
        End If
        If MainWindow.RTBE_First.Text.Contains("</code>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</code>")
            MainWindow.RTBE_First.SelectionColor = Color.LawnGreen
        End If
        If MainWindow.RTBE_First.Text.Contains("<caption>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<caption>")
            MainWindow.RTBE_First.SelectionColor = Color.LawnGreen
        End If
        If MainWindow.RTBE_First.Text.Contains("</caption>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</caption>")
            MainWindow.RTBE_First.SelectionColor = Color.LawnGreen
        End If
        If MainWindow.RTBE_First.Text.Contains("<div>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<div>")
            MainWindow.RTBE_First.SelectionColor = Color.LawnGreen
        End If
        If MainWindow.RTBE_First.Text.Contains("</div>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</div>")
            MainWindow.RTBE_First.SelectionColor = Color.LawnGreen
        End If
        If MainWindow.RTBE_First.Text.Contains("<br>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<br>")
            MainWindow.RTBE_First.SelectionColor = Color.LawnGreen
        End If
        If MainWindow.RTBE_First.Text.Contains("<strong>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<strong>")
            MainWindow.RTBE_First.SelectionColor = Color.MediumAquamarine
        End If
        If MainWindow.RTBE_First.Text.Contains("</strong>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</strong>")
            MainWindow.RTBE_First.SelectionColor = Color.MediumAquamarine
        End If
        If MainWindow.RTBE_First.Text.Contains("<button>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<button>")
            MainWindow.RTBE_First.SelectionColor = Color.MediumTurquoise
        End If
        If MainWindow.RTBE_First.Text.Contains("</button>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</button>")
            MainWindow.RTBE_First.SelectionColor = Color.MediumTurquoise
        End If
        If MainWindow.RTBE_First.Text.Contains("<span>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<span>")
            MainWindow.RTBE_First.SelectionColor = Color.MediumTurquoise
        End If
        If MainWindow.RTBE_First.Text.Contains("</span>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</span>")
            MainWindow.RTBE_First.SelectionColor = Color.MediumTurquoise
        End If
        If MainWindow.RTBE_First.Text.Contains("type=") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("type=")
            MainWindow.RTBE_First.SelectionColor = Color.MediumTurquoise
        End If
        If MainWindow.RTBE_First.Text.Contains("value=") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("value=")
            MainWindow.RTBE_First.SelectionColor = Color.MediumTurquoise
        End If
        If MainWindow.RTBE_First.Text.Contains("<dd>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<dd>")
            MainWindow.RTBE_First.SelectionColor = Color.MediumTurquoise
        End If
        If MainWindow.RTBE_First.Text.Contains("<dt>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("<dt>")
            MainWindow.RTBE_First.SelectionColor = Color.MediumTurquoise
        End If
        If MainWindow.RTBE_First.Text.Contains("</dd>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</dd>")
            MainWindow.RTBE_First.SelectionColor = Color.MediumTurquoise
        End If
        If MainWindow.RTBE_First.Text.Contains("</dt>") Then
            MainWindow.RTBE_First.SelectionStart = MainWindow.RTBE_First.Find("</dt>")
            MainWindow.RTBE_First.SelectionColor = Color.MediumTurquoise
        End If

    End Sub

    '---------------------
    'End Features
    '---------------------


End Module
