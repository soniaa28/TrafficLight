namespace WinFormsApp1
{
    public partial class Standart : Form
    {
        int light = 0;
        public Standart()
        {
            InitializeComponent();

            redLight.Visible = false;
            yellowLight.Visible = true;
            greenLight.Visible = false;

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if(light==0)
            {
                redLight.Visible = true;
                yellowLight.Visible = false;
                greenLight.Visible = false;
                light = 1;

            }
            else if (light==1)
            {
                 redLight.Visible = false;
                 yellowLight.Visible = true;
                 greenLight.Visible = false;
                light = 2;
            }
            else if (light==2 )
            {
                redLight.Visible = false;
                yellowLight.Visible = false;
                greenLight.Visible = true;
                light = 3;
            }
            else if(light==3)
            {
                redLight.Visible = false;
                yellowLight.Visible = true;
                greenLight.Visible = false;
                light = 0;
            }

        }
     
        private void stopBtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            yellowTimer.Enabled = false;
            redLight.Visible = false;
            yellowLight.Visible = true;
            greenLight.Visible = false;

        }

        private void timerChange_Click(object sender, EventArgs e)
        {
           
            try
            {
                timer1.Interval = int.Parse(timerInterval.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Потрібно ввести натуральне число\n" + ex.Message,
                    "Помилка введення", MessageBoxButtons.OK, MessageBoxIcon.Error);
                timerInterval.Focus();
                timerInterval.SelectAll();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yellowTimer.Enabled = true;
            redLight.Visible = false;
            greenLight.Visible=false;
            yellowLight.Visible = true;

        }

        private void yellowTimer_Tick(object sender, EventArgs e)
        {
           if(emptyLight.Visible == true)
            {
                yellowLight.Visible = true;
                emptyLight.Visible = false; 
            }
            else if (yellowLight.Visible == true)
            {
                yellowLight.Visible = false;
                emptyLight.Visible = true;
            }
        }

        private void redBtn_Click(object sender, EventArgs e)
        {
            redLight.Visible = true;
            yellowLight.Visible = false;
            greenLight.Visible = false;
        }

        private void yellowBtn_Click(object sender, EventArgs e)
        {
            redLight.Visible = false;
            yellowLight.Visible = true;
            greenLight.Visible = false;
        }

        private void greenBtn_Click(object sender, EventArgs e)
        {
            redLight.Visible = false;
            yellowLight.Visible = false;
            greenLight.Visible = true;
        }

        private void rightLight_CheckStateChanged(object sender, EventArgs e)
        {
           if( right.Visible == true)
            {
                right.Visible = false;
            }
           else
            {
                right.Visible = true;
            }
        }

        private void leftLight_CheckedChanged(object sender, EventArgs e)
        {
            if (left.Visible == true)
            {
                left.Visible = false;
            }
            else
            {
                left.Visible = true;
            }
        }

        private void bottomLight_CheckedChanged(object sender, EventArgs e)
        {
            if (bottom.Visible == true)
            {
                bottom.Visible = false;
            }
            else
            {
                bottom.Visible = true;
            }
        }
    }
}