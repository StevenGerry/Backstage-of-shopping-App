namespace backstage
{
    partial class BackStage
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackStage));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox_news = new System.Windows.Forms.GroupBox();
            this.button_news_del = new System.Windows.Forms.Button();
            this.textBox_newsnumber = new System.Windows.Forms.TextBox();
            this.label_newsnumber = new System.Windows.Forms.Label();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_replace = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_newscontext = new System.Windows.Forms.TextBox();
            this.textBox_newstitle = new System.Windows.Forms.TextBox();
            this.label_newcontent = new System.Windows.Forms.Label();
            this.label_news = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox_item = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_additem = new System.Windows.Forms.Button();
            this.textBox_itemstock = new System.Windows.Forms.TextBox();
            this.textBox_itemurl = new System.Windows.Forms.TextBox();
            this.textBox_itemprice = new System.Windows.Forms.TextBox();
            this.textBox_itemabout = new System.Windows.Forms.TextBox();
            this.textBox_itemname = new System.Windows.Forms.TextBox();
            this.textBox_itemnum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox_statics = new System.Windows.Forms.GroupBox();
            this.button_toexcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox_news.SuspendLayout();
            this.groupBox_item.SuspendLayout();
            this.groupBox_statics.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(139, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "选择";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(534, 418);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox_news
            // 
            this.groupBox_news.Controls.Add(this.button_news_del);
            this.groupBox_news.Controls.Add(this.textBox_newsnumber);
            this.groupBox_news.Controls.Add(this.label_newsnumber);
            this.groupBox_news.Controls.Add(this.button_clean);
            this.groupBox_news.Controls.Add(this.button_replace);
            this.groupBox_news.Controls.Add(this.button_add);
            this.groupBox_news.Controls.Add(this.textBox_newscontext);
            this.groupBox_news.Controls.Add(this.textBox_newstitle);
            this.groupBox_news.Controls.Add(this.label_newcontent);
            this.groupBox_news.Controls.Add(this.label_news);
            this.groupBox_news.Location = new System.Drawing.Point(563, 10);
            this.groupBox_news.Name = "groupBox_news";
            this.groupBox_news.Size = new System.Drawing.Size(459, 444);
            this.groupBox_news.TabIndex = 3;
            this.groupBox_news.TabStop = false;
            this.groupBox_news.Text = "编辑";
            this.groupBox_news.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_news_del
            // 
            this.button_news_del.Location = new System.Drawing.Point(236, 369);
            this.button_news_del.Name = "button_news_del";
            this.button_news_del.Size = new System.Drawing.Size(75, 24);
            this.button_news_del.TabIndex = 15;
            this.button_news_del.Text = "删除";
            this.button_news_del.UseVisualStyleBackColor = true;
            this.button_news_del.Click += new System.EventHandler(this.button_news_del_Click);
            // 
            // textBox_newsnumber
            // 
            this.textBox_newsnumber.Location = new System.Drawing.Point(88, 46);
            this.textBox_newsnumber.Name = "textBox_newsnumber";
            this.textBox_newsnumber.Size = new System.Drawing.Size(100, 21);
            this.textBox_newsnumber.TabIndex = 8;
            // 
            // label_newsnumber
            // 
            this.label_newsnumber.AutoSize = true;
            this.label_newsnumber.Location = new System.Drawing.Point(30, 45);
            this.label_newsnumber.Name = "label_newsnumber";
            this.label_newsnumber.Size = new System.Drawing.Size(53, 12);
            this.label_newsnumber.TabIndex = 7;
            this.label_newsnumber.Text = "新闻编号";
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(334, 369);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(75, 23);
            this.button_clean.TabIndex = 6;
            this.button_clean.Text = "清除";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // button_replace
            // 
            this.button_replace.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_replace.Location = new System.Drawing.Point(135, 369);
            this.button_replace.Name = "button_replace";
            this.button_replace.Size = new System.Drawing.Size(75, 23);
            this.button_replace.TabIndex = 5;
            this.button_replace.Text = "编辑";
            this.button_replace.UseVisualStyleBackColor = true;
            this.button_replace.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(35, 369);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 4;
            this.button_add.Text = "新增";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_newscontext
            // 
            this.textBox_newscontext.Location = new System.Drawing.Point(88, 164);
            this.textBox_newscontext.Multiline = true;
            this.textBox_newscontext.Name = "textBox_newscontext";
            this.textBox_newscontext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_newscontext.Size = new System.Drawing.Size(252, 166);
            this.textBox_newscontext.TabIndex = 3;
            this.textBox_newscontext.TextChanged += new System.EventHandler(this.textBox_newscontext_TextChanged);
            // 
            // textBox_newstitle
            // 
            this.textBox_newstitle.Location = new System.Drawing.Point(87, 105);
            this.textBox_newstitle.Name = "textBox_newstitle";
            this.textBox_newstitle.Size = new System.Drawing.Size(253, 21);
            this.textBox_newstitle.TabIndex = 2;
            // 
            // label_newcontent
            // 
            this.label_newcontent.AutoSize = true;
            this.label_newcontent.Location = new System.Drawing.Point(28, 164);
            this.label_newcontent.Name = "label_newcontent";
            this.label_newcontent.Size = new System.Drawing.Size(53, 12);
            this.label_newcontent.TabIndex = 1;
            this.label_newcontent.Text = "新闻内容";
            // 
            // label_news
            // 
            this.label_news.AutoSize = true;
            this.label_news.Location = new System.Drawing.Point(28, 105);
            this.label_news.Name = "label_news";
            this.label_news.Size = new System.Drawing.Size(53, 12);
            this.label_news.TabIndex = 0;
            this.label_news.Text = "新闻标题";
            this.label_news.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox_item
            // 
            this.groupBox_item.Controls.Add(this.button5);
            this.groupBox_item.Controls.Add(this.button_delete);
            this.groupBox_item.Controls.Add(this.button_edit);
            this.groupBox_item.Controls.Add(this.button_additem);
            this.groupBox_item.Controls.Add(this.textBox_itemstock);
            this.groupBox_item.Controls.Add(this.textBox_itemurl);
            this.groupBox_item.Controls.Add(this.textBox_itemprice);
            this.groupBox_item.Controls.Add(this.textBox_itemabout);
            this.groupBox_item.Controls.Add(this.textBox_itemname);
            this.groupBox_item.Controls.Add(this.textBox_itemnum);
            this.groupBox_item.Controls.Add(this.label8);
            this.groupBox_item.Controls.Add(this.label7);
            this.groupBox_item.Controls.Add(this.label6);
            this.groupBox_item.Controls.Add(this.label5);
            this.groupBox_item.Controls.Add(this.label4);
            this.groupBox_item.Controls.Add(this.label3);
            this.groupBox_item.Location = new System.Drawing.Point(563, 12);
            this.groupBox_item.Name = "groupBox_item";
            this.groupBox_item.Size = new System.Drawing.Size(462, 444);
            this.groupBox_item.TabIndex = 5;
            this.groupBox_item.TabStop = false;
            this.groupBox_item.Text = "编辑";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(364, 371);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 24);
            this.button5.TabIndex = 15;
            this.button5.Text = "清空";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(258, 371);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 24);
            this.button_delete.TabIndex = 14;
            this.button_delete.Text = "删除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_edit
            // 
            this.button_edit.Location = new System.Drawing.Point(154, 371);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(75, 24);
            this.button_edit.TabIndex = 13;
            this.button_edit.Text = "编辑";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_additem
            // 
            this.button_additem.Location = new System.Drawing.Point(53, 371);
            this.button_additem.Name = "button_additem";
            this.button_additem.Size = new System.Drawing.Size(75, 24);
            this.button_additem.TabIndex = 12;
            this.button_additem.Text = "新增";
            this.button_additem.UseVisualStyleBackColor = true;
            this.button_additem.Click += new System.EventHandler(this.button_additem_Click);
            // 
            // textBox_itemstock
            // 
            this.textBox_itemstock.Location = new System.Drawing.Point(139, 309);
            this.textBox_itemstock.Name = "textBox_itemstock";
            this.textBox_itemstock.Size = new System.Drawing.Size(100, 21);
            this.textBox_itemstock.TabIndex = 11;
            // 
            // textBox_itemurl
            // 
            this.textBox_itemurl.Location = new System.Drawing.Point(139, 270);
            this.textBox_itemurl.Name = "textBox_itemurl";
            this.textBox_itemurl.ReadOnly = true;
            this.textBox_itemurl.Size = new System.Drawing.Size(287, 21);
            this.textBox_itemurl.TabIndex = 10;
            // 
            // textBox_itemprice
            // 
            this.textBox_itemprice.Location = new System.Drawing.Point(139, 237);
            this.textBox_itemprice.Name = "textBox_itemprice";
            this.textBox_itemprice.Size = new System.Drawing.Size(100, 21);
            this.textBox_itemprice.TabIndex = 9;
            // 
            // textBox_itemabout
            // 
            this.textBox_itemabout.Location = new System.Drawing.Point(139, 135);
            this.textBox_itemabout.Multiline = true;
            this.textBox_itemabout.Name = "textBox_itemabout";
            this.textBox_itemabout.Size = new System.Drawing.Size(287, 85);
            this.textBox_itemabout.TabIndex = 8;
            // 
            // textBox_itemname
            // 
            this.textBox_itemname.Location = new System.Drawing.Point(139, 92);
            this.textBox_itemname.Name = "textBox_itemname";
            this.textBox_itemname.Size = new System.Drawing.Size(287, 21);
            this.textBox_itemname.TabIndex = 7;
            this.textBox_itemname.TextChanged += new System.EventHandler(this.textBox_itemname_TextChanged);
            // 
            // textBox_itemnum
            // 
            this.textBox_itemnum.Location = new System.Drawing.Point(139, 53);
            this.textBox_itemnum.Name = "textBox_itemnum";
            this.textBox_itemnum.Size = new System.Drawing.Size(100, 21);
            this.textBox_itemnum.TabIndex = 6;
            this.textBox_itemnum.TextChanged += new System.EventHandler(this.textBox_itemnum_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 309);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "库存数量";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "图片链接";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "产品价格";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "关于产品";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "产品名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(283, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "商品销售后台管理系统";
            // 
            // groupBox_statics
            // 
            this.groupBox_statics.Controls.Add(this.button_toexcel);
            this.groupBox_statics.Location = new System.Drawing.Point(1031, 12);
            this.groupBox_statics.Name = "groupBox_statics";
            this.groupBox_statics.Size = new System.Drawing.Size(136, 442);
            this.groupBox_statics.TabIndex = 7;
            this.groupBox_statics.TabStop = false;
            this.groupBox_statics.Text = "数据表操作";
            // 
            // button_toexcel
            // 
            this.button_toexcel.Location = new System.Drawing.Point(30, 32);
            this.button_toexcel.Name = "button_toexcel";
            this.button_toexcel.Size = new System.Drawing.Size(75, 23);
            this.button_toexcel.TabIndex = 0;
            this.button_toexcel.Text = "导出数据表";
            this.button_toexcel.UseVisualStyleBackColor = true;
            this.button_toexcel.Click += new System.EventHandler(this.button_toexcel_Click);
            // 
            // BackStage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 463);
            this.Controls.Add(this.groupBox_statics);
            this.Controls.Add(this.groupBox_news);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox_item);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BackStage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoMyPC 商品销售后台管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox_news.ResumeLayout(false);
            this.groupBox_news.PerformLayout();
            this.groupBox_item.ResumeLayout(false);
            this.groupBox_item.PerformLayout();
            this.groupBox_statics.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox_news;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label_news;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_replace;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_newscontext;
        private System.Windows.Forms.TextBox textBox_newstitle;
        private System.Windows.Forms.Label label_newcontent;
        private System.Windows.Forms.GroupBox groupBox_item;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_additem;
        private System.Windows.Forms.TextBox textBox_itemstock;
        private System.Windows.Forms.TextBox textBox_itemurl;
        private System.Windows.Forms.TextBox textBox_itemprice;
        private System.Windows.Forms.TextBox textBox_itemabout;
        private System.Windows.Forms.TextBox textBox_itemname;
        private System.Windows.Forms.TextBox textBox_itemnum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_newsnumber;
        private System.Windows.Forms.Label label_newsnumber;
        private System.Windows.Forms.Button button_news_del;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_statics;
        private System.Windows.Forms.Button button_toexcel;
    }
}

