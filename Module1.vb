Imports IronPdf

Module Module1

    Sub Main()
        Dim renderer = New HtmlToPdf()
        renderer.PrintOptions.CssMediaType = PdfPrintOptions.PdfCssMediaType.Print
        renderer.PrintOptions.PrintHtmlBackgrounds = False
        renderer.PrintOptions.PaperOrientation = PdfPrintOptions.PdfPaperOrientation.Landscape
        renderer.PrintOptions.RenderDelay = 150


        renderer.PrintOptions.Header.CenterText = "VB.Net PDF Slideshow"
        renderer.PrintOptions.Header.DrawDividerLine = True
        renderer.PrintOptions.Header.FontSize = "13"

        renderer.PrintOptions.Footer.RightText = "page {page} of {total-pages}"
        renderer.PrintOptions.Footer.FontFamily = "Arial"
        renderer.PrintOptions.Footer.FontSize = "9"


        Dim document = renderer.RenderHTMLFileAsPdf("..\..\slideshow\index.html")
        document.SaveAs("Html5WithHeader.pdf")
        System.Diagnostics.Process.Start("Html5WithHeader.pdf")
    End Sub

End Module