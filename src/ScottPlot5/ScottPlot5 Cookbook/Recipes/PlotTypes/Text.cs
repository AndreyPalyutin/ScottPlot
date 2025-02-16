﻿namespace ScottPlotCookbook.Recipes.PlotTypes;

public class Text : ICategory
{
    public string Chapter => "Plot Types";
    public string CategoryName => "Text";
    public string CategoryDescription => "Text lables placed on the plot in coordinate space";

    public class TextQuickstart : RecipeBase
    {
        public override string Name => "Text Quickstart";
        public override string Description => "Text can be placed anywhere in coordinate space.";

        [Test]
        public override void Execute()
        {
            myPlot.Add.Signal(ScottPlot.Generate.Sin());
            myPlot.Add.Signal(ScottPlot.Generate.Cos());
            myPlot.Add.Text("Hello, World", 25, 0.5);
        }
    }

    public class Formatting : RecipeBase
    {
        public override string Name => "Text Formatting";
        public override string Description => "Text formatting can be extensively customized.";

        [Test]
        public override void Execute()
        {
            var text = myPlot.Add.Text("Hello, World", 42, 69);
            text.Label.FontSize = 26;
            text.Label.Bold = true;
            text.Label.Rotation = -45;
            text.Label.ForeColor = Colors.Yellow;
            text.Label.BackColor = Colors.Navy.WithAlpha(.5);
            text.Label.BorderColor = Colors.Magenta;
            text.Label.BorderWidth = 3;
            text.Label.Padding = 10;
            text.Label.Alignment = Alignment.MiddleCenter;
        }
    }
}
