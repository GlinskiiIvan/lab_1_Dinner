using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.PropertyGridInternal;

namespace Dinner
{
    public partial class Form1 : Form
    {

        List<string> listIngredients;
        Dictionary<string, List<string>> dishList;
        Dictionary<string, string> description;
        Dictionary<string, Bitmap> images;
        public Form1()
        {
            InitializeComponent();

            listIngredients = new List<string>() 
            {
                "Картофель", "Мясо", "Яйца", "Лук", "Морковь", "Рис", "Соль", "Вода", "Чеснок", "Лапша", 
                "Томатная паста", "Перец", "Мука", "Свекла", "Капуста", "Болгарский перец",
            };

            dishList = new Dictionary<string, List<string>>()
            {
                {
                    "Борщ", new List<string>()
                        {
                            "Мясо", "Лук", "Картофель", "Морковь", "Свекла", "Капуста", "Чеснок", "Томатная паста",
                            "Уксус", "Соль", "Перец", "Вода"
                        }
                },
                {
                    "Плов", new List<string>()
                    {
                        "Мясо", "Лук", "Морковь", "Рис", "Масло подсолнечное", "Соль", "Вода"
                    }
                },
                {
                    "Лагман", new List<string>()
                    {
                        "Мясо", "Лук", "Морковь", "Болгарский перец", "Картофель", "Чеснок", "Вода", "Соль", "Лапша", "Томатная паста", "Перец"
                    }
                },
                {
                    "Драники", new List<string>()
                    {
                        "Лук", "Картофель", "Яйца", "Соль", "Мука", "Перец"
                    }
                }
            };

            description = new Dictionary<string, string>()
            {
                {"Борщ", "Это блюдо — изюминка украинской кухни, которую знают, наверное, во всем мире. Несмотря на убеждение о том, что у каждой хозяйки свой неповторимый борщ, я хочу поделиться с вами вариантом, который наверняка станет вашим любимым. Сам процесс нельзя назвать сложным, так что даже молодые и неопытные кулинары могут смело попробовать свои силы."},
                {"Плов", "Настоящий плов готовится из баранины и с добавлением множества ароматных специй. Но не все любят баранину, да и достать хорошее мясо не всегда удается. А плова хочется... Так давайте же приготовим плов из привычной нам свинины. И получится он у нас тоже вкусным, ароматным и рассыпчатым." },
                {"Лагман", "Суп можно готовить не только с бараниной, но и с говядиной. Рецепт традиционный, поэтому при желании, можно добавить в этом суп остроты в виде перца чили. И подать рекомендую с зеленью." },
                {"Драники", "Чтобы драники успели прожариться, приобрели хрустящую корочку и не подгорели, их нужно жарить на среднем огне. Такие картофельные блинчики идеально сочетаются с грибными соусами и с подливками из греческого йогурта и зелени." }
            };

            images = new Dictionary<string, Bitmap>()
            {
                {"Борщ", new Bitmap(Resources.borsh) },
                {"Плов", new Bitmap(Resources.plov)},
                {"Лагман", new Bitmap(Resources.lagman)},
                {"Драники", new Bitmap(Resources.draniki)}
            };

            listIngredients.Sort();

            foreach(var item in dishList)
            {
                item.Value.Sort();
            }

            for (int i = 0; i < listIngredients.Count; i++)
            {
                checkedListBox_ingredients.Items.Add(listIngredients[i]);
            }

            foreach(var item in dishList)
            {
                listBoxD_dish.Items.Add(item.Key);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_showDish_Click(object sender, EventArgs e)
        {
            listBox_dish.Items.Clear();
            
            List<string> tempDish = new List<string>();           

            foreach (var element in dishList)
            {
                bool flag = true;
                foreach(var item in checkedListBox_ingredients.CheckedItems)
                {
                    if (element.Value.IndexOf(item.ToString()) == -1)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    tempDish.Add(element.Key);
                }
                
            }

            tempDish.Sort();

            foreach (var item in tempDish)
            {
                listBox_dish.Items.Add(item);
            }

            if (listBox_dish.SelectedIndex == -1)
            {
                pictureBox_description.Image = null;
                textBox_description.Text = "";
            }
        }
        private void listBox_dish_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            foreach (var item in description)
            {
                if (listBox_dish.SelectedItem == item.Key)
                {
                    textBox_description.Text = item.Value;
                    pictureBox_description.Image = images[item.Key];
                }
            }
        }

        private void labelD_ingredients_Click(object sender, EventArgs e)
        {

        }

        private void listBoxD_dish_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewD_ingredients.Items.Clear();
            textBoxD_description.Text = "";
            pictureBoxD_description.Image = new Bitmap(Resources.borsh);
            foreach (var item in dishList)
            {
                if(listBoxD_dish.SelectedItem == item.Key)
                {
                    foreach(var element in dishList[item.Key])
                    {                        
                        listViewD_ingredients.Items.Add(element);
                    }
                }
            }
            foreach(var item in description)
            {
                if (listBoxD_dish.SelectedItem == item.Key)
                {
                    textBoxD_description.Text = item.Value;
                    pictureBoxD_description.Image = images[item.Key];
                }
            }
        }
    }
}

