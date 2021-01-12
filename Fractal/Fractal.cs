using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal
{
    public partial class Fractal : Form
    {
        private const int MAX = 256;      // max iterations

        private int x1, y1, xs, ys, xe, ye;
        private double xstart, ystart, xende, yende, xzoom, yzoom;

        private int minHeight = 400; // minimun height and width of the picture box while resizing
        private int minWidth = 455;

        private int maxHeight = 600; // maximum height and width of the picture box while resizing
        private int maxWidth = 800;

        private bool action, rectangle, finished;
        private float xy;
        private bool isMouseDown = false; // used for indicating if the mouse is pressed

        private bool isFirstTime = true; // indicates if the application is run for the first time

        private Bitmap picture;
        private Graphics g1;
        private Cursor waitCur, crossHairCur, defaultCur;

        private FractalSet fractalSet;

        private string currentSet = "Mandelbrot";

        public Fractal()
        {
            InitializeComponent();

            addListeners(); // adding listeners

            loadFractalSet();

            finished = false;

            initCursors(); // initiating cursors

            configComplexPlane(640, 480); // configuring complex plane

            this.MinimumSize = new Size(minWidth + 16, minHeight + this.menuBar.Height + this.statusLabel.Height + 60); // sets maximum and minimum size of the form
            this.MaximumSize = new Size(maxWidth + 16, maxHeight + this.menuBar.Height + this.statusLabel.Height + 60);

            finished = true;

            start();
        }

        public void loadFractalSet() // loads fractals according according the fractal set by user
        {
            switch (currentSet)
            {
                case "Mandelbrot":
                    {
                        this.fractalSet = new MandelbrotSet();
                    }
                    break;

                case "Julia":
                    {
                        this.fractalSet = new JuliaSet();
                    }

                    break;

                default: break;
            }
        }

        public void initCursors() // initiating the cursors
        {
            waitCur = Cursors.WaitCursor;
            crossHairCur = Cursors.Cross;
            defaultCur = Cursors.Default;
        }

        public void configComplexPlane(int width, int height) // configure the complex plane where fractal is drawn
        {
            this.pictureBox.Size = new System.Drawing.Size(width, height); // setting width and height of the picture box

            x1 = width; // width for the complex plane
            y1 = height; // height for the complex plane

            xy = (float)x1 / (float)y1; // ratio required for zooming

            this.statusLabel.Location = new Point(this.statusLabel.Location.X, height + this.menuBar.Height + 12); // change status position relative to picture box

            this.sizeLabel.Location = new Point(width - 90, height + this.menuBar.Height + 12);

            this.sizeLabel.Text = "Size: " + width + " X " + height;

            picture = new Bitmap(x1, y1);
            g1 = Graphics.FromImage(picture);
        }

        public void start()
        {
            action = false;
            rectangle = false;

            initValues(); // initialize values
            refreshZoomingValues(); // refresh the zooming values according to the area selected

            drawFractalSet(); // draw mandelbrot set
        }

        private void refreshZoomingValues()
        {
            xzoom = (xende - xstart) / (double)x1;
            yzoom = (yende - ystart) / (double)y1;
        }

        private void Fractal_Resize(object sender, EventArgs e)
        {
            configComplexPlane(this.Width - 16, this.Height - this.menuBar.Height - this.statusLabel.Height - 60); // resize the complex plane according to the resized form

            refreshZoomingValues();

            drawFractalSet();
        }

        private void initValues()
        {
            xstart = fractalSet.SX;
            ystart = fractalSet.SY;
            xende = fractalSet.EX;
            yende = fractalSet.EY;

            if ((float)((xende - xstart) / (yende - ystart)) != xy)
                xstart = xende - (yende - ystart) * (double)xy;
        }

        private void setCursor(Cursor c) // sets cursor type
        {
            this.Cursor = c;
        }

        private void setStatus(String status) // sets the status of app
        {
            if (!isFirstTime)
            {
                statusLabel.Text = status;
            }
        }

        private void setPicture(Bitmap pic) // sets picture in the picture box
        {
            pictureBox.Image = pic;
        }

        private void drawFractalSet() // drawing the mandelbrot set
        {
            action = false;

            setCursor(waitCur); // setting wait cursor while drawing

            setStatus(currentSet + "-Set will be produced - please wait...");

            if (finished) // finished initializing
            {
                fractalSet.draw(g1, x1, y1, xstart, ystart, xzoom, yzoom, MAX); // drawing mandelbrot set
            }

            setStatus(currentSet + "-Set ready - please select zoom area with pressed mouse.");

            setCursor(crossHairCur); // setting cross hair cursor after drawing

            action = true;

            setPicture(picture); // drawing the picture in the picture box

            if (isFirstTime)
            {
                isFirstTime = false;
            }
        }

        public void update() // update on mouse events
        {
            Bitmap fractalWithSelection = (Bitmap)picture.Clone(); // for keeping the originally drawn fractal picture safe, cloning is done

            Graphics g = Graphics.FromImage(fractalWithSelection);

            if (rectangle) // if selection is done
            {
                Pen pen = new Pen(Color.White);

                Rectangle rect;

                if (xs < xe) // if horizontal selection is done from left to right
                {
                    if (ys < ye) // if vertical selection is done from top to bottom
                    {
                        rect = new Rectangle(xs, ys, (xe - xs), (ye - ys));
                    }
                    else // else vertical selection is done from bottom to top
                    {
                        rect = new Rectangle(xs, ye, (xe - xs), (ys - ye));
                    }
                }
                else // else horizontal selection is done from right to left
                {
                    if (ys < ye) // if vertical selection is done from top to bottom
                    {
                        rect = new Rectangle(xe, ys, (xs - xe), (ye - ys));
                    }
                    else // else vertical selection is done from bottom to top
                    {
                        rect = new Rectangle(xe, ye, (xs - xe), (ys - ye));
                    }
                }

                // show selection area by drawing white outlined rectangle

                g.DrawRectangle(pen, rect);

                setPicture(fractalWithSelection);

                g.Dispose();
            }
        }

        public void applyCustomConstants(double cRe, double cIm) // appying custom constant for the fractal
        {
            this.fractalSet.consR = cRe;

            this.fractalSet.consI = cIm;

            drawFractalSet();
        }

        public void applyCustomSize(int w, int h) // applying custom size of the picture box, sets the size of the form according to the size of the picture box
        {
            this.Width = w + 16;

            this.Height = h + this.menuBar.Height + this.statusLabel.Height + 60;
        }

        private void addListeners() // adds listeners
        {
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);

            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);

            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
        }

        private void removeListeners() // removes listeners
        {
            this.pictureBox.Paint -= this.pictureBox_Paint;

            this.pictureBox.MouseDown -= this.pictureBox_MouseDown;
            this.pictureBox.MouseMove -= this.pictureBox_MouseMove;
            this.pictureBox.MouseUp -= this.pictureBox_MouseUp;
            this.pictureBox.MouseEnter -= this.pictureBox_MouseEnter;
        }

        private void Fractal_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (finished) // if finished initializing form
            {
                removeListeners();

                picture = null;
                g1 = null;
                waitCur = null;
                crossHairCur = null;

                System.GC.Collect(); // garbage collection
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            update();
        }

        private void printPicture_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox.Image, 0, 0);
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            int z, w;
            
            if (action)
            {
                xe = e.X;
                ye = e.Y;
                if (xs > xe)
                {
                    z = xs;
                    xs = xe;
                    xe = z;
                }
                if (ys > ye)
                {
                    z = ys;
                    ys = ye;
                    ye = z;
                }
                w = (xe - xs);
                z = (ye - ys);

                if ((w < 2) && (z < 2)) initValues();
                else
                {
                    if (((float)w > (float)z * xy)) ye = (int)((float)ys + (float)w / xy);
                    else xe = (int)((float)xs + (float)z * xy);
                    xende = xstart + xzoom * (double)xe;
                    yende = ystart + yzoom * (double)ye;
                    xstart += xzoom * (double)xs;
                    ystart += yzoom * (double)ys;
                }

                xzoom = (xende - xstart) / (double)x1;
                yzoom = (yende - ystart) / (double)y1;

                drawFractalSet();

                rectangle = false;

                pictureBox.Refresh();
                isMouseDown = false;
            }
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (action)
            {
                isMouseDown = true;

                xs = e.X;
                ys = e.Y;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (action && isMouseDown) // checking if mouse pressed
            {
                xe = e.X;
                ye = e.Y;

                rectangle = true;
                pictureBox.Refresh();
            }
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (action)
            {
                setCursor(crossHairCur);
            }
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (action)
            {
                setCursor(defaultCur);
            }
        }

        private void menuBar_MouseEnter(object sender, EventArgs e)
        {
            setCursor(defaultCur);
        }

        private void saveStateMenu_Click(object sender, EventArgs e) // saves state (app data) to a file
        {
            if (action) // if fractal drawn
            {
                SaveFileDialog dialog = new SaveFileDialog();

                dialog.Filter = "State|*.st";
                dialog.Title = "Save State";
                dialog.ShowDialog();

                if (dialog.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)dialog.OpenFile();

                    String txt = xstart + "," + xende + "," + ystart + "," + yende + "," + currentSet + "," + pictureBox.Width + "," + pictureBox.Height + "," + this.Width + "," + this.Height;

                    String filePath = dialog.FileName;

                    fs.Close();

                    System.IO.File.WriteAllText(@filePath, txt);

                    MessageBox.Show("State Successfully Saved to " + dialog.FileName, "Save State", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nothing is drawn!!", "Save State", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void loadStateMenu_Click(object sender, EventArgs e) // loading the state from a file
        {
                OpenFileDialog dialog = new OpenFileDialog();

                dialog.Filter = "State|*.st";
                dialog.Title = "Load State";

                dialog.ShowDialog();

            if (dialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)dialog.OpenFile();

                switch (dialog.FilterIndex)
                {
                    case 1:
                        {   
                            string line;
                            String [] data;
                            
                            System.IO.StreamReader file = new System.IO.StreamReader(dialog.FileName);

                            if ((line = file.ReadLine()) != null) // setting the app data which are fetched from the file
                            {
                                data = line.Split(',');

                                this.xstart = double.Parse(data[0]);
                                this.xende = double.Parse(data[1]);

                                this.ystart = double.Parse(data[2]);
                                this.yende = double.Parse(data[3]);

                                this.currentSet = data[4];

                                this.loadFractalSet();

                                this.configComplexPlane(int.Parse(data[5]), int.Parse(data[6]));

                                this.Width = int.Parse(data[7]);
                                this.Height = int.Parse(data[8]);

                                this.refreshZoomingValues();

                                this.drawFractalSet();

                                MessageBox.Show("State Successfully Loaded!!", "Load State", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            file.Close();
                        }

                        break;

                    default:
                        {
                            MessageBox.Show("Invalid File", "Load State", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        break;
                }
            }
        }

        private void customSize_Click(object sender, EventArgs e) // show the resize dialog by passing the data of the app
        {
            Console.WriteLine(this.pictureBox.Height);
            Resize rDialog = new Resize(this, this.pictureBox.Width, this.pictureBox.Height, this.minHeight, this.minWidth, this.maxHeight, this.maxWidth);

            rDialog.Show();
        }

        private void setConstantsMenu_Click(object sender, EventArgs e) // sets the constant for the iterated function used in the fractal
        {
            if (this.currentSet == "Mandelbrot") // if fractal is mandelbrot
            {
                MessageBox.Show("The constants of Mandelbrot set can't be changed!! Each pixel of the Mandelbrot have different constants which are dynamically set.", "Set Constants", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                SetConstantsForm consForm = new SetConstantsForm(this, this.fractalSet.consR, this.fractalSet.consI);

                consForm.Show();
            }
        }

        private void infoMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Fractal v1.0 by Rupesh Babu Shrestha", "App Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void reloadMenu_Click(object sender, EventArgs e)
        {
            start();
        }

        private void restartMenu_Click(object sender, EventArgs e)
        {
            stopMenu_Click(sender, e);
            startMenu_Click(sender, e);
        }

        private void startMenu_Click(object sender, EventArgs e)
        {
            drawFractalSet();
        }

        private void stopMenu_Click(object sender, EventArgs e)
        {
            this.pictureBox.Image = null;
            action = false;
        }

        private void cloneMenu_Click(object sender, EventArgs e) // clones the current form with its properties
        {
            Fractal frac = new Fractal();

            frac.xstart = this.xstart;
            frac.xende = this.xende;

            frac.ystart = this.ystart;
            frac.yende = this.yende;

            frac.currentSet = this.currentSet;

            frac.loadFractalSet();

            frac.configComplexPlane(pictureBox.Width, pictureBox.Height);

            frac.Size = this.Size;

            frac.refreshZoomingValues();

            frac.drawFractalSet();

            frac.pictureBox.Image = this.pictureBox.Image;

            frac.Show();
        }

        private void printMenu_Click(object sender, EventArgs e) // for printing the drawn fractal
        {
            if (action)
            {
                PrintDocument doc = new PrintDocument();
                PrintDialog printDialog = new PrintDialog();

                doc.PrintPage += new PrintPageEventHandler(printPicture_PrintPage);

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    doc.PrinterSettings = printDialog.PrinterSettings;
                    doc.Print();

                    MessageBox.Show("Image Successfully Printed!!", "Print", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Printing Cancelled!!", "Print", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Nothing is drawn!!", "Print", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void quitMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveMenu_Click(object sender, EventArgs e) // saving image to a file
        {
            if (action)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png";
                dialog.Title = "Save an Image:";
                dialog.ShowDialog();

                if (dialog.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)dialog.OpenFile();

                    switch (dialog.FilterIndex)
                    {
                        case 1:
                            this.pictureBox.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                        case 2:
                            this.pictureBox.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Bmp);
                            break;

                        case 3:
                            this.pictureBox.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Png);
                            break;
                    }

                    MessageBox.Show("Image Successfully Saved to " + dialog.FileName, "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    fs.Close();
                }
            }
            else
            {
                MessageBox.Show("Nothing is drawn!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void mandelbrotMenu_Click(object sender, EventArgs e) // if mandelbrot set is selected
        {
            this.currentSet = "Mandelbrot";

            this.loadFractalSet();

            start();
        }

        private void juliaMenu_Click(object sender, EventArgs e) // if julia set is selected
        {
            this.currentSet = "Julia";

            this.loadFractalSet();

            start();
        }
    }
}