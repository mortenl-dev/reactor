using Spectre.Console;
namespace Reactor {
    public class Map {
        public void PrintMap() {
            // Create a canvas
            var canvas = new Canvas(16, 16);

            // Draw some shapes
            for(var i = 0; i < canvas.Width; i++)
            {
                // Cross
                canvas.SetPixel(i, i, Color.White);
                canvas.SetPixel(canvas.Width - i - 1, i, Color.White);

                // Border
                canvas.SetPixel(i, 0, Color.Red);
                canvas.SetPixel(0, i, Color.Green);
                canvas.SetPixel(i, canvas.Height - 1, Color.Blue);
                canvas.SetPixel(canvas.Width - 1, i, Color.Yellow);
            }

            // Render the canvas
            AnsiConsole.Write(canvas);

        }
    }
}
