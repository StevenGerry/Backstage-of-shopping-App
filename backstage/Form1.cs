using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;
using System.Xml;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
/*
本程序使用 MySql.Data.dll 链接Mysql数据库，读取服务器中所有数据库的名称，显示在界面上。HoverTree
*/

namespace backstage
{

    public partial class BackStage : Form
    {
        private MySqlConnection _conn;

        public BackStage()
        {
            InitializeComponent();
        }

        public bool ExportDataGridviewExcel(DataGridView gridview, bool isShowExcel)

        {

            if (gridview.Rows.Count == 0)

            {

                return false;

            }

            //建立Excel对象

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();

            excel.Application.Workbooks.Add(true);

            excel.Visible = isShowExcel;

            //生成字段名称

            for (int i = 0; i < gridview.Columns.Count; i++)

            {

                excel.Cells[1, i + 1] = gridview.Columns[i].HeaderText;

            }

            //填充数据

            for (int i = 0; i < gridview.Rows.Count - 1; i++)

            {

                for (int j = 0; j < gridview.Columns.Count; j++)

                {

                    if (gridview[j, i].ValueType == typeof(string))

                    {

                        excel.Cells[i + 2, j + 1] = "" + gridview[j, i].Value.ToString();

                    }

                    else

                    {

                        excel.Cells[i + 2, j + 1] = gridview[j, i].Value.ToString();

                    }

                }

            }

            return true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.ToString()=="item")
            {
                groupBox_item.Visible = true;
                groupBox_news.Visible = false;
            }
            else if (comboBox1.Text.ToString() == "news")
            {
                groupBox_item.Visible = false;
                groupBox_news.Visible = true;
            }
            else if (comboBox1.Text.ToString() == "statics")
            {
                groupBox_item.Visible = false;
                groupBox_news.Visible = false;
                groupBox_statics.Visible = true;

            }
            MySqlConnection _connc;
            String sql = "select * from " + comboBox1.Text.ToString();
            if (comboBox1.Text.ToString() == "statics")
            {
                sql = "SELECT COUNT(orderid) as '订单总数统计', SUM(ordernumber) as '销售商品总数' from orderlist";
            }
            String h_connString = "server=hwhhome.net;user id=huayuwenhao; password=ZjHWrgnLZZsVUzKJ; port=3306; database=domypc; pooling=false; charset=utf8";//根据实际修改
            try
            {
                _connc = new MySqlConnection(h_connString);
                if (_connc != null)
                    _connc.Close();
                _connc.Open();
                MySqlDataReader reader = null;
                MySqlDataAdapter myadp = new MySqlDataAdapter(sql, _connc);
                DataSet ds = new DataSet();
                try
                {
                    myadp.Fill(ds, "content");
                    dataGridView1.DataSource = ds.Tables["content"];
                    if (comboBox1.Text.ToString() == "item")
                    {
                        dataGridView1.ColumnHeadersVisible = true;
                        dataGridView1.Columns[0].HeaderText = "商品编号";
                        dataGridView1.Columns[1].HeaderText = "商品名称";
                        dataGridView1.Columns[2].HeaderText = "商品详情";
                        dataGridView1.Columns[3].HeaderText = "商品价格";
                        dataGridView1.Columns[4].HeaderText = "商品图片";
                        dataGridView1.Columns[5].HeaderText = "商品库存";
                    }
                    else if (comboBox1.Text.ToString() == "news")
                    {
                        groupBox_item.Visible = false;
                        groupBox_news.Visible = true;
                        dataGridView1.Columns[0].HeaderText = "新闻编号";
                        dataGridView1.Columns[1].HeaderText = "新闻标题";
                        dataGridView1.Columns[2].HeaderText = "新闻内容";
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Failed:" + ex.Message);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("操作失败，请检查输入或检查网络！: " + ex.Message);
            }

        }
        private void listBox_database_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox_item.Visible = false;
            groupBox_news.Visible = false;
            //         if (_conn != null)
            //             _conn.Close();
            //        string h_connString = "server=hwhhome.net;user id=huayuwenhao; password=ZjHWrgnLZZsVUzKJ; port=3306; database=domypc; pooling=false; charset=utf8";//根据实际修改
            //        try
            //         {
            //             _conn = new MySqlConnection(h_connString);
            //             _conn.Open();
            //             MySqlDataReader reader = null;
            //             MySqlDataAdapter myadp = new MySqlDataAdapter("show tables", _conn);
            //             DataSet ds = new DataSet();
            //             try
            //             {
            //                 myadp.Fill(ds, "table");
            //                 comboBox1.DataSource = ds.Tables["table"];
            //                 comboBox1.DisplayMember = ds.Tables["table"].Columns[0].ToString();
            //
            //              }
            //             catch (MySqlException ex)
            //            {
            //               MessageBox.Show("Failed:" + ex.Message);
            //           }
            //      }
            //     catch (MySqlException ex)
            //    {
            //       MessageBox.Show("操作失败，请检查输入或检查网络！: " + ex.Message);
            //   }
            ArrayList list = new ArrayList();
            list.Add(new DictionaryEntry("item", "1"));
            list.Add(new DictionaryEntry("news", "2"));
            list.Add(new DictionaryEntry("statics", "3"));
            comboBox1.DataSource = list;
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection _connc;
            String sql = "update news set newstitle = '" + textBox_newstitle.Text.ToString() + "', newscontent = '" + textBox_newscontext.Text.ToString() + "' where newsid = '" + textBox_newsnumber.Text.ToString() + "'";
            string h_connString = "server=hwhhome.net;user id=huayuwenhao; password=ZjHWrgnLZZsVUzKJ; port=3306; database=domypc; pooling=false; charset=utf8";//根据实际修改
            try
            {
                _connc = new MySqlConnection(h_connString);
                if (_connc != null)
                    _connc.Close();
                _connc.Open();
                MySqlCommand mycmd = new MySqlCommand(sql, _connc);
                mycmd.ExecuteNonQuery();
                try
                {
                    MySqlConnection _connc2;
                    _connc2 = new MySqlConnection(h_connString);
                    String sql2 = "select * from " + comboBox1.Text.ToString();
                    MySqlDataReader reader = null;
                    MySqlDataAdapter myadp = new MySqlDataAdapter(sql2, _connc2);
                    DataSet ds = new DataSet();

                    myadp.Fill(ds, "content");
                    dataGridView1.DataSource = ds.Tables["content"];
                    _connc.Close();
                    _connc2.Close();
                    MessageBox.Show("更改新闻成功！");
                    textBox_newsnumber.ReadOnly = false;
                    textBox_newsnumber.Text = "";
                    textBox_newstitle.Text = "";
                    textBox_newscontext.Text = "";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("操作失败，请检查输入或检查网络！: " + ex.Message);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            MySqlConnection _connc;
            String sql = "insert into news (newsid, newstitle, newscontent) values ('" + textBox_newsnumber.Text.ToString() + "','" + textBox_newstitle.Text.ToString() + "','" + textBox_newscontext.Text.ToString() + "')";
            string h_connString = "server=hwhhome.net;user id=huayuwenhao; password=ZjHWrgnLZZsVUzKJ; port=3306; database=domypc; pooling=false; charset=utf8";//根据实际修改
            try
            {
                _connc = new MySqlConnection(h_connString);
                if (_connc != null)
                    _connc.Close();
                _connc.Open();
                MySqlCommand mycmd = new MySqlCommand(sql, _connc);
                mycmd.ExecuteNonQuery();
                try
                {
                    MySqlConnection _connc2;
                    _connc2 = new MySqlConnection(h_connString);
                    String sql2 = "select * from " + comboBox1.Text.ToString();
                    MySqlDataReader reader = null;
                    MySqlDataAdapter myadp = new MySqlDataAdapter(sql2, _connc2);
                    DataSet ds = new DataSet();

                    myadp.Fill(ds, "content");
                    dataGridView1.DataSource = ds.Tables["content"];
                    _connc.Close();
                    _connc2.Close();
                    MessageBox.Show("新增新闻成功！");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("操作失败，请检查输入或检查网络！: " + ex.Message);
            }
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            this.textBox_newsnumber.Text = "";
            this.textBox_newstitle.Text = "";
            this.textBox_newscontext.Text = "";
            textBox_newsnumber.ReadOnly = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.textBox_itemnum.Text = "";
            this.textBox_itemname.Text = "";
            this.textBox_itemabout.Text = "";
            this.textBox_itemprice.Text = "";
            this.textBox_itemurl.Text = "";
            this.textBox_itemstock.Text = "";
            textBox_itemnum.ReadOnly = false;
        }

        private void textBox_itemname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_additem_Click(object sender, EventArgs e)
        {
            MySqlConnection _connc;
            String sql = "insert into item (itemid, itemname, itemabout, itemcost, imageurl, itemnumber) values ('"+textBox_itemnum.Text.ToString()+"','"+textBox_itemname.Text.ToString() + "','"+textBox_itemabout.Text.ToString() + "','"+textBox_itemprice.Text.ToString() + "','"+textBox_itemurl.Text.ToString() + "','"+textBox_itemstock.Text.ToString() + "')";
            string h_connString = "server=hwhhome.net;user id=huayuwenhao; password=ZjHWrgnLZZsVUzKJ; port=3306; database=domypc; pooling=false; charset=utf8";//根据实际修改
            try
            {
                _connc = new MySqlConnection(h_connString);
                if (_connc != null)
                    _connc.Close();
                _connc.Open();
                MySqlCommand mycmd = new MySqlCommand(sql, _connc);
                mycmd.ExecuteNonQuery();
                try
                {
                    MySqlConnection _connc2;
                _connc2 = new MySqlConnection(h_connString);
                String sql2 = "select * from " + comboBox1.Text.ToString();
                MySqlDataReader reader = null;
                MySqlDataAdapter myadp = new MySqlDataAdapter(sql2, _connc2);
                DataSet ds = new DataSet();

                    myadp.Fill(ds, "content");
                    dataGridView1.DataSource = ds.Tables["content"];
                    _connc.Close();
                    _connc2.Close();
                    MessageBox.Show("新增项目成功！");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("操作失败，请检查输入或检查网络！: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox1.Text.ToString() == "item")
            {
                String itemid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                String itemname = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                String itemabout = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                String itemcost = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                String imageurl = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                String itemnumber = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox_itemnum.Text = itemid;
                textBox_itemname.Text = itemname;
                textBox_itemabout.Text = itemabout;
                textBox_itemprice.Text = itemcost;
                textBox_itemurl.Text = imageurl;
                textBox_itemstock.Text = itemnumber;
                textBox_itemnum.ReadOnly = true;
            }
            else if (comboBox1.Text.ToString() == "news")
            {
                String newsid = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                String newstitle = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                String newscontent = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox_newsnumber.Text = newsid;
                textBox_newstitle.Text = newstitle;
                textBox_newscontext.Text = newscontent;
                textBox_newsnumber.ReadOnly = true;
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            MySqlConnection _connc;
            String sql = "update item set itemname = '" + textBox_itemname.Text.ToString() + "', itemabout = '" + textBox_itemabout.Text.ToString() + "', itemcost = '" + textBox_itemprice.Text.ToString() + "', imageurl = '" + textBox_itemurl.Text.ToString() + "', itemnumber = '" + textBox_itemstock.Text.ToString() + "' where itemid = '" + textBox_itemnum.Text.ToString() + "'";
            string h_connString = "server=hwhhome.net;user id=huayuwenhao; password=ZjHWrgnLZZsVUzKJ; port=3306; database=domypc; pooling=false; charset=utf8";//根据实际修改
            try
            {
                _connc = new MySqlConnection(h_connString);
                if (_connc != null)
                    _connc.Close();
                _connc.Open();
                MySqlCommand mycmd = new MySqlCommand(sql, _connc);
                mycmd.ExecuteNonQuery();
                try
                {
                    MySqlConnection _connc2;
                    _connc2 = new MySqlConnection(h_connString);
                    String sql2 = "select * from " + comboBox1.Text.ToString();
                    MySqlDataReader reader = null;
                    MySqlDataAdapter myadp = new MySqlDataAdapter(sql2, _connc2);
                    DataSet ds = new DataSet();

                    myadp.Fill(ds, "content");
                    dataGridView1.DataSource = ds.Tables["content"];
                    _connc.Close();
                    _connc2.Close();
                    MessageBox.Show("更改项目成功！");
                    textBox_itemnum.ReadOnly = false;
                    textBox_itemnum.Text = "";
                    textBox_itemname.Text = "";
                    textBox_itemabout.Text = "";
                    textBox_itemprice.Text = "";
                    textBox_itemurl.Text = "";
                    textBox_itemstock.Text = "";
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("操作失败，请检查输入或检查网络！: " + ex.Message);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否确定删除项目", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                MySqlConnection _connc;
                String sql = "delete from item where itemid = '" + textBox_itemnum.Text.ToString() + "'";
                string h_connString = "server=hwhhome.net;user id=huayuwenhao; password=ZjHWrgnLZZsVUzKJ; port=3306; database=domypc; pooling=false; charset=utf8";//根据实际修改
                try
                {
                    _connc = new MySqlConnection(h_connString);
                    if (_connc != null)
                        _connc.Close();
                    _connc.Open();
                    MySqlCommand mycmd = new MySqlCommand(sql, _connc);
                    mycmd.ExecuteNonQuery();
                    try
                    {
                        MySqlConnection _connc2;
                        _connc2 = new MySqlConnection(h_connString);
                        String sql2 = "select * from " + comboBox1.Text.ToString();
                        MySqlDataReader reader = null;
                        MySqlDataAdapter myadp = new MySqlDataAdapter(sql2, _connc2);
                        DataSet ds = new DataSet();

                        myadp.Fill(ds, "content");
                        dataGridView1.DataSource = ds.Tables["content"];
                        _connc.Close();
                        _connc2.Close();
                        MessageBox.Show("删除项目成功！");
                        textBox_itemnum.ReadOnly = false;
                        textBox_itemnum.Text = "";
                        textBox_itemname.Text = "";
                        textBox_itemabout.Text = "";
                        textBox_itemprice.Text = "";
                        textBox_itemurl.Text = "";
                        textBox_itemstock.Text = "";
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("操作失败，请检查输入或检查网络！: " + ex.Message);
                }
            }
        }

        private void textBox_newscontext_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_news_del_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否确定删除新闻条目", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                MySqlConnection _connc;
                String sql = "delete from news where newsid = '" + textBox_newsnumber.Text.ToString() + "'";
                string h_connString = "server=hwhhome.net;user id=huayuwenhao; password=ZjHWrgnLZZsVUzKJ; port=3306; database=domypc; pooling=false; charset=utf8";//根据实际修改
                try
                {
                    _connc = new MySqlConnection(h_connString);
                    if (_connc != null)
                        _connc.Close();
                    _connc.Open();
                    MySqlCommand mycmd = new MySqlCommand(sql, _connc);
                    mycmd.ExecuteNonQuery();
                    try
                    {
                        MySqlConnection _connc2;
                        _connc2 = new MySqlConnection(h_connString);
                        String sql2 = "select * from " + comboBox1.Text.ToString();
                        MySqlDataReader reader = null;
                        MySqlDataAdapter myadp = new MySqlDataAdapter(sql2, _connc2);
                        DataSet ds = new DataSet();

                        myadp.Fill(ds, "content");
                        dataGridView1.DataSource = ds.Tables["content"];
                        _connc.Close();
                        _connc2.Close();
                        MessageBox.Show("删除新闻成功！");
                        textBox_newsnumber.ReadOnly = false;
                        textBox_newsnumber.Text = "";
                        textBox_newstitle.Text = "";
                        textBox_newscontext.Text = "";
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("操作失败，请检查输入或检查网络！: " + ex.Message);
                }
            }
        }

        private void textBox_itemnum_TextChanged(object sender, EventArgs e)
        {
            textBox_itemurl.Text = "http://hwhhome.net/syt/item_image/item_" + textBox_itemnum.Text.ToString() + ".jpg";
            if (textBox_itemnum.Text.ToString() == "")
                textBox_itemurl.Text = "";
        }

        private void button_toexcel_Click(object sender, EventArgs e)
        {
            ExportDataGridviewExcel(dataGridView1, true);
        }
    }
}