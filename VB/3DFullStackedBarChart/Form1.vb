Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace _DFullStackedBarChart
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create an empty chart.
            Dim fullStackedBar3DChart As New ChartControl()

            ' Create two series of the FullStackedBar3D view type.
            Dim series1 As New Series("Series 1", ViewType.FullStackedBar3D)
            Dim series2 As New Series("Series 2", ViewType.FullStackedBar3D)

            ' Populate both series with points.
            series1.Points.Add(New SeriesPoint("A", 80))
            series1.Points.Add(New SeriesPoint("B", 20))
            series1.Points.Add(New SeriesPoint("C", 50))
            series1.Points.Add(New SeriesPoint("D", 30))
            series2.Points.Add(New SeriesPoint("A", 40))
            series2.Points.Add(New SeriesPoint("B", 60))
            series2.Points.Add(New SeriesPoint("C", 20))
            series2.Points.Add(New SeriesPoint("D", 80))

            ' Add the series to the chart.
            fullStackedBar3DChart.Series.AddRange(New Series() {series1, series2})

            ' Adjust the view-type-specific options of the second series.
            Dim myView As FullStackedBar3DSeriesView = CType(series2.View, FullStackedBar3DSeriesView)
            myView.Transparency = 20
            myView.Model = Bar3DModel.Cylinder
            myView.ShowFacet = False

            ' Access the diagram's options.
            CType(fullStackedBar3DChart.Diagram, XYDiagram3D).ZoomPercent = 110

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "3D Full Stacked Bar Chart"
            fullStackedBar3DChart.Titles.Add(chartTitle1)
            fullStackedBar3DChart.Legend.Visible = False

            ' Add the chart to the form.
            fullStackedBar3DChart.Dock = DockStyle.Fill
            Me.Controls.Add(fullStackedBar3DChart)
        End Sub

    End Class
End Namespace