using System;
using System.Collections.Generic;

using Xamarin.Forms;

using TouchTracking;
using TouchTracking.Forms;
using SkiaSharp;
using SkiaSharp.Views.Forms;

namespace DrawNew
{
    public partial class MainPage : ContentPage
    {
        /*Dictionary<long, SKPath> inProgressPaths = new Dictionary<long, SKPath>();
        List<SKPath> completedPaths = new List<SKPath>();

        

        SKPaint paint = new SKPaint
        {
            Style = SKPaintStyle.Stroke,
            StrokeWidth = 10,
            StrokeCap = SKStrokeCap.Round,
            StrokeJoin = SKStrokeJoin.Round
        };

        public SKBitmap saveBitmap;*/

        public MainPage()
        {
            InitializeComponent();
        }


        /*void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs args)
        {
            SKImageInfo info = args.Info;
            SKSurface surface = args.Surface;
            SKCanvas canvas = surface.Canvas;


            if (saveBitmap == null)
            {
                saveBitmap = new SKBitmap(info.Width, info.Height);
            }

            else if (saveBitmap.Width < info.Width || saveBitmap.Height < info.Height)
            {
                SKBitmap newBitmap = new SKBitmap(Math.Max(saveBitmap.Width, info.Width),
                                                  Math.Max(saveBitmap.Height, info.Height));

                using (SKCanvas newCanvas = new SKCanvas(newBitmap))
                {
                    newCanvas.Clear();
                    newCanvas.DrawBitmap(saveBitmap, 0, 0);
                }

                saveBitmap = newBitmap;
            }

            // Render the bitmap
            canvas.Clear();
            canvas.DrawBitmap(saveBitmap, 0, 0);
        }

        void OnTouchEffectAction(object sender, TouchActionEventArgs args)
        {
            switch (args.Type)
            {
                case TouchActionType.Pressed:
                    if (!inProgressPaths.ContainsKey(args.Id))
                    {
                        SKPath path = new SKPath();
                        path.MoveTo(ConvertToPixelUsingPoint(new Point { X = args.Location.X, Y = args.Location.Y }));
                        inProgressPaths.Add(args.Id, path);
                        UpdateBitmap();
                    }
                    break;

                case TouchActionType.Moved:
                    if (inProgressPaths.ContainsKey(args.Id))
                    {
                        SKPath path = inProgressPaths[args.Id];
                        path.LineTo(ConvertToPixelUsingPoint(new Point { X = args.Location.X, Y = args.Location.Y }));
                        UpdateBitmap();
                    }
                    break;

                case TouchActionType.Released:
                    if (inProgressPaths.ContainsKey(args.Id))
                    {
                        completedPaths.Add(inProgressPaths[args.Id]);
                        inProgressPaths.Remove(args.Id);
                        UpdateBitmap();
                    }
                    break;

                case TouchActionType.Cancelled:
                    if (inProgressPaths.ContainsKey(args.Id))
                    {
                        inProgressPaths.Remove(args.Id);
                        UpdateBitmap();
                    }
                    break;
            }
        }


        float ConvertToPixel(float fl)
        {
            return (float)(canvasView.CanvasSize.Width * fl / canvasView.Width);
        }

        SKPoint ConvertToPixelUsingPoint(Point pt)
        {
            return new SKPoint((float)(canvasView.CanvasSize.Width * pt.X / (canvasView.Width)),
                           (float)(canvasView.CanvasSize.Height * pt.Y / (canvasView.Height)));
        }

        void UpdateBitmap()
        {
            using (SKCanvas saveBitmapCanvas = new SKCanvas(saveBitmap))
            {
                saveBitmapCanvas.Clear();

                

                foreach (SKPath path in inProgressPaths.Values)
                {
                    saveBitmapCanvas.DrawPath(path, paint);
                }

                foreach (SKPath path in completedPaths)
                {
                    saveBitmapCanvas.DrawPath(path, paint);
                }
            }

            canvasView.InvalidateSurface();
        }

        void OnClearButtonClicked(object sender, EventArgs args)
        {
            completedPaths.Clear();
            inProgressPaths.Clear();
            UpdateBitmap();
            canvasView.InvalidateSurface();
        }

        private void OnRedButtonClicked(object sender, EventArgs e)
        {
            
            paint.Color = SKColors.Red;
            UpdateBitmap();
        }
        private void OnBlueButtonClicked(object sender, EventArgs e)
        {
            
            paint.Color = SKColors.Blue;
            UpdateBitmap();
        }
        private void OnBiggerButtonClicked(object sender, EventArgs e)
        {
            inProgressPaths.Clear();
            paint.StrokeWidth = 30;
            UpdateBitmap();

        }

        async void OnSaveButtonClicked(object sender, EventArgs args)
        {
                using (SKImage image = SKImage.FromBitmap(saveBitmap))
                {
                    SKData data = image.Encode();
                    DateTime dt = DateTime.Now;
                    string filename = String.Format("FingerPaint-{0:D4}{1:D2}{2:D2}-{3:D2}{4:D2}{5:D2}{6:D3}.png",
                                                    dt.Year, dt.Month, dt.Day, dt.Hour, dt.Minute, dt.Second, dt.Millisecond);

                    IPhotoLibrary photoLibrary = DependencyService.Get<IPhotoLibrary>();
                    bool result = await photoLibrary.SavePhotoAsync(data.ToArray(), "FingerPaint", filename);

                    if (!result)
                    {
                        await DisplayAlert("FingerPaint", "Artwork could not be saved. Sorry!", "OK");
                    }
                }
        }*/


    }

    
}

