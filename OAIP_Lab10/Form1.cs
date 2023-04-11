namespace OAIP_Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (Context.array != null)
            {

                if (radioButton1.Checked == true)
            {
                /*this.context = new Context(new BubbleSort());
                context.ExecuteAlgorithm();
                this.AddItemsListBox();
                IOFile.SaveData();
                buttonSort.Enabled = false;*/

                
            }   
            if (radioButton2.Checked == true)
            {
                void QuickSort(int[] array, int a, int b)
                {
                    int i = a;
                    int j = b;
                    int middle = array[(a + b) / 2];
                    while (i <= j)
                    {
                        while (array[i] < middle)
                        {
                            i++;
                        }
                        while (array[j] > middle)
                        {
                            j--;
                        }
                        if (i <= j)
                        {
                            int temporaryVariable = array[i];
                            array[i] = array[j];
                            array[j] = temporaryVariable;
                            i++;
                            j--;
                        }
                    }
                    if (a < j)
                    {
                        QuickSort(array, a, j);
                    }
                    if (i < b)
                    {
                        QuickSort(array, i, b);
                    }
                }

            }
                /*IOFile.content = "";*/
            }
            else
            {
                MessageBox.Show("Массив пуст, сортировка невозможна");
            }

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}