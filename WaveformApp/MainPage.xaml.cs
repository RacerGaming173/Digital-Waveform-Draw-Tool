namespace WaveformApp;

public class DrawGrid : IDrawable
{
	public void Draw(ICanvas canvas, RectF dirtyRect)
	{
		canvas.StrokeColor = Colors.White;
		canvas.StrokeSize = 1;

		canvas.DrawLine(0, dirtyRect.Height - 50, dirtyRect.Width, dirtyRect.Height - 50);

		canvas.FontColor = Colors.White;
		canvas.StrokeDashPattern = [20, 20];

		for (int i = 0; i <= dirtyRect.Width; i++)
		{
			canvas.DrawLine(100*i, 0, 100*i, dirtyRect.Height - 50);
			canvas.DrawString(Convert.ToString((float)i/10), 100*i + 5, dirtyRect.Height - 40, HorizontalAlignment.Center);
		}
	}      
}

public class Test : IDrawable
{
	public void Draw(ICanvas canvas, RectF dirtyRect)
	{
		canvas.StrokeColor = Colors.Red;
		canvas.StrokeSize = 1;

		canvas.DrawLine(0, 100, 0, 800);
	}      
}
public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	// double panX, panY;
	// public void onPanUpdated(object sender, PanUpdatedEventArgs e)
	// {

	// 	switch (e.StatusType)
    //     {
    //         case GestureStatus.Running:
    //             // Translate and pan.
    //             double boundsX = Content.Width;
    //             double boundsY = Content.Height;
    //             Content.TranslationX = Math.Clamp(panX + e.TotalX, -boundsX, boundsX);
    //             Content.TranslationY = Math.Clamp(panY + e.TotalY, -boundsY, boundsY);
    //             break;

    //         case GestureStatus.Completed:
    //             // Store the translation applied during the pan
    //             panX = Content.TranslationX;
    //             panY = Content.TranslationY;
    //             break;
    //     }
	// }
}
