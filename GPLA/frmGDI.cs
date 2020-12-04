using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPLA
{
    //fromGDI extending form class
    public partial class frmGDI : Form
    {
        //variable declaration for shapes
        Circle circle; 
        Polygon polygon;
        Rectangle rectangle; 
        //end of variable declaration
        Boolean drawCircle, drawRect, drawPolgon, drawLine; //boolean value for checking shapes
        String program; //string to hold textarea info
        String[] words; //words of the individual program 
        int moveX, moveY; //cursor moving direction points
        int thickness; //thickness of pen

       
        Color c;
        Point point; //Point on the drawing panel
        string actionCmd;
        string console_text;

        Shape shape1, shape2; //shapefactory declaration
        //Individual object List for shapes
        List<Circle> circleObjects;
        List<Rectangle> rectangleObjects;
        List<Polygon> polygonObjects;
        List<MoveDirection> moveObjects;

        public frmGDI()
        {
            InitializeComponent();
            //Shape creation and initialization
            AbstractFactory shapeFactory = FactoryProducer.getFactory("Shape");
            shape1 = shapeFactory.getShape("Circle");
            shape2 = shapeFactory.getShape("Rectangle");
        }
        private void FrmGPLA_Load(object sender, EventArgs e)
        {
            circle = new Circle(); //instantiang circle
            rectangle = new Rectangle(); //instantiang rectangle
            circleObjects = new List<Circle>(); //Array declaration of circle objects
            rectangleObjects = new List<Rectangle>(); //Array declaration of rectangle objects
            moveObjects = new List<MoveDirection>(); //Array declaration for moving objects
            polygonObjects = new List<Polygon>(); //Array declaration of circle objects

            c = Color.DarkGreen;

        }
        private void txt_ActionCmd_TextChanged(object sender, EventArgs e)
        {
             actionCmd = txt_ExecutionCmd.Text.ToLower();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, txt_SyntaxArea.Text);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //opens diaglog box when button click to load the code.
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_SyntaxArea.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For Your Help:\n" +
                "draw circle 100\n" +
                "draw rectangle 100 50\n" +
                "draw polygon\n" +
                "move 100 100\n" +
                "color red 23\n");
        }

        private void Btn_run_Click(object sender, EventArgs e)
        {
            switch (actionCmd)
            {
                case "run":
                    try
                    {                        
                        program = txt_SyntaxArea.Text.ToLower();                                                
                        char[] delimiters = new char[] { '\r', '\n' };
                        string[] parts = program.Split(delimiters, StringSplitOptions.RemoveEmptyEntries); //holds invididuals code line on the basis of delimiters
                        console_text = "Program code: \n";
                        foreach (string part in parts)
                        {
                            console_text += part + "\n";
                        }
                        console_text += "\n\n";


                        //loop through the whole program code line
                        for (int i = 0; i < parts.Length; i++)
                        {
                            //single code line
                            String code_line = parts[i];

                            char[] code_delimiters = new char[] { ' ' };
                            words = code_line.Split(code_delimiters, StringSplitOptions.RemoveEmptyEntries); //holds invididuals code line

                            //condition to check if "draw" then
                            if (words[0].Equals("draw"))
                            {
                                if (words[1] == "circle") // condition to check if "circle" then
                                {
                                    if (!(words.Length == 3)) //checks if written code is correct or not
                                    {
                                        MessageBox.Show("Enter correct command and parameter");
                                        console_text += "View the correct Command: \n e.g. draw circle 100 or draw circle r \n\n";
                                    }
                                    else
                                    {
                                        if (circleObjects.Exists(x => x.getX() == moveX && x.getY() == moveY
                                        && x.getRadius() == Convert.ToInt32(words[2])) == true)                                        
                                        //check for the x,y,radius exists or not
                                        {
                                            console_text += "!!circle already exists with the given value!!\n\n";

                                        }
                                        else
                                        {//Create a new circle
                                            Circle circle = new Circle();
                                            circle.setX(moveX);
                                            circle.setY(moveY);
                                            circle.setRadius(Convert.ToInt32(words[2]));
                                            circleObjects.Add(circle);
                                            drawCircle = true;
                                            console_text += "Adding new circle\n\n";
                                        }
                                    }
                                }
                                if (words[1].Equals("rectangle")) // 
                                {
                                    //MessageBox.Show(moveX.ToString());
                                    if (!(words.Length == 4)) //extending parameter values
                                    {
                                        MessageBox.Show("Enter correct command");
                                        console_text += "View the correct Command:: \n e.g. draw rectangle 100 100 or draw circle h w \n\n";
                                    }
                                    else
                                    {
                                        if (rectangleObjects.Exists(x => x.getX() == moveX && x.getY() == moveY
                                        && x.getHeight() == Convert.ToInt32(words[2]) && x.getWidth() ==
                                        Convert.ToInt32(words[3])) == true)//check for the x,y,radius exists or not
                                        {
                                            console_text += "!!rectangle object exists with given parameters!!\n\n";
                                        }
                                        else
                                        {//create a new rectangle
                                            Rectangle rect = new Rectangle();
                                            rect.setX(moveX);
                                            rect.setY(moveY);
                                            rect.setHeight(Convert.ToInt32(words[2]));
                                            rect.setWidth(Convert.ToInt32(words[3]));
                                            rectangleObjects.Add(rect);
                                            drawRect = true;
                                            console_text += "Adding new rectangle\n\n";
                                        }
                                    }
                                }

                                if (words[1].Equals("polygon"))
                                {
                                    drawPolgon = true;
                                }
                            }
                            if (words[0] == "move") // condition to check if "move" then
                            {
                                if (Convert.ToInt32(words[1]) == shapeMovement.Location.X &&
                                    Convert.ToInt32(words[2]) == shapeMovement.Location.Y)//checks cursor position
                                {
                                    //MessageBox.Show("don't move");
                                    console_text += "Its in requested position\n\n";
                                }
                                else
                                {
                                    moveX = Convert.ToInt32(words[1]);
                                    moveY = Convert.ToInt32(words[2]);
                                    console_text += "X=" + moveX + "\n" + "Y=" + moveY + "\n\n";
                                }
                            }
                            if (words[0] == "color")
                            {
                                thickness = Convert.ToInt32(words[2]);

                                if (words[1] == "red")
                                {
                                    c = Color.Red;
                                    console_text += "Pen is of red color\n\n";
                                }
                                else if (words[1] == "blue")
                                {
                                    c = Color.Blue;
                                    console_text += "Pen is of blue color\n\n";
                                }
                                else if (words[1] == "yellow")
                                {
                                    c = Color.Yellow;
                                    console_text += "Pen is of yellow color\n\n";
                                }
                                else
                                {
                                    c = Color.Green;
                                    console_text += "Pen is of green color\n\n";
                                }
                            }
                        }
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        console_text += "Error: " + ex.Message + "\n\n";
                    }
                    catch (FormatException ex)
                    {
                        console_text += "!!Please input correct parameter!!\n\n";
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        console_text += "!!Please input correct parameter!!\n\n";
                    }
                    pnl_DisplayOutput.Refresh(); //refresh with every drawing equals to true
                    break;
                case "clear":
                    circleObjects.Clear();
                    rectangleObjects.Clear();
                    moveObjects.Clear();
                    polygonObjects.Clear();
                    this.drawPolgon = false;
                    this.drawCircle = false;
                    this.drawRect = false;
                    this.txt_SyntaxArea.Clear();
                    pnl_DisplayOutput.Refresh();
                    break;
                default:
                    MessageBox.Show("The action command is empty\n" +
                        "Or\n" +
                        "Must be: 'Run' for Execuit the program\n" +
                        "Must be: 'Clear' for Fresh Start");
                    break;
            }
        }

        private void Panel_output_Paint(object sender, PaintEventArgs e)
        {
            //Graphics to draw in panel
            Graphics g = e.Graphics;
            if (drawCircle == true)//draw circle condition
            {
                foreach (Circle circleObject in circleObjects)
                {
                    console_text += "Drawing Circle\n\n";
                    circleObject.draw(g, c, thickness); //draw circle with given graphics
                }
            }

            if (drawRect == true) //draw rectangle condition
            {
                foreach (Rectangle rectangleObject in rectangleObjects)
                {
                    console_text += "Drawing Rectangle\n\n";
                    rectangleObject.draw(g, c, thickness); //draw circle with given graphics
                }
            }

            if (drawPolgon == true)
            {
                Pen blackPen = new Pen(c, thickness);
                PointF point1 = new PointF(50.0F, 50.0F);
                PointF point2 = new PointF(50.0F, 25.0F);
                PointF point3 = new PointF(100.0F, 5.0F);
                PointF point4 = new PointF(150.0F, 20.0F);
                PointF point5 = new PointF(200.0F, 50.0F);
                PointF point6 = new PointF(250.0F, 100.0F);
                PointF point7 = new PointF(250.0F, 150.0F);
                string[] str = new string[5];
                PointF[] curvePoints =
                 {
                     point1,
                     point2,
                     point3,
                     point4,
                     point5,
                     point6,
                     point7
                 };
                e.Graphics.DrawPolygon(blackPen, curvePoints);
            }
        }
    }
}
