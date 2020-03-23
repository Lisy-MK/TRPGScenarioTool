using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TRPGScenarioTool
{
    public partial class Form1 : Form
    {
        bool isEdit;

        public Form1()
        {
            InitializeComponent();

            //カレントディレクトリ内のフォルダ列挙
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(System.IO.Directory.GetCurrentDirectory());
            IEnumerable<System.IO.DirectoryInfo> files =
                    di.EnumerateDirectories("*", System.IO.SearchOption.TopDirectoryOnly);
            //ファイルを列挙する
            foreach (System.IO.DirectoryInfo f in files)
            {
                systemList.Items.Add(f.Name);
            }

            isEdit = true;
        }


        private void FileDataClear_Click(object sender, EventArgs e)
        {
            //フォルダ生成用入力部・編集可否のリセット
            systemName.Text = "";
            scenarioName.Text = "";
            campaignName.Text = "単発";
            isEdit = true;
        }

        private void New_Click(object sender, EventArgs e)
        {
            if (systemName.Text != "" && scenarioName.Text != "")
            {
                if (!systemList.Items.Contains(systemName.Text))
                {
                    Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory()
                        + "/" + systemName.Text);

                    systemList.Items.Add(systemName.Text);

                    if (!scenarioList.Items.Contains(scenarioName))
                    {
                        Directory.CreateDirectory(System.IO.Directory.GetCurrentDirectory()
                            + "/" + systemName.Text + "/" + "【" + campaignName.Text + "】" + scenarioName.Text);

                        scenarioList.Items.Add(systemName.Text);

                        // 文字コードを指定
                        Encoding enc = Encoding.GetEncoding("Shift_JIS");

                        // ファイルを開く
                        StreamWriter writer = new StreamWriter(System.IO.Directory.GetCurrentDirectory()
                                + "/" + systemName.Text
                                + "/" + "【" + campaignName.Text + "】" + scenarioName.Text
                                + "/" + "PreData.txt",
                                false,
                                enc);

                        writer.WriteLine("人数：1");
                        writer.WriteLine("形式：未定");
                        writer.WriteLine("■予告");

                        // ファイルを閉じる
                        writer.Close();

                    }
                }
            }
        }

        private void SystemList_SelectedIndexChanged(object sender, EventArgs e)
        {
            scenarioList.Items.Clear();

            systemName.Text = systemList.SelectedItem.ToString();

            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(System.IO.Directory.GetCurrentDirectory()
                + "/" + systemName.Text);
            IEnumerable<System.IO.DirectoryInfo> files =
                    di.EnumerateDirectories("*", System.IO.SearchOption.TopDirectoryOnly);
            //ファイルを列挙する
            foreach (System.IO.DirectoryInfo f in files)
            {
                scenarioList.Items.Add(f.Name);
            }
        }

        private void Mode()
        {
            if (scenarioList.SelectedItem.ToString() != "")
            {
                int start = scenarioList.SelectedItem.ToString().LastIndexOf("】");
                scenarioName.Text = scenarioList.SelectedItem.ToString().Substring(start + 1);
                campaignName.Text = scenarioList.SelectedItem.ToString().Substring(1, start - 1);

                StreamReader sr = new StreamReader(Directory.GetCurrentDirectory()
                    + "/" + systemName.Text
                    + "/" + "【" + campaignName.Text + "】" + scenarioName.Text
                    + "/" + "PreData.txt",
                    Encoding.GetEncoding("Shift_JIS"));

                string str = sr.ReadToEnd();

                sr.Close();

                int numE = str.IndexOf("\n形式：");
                num.Value = int.Parse(str.Substring(3, numE-3-1));



                string type = str.Substring(numE + 4, 2);

                vsE.Checked = false;
                vsP.Checked = false;
                vsQ.Checked = false;

                if (type == "協力")
                {
                    vsE.Checked = true;
                }
                if (type == "対立")
                {
                    vsP.Checked = true;
                }
                if (type == "特殊")
                {
                    vsQ.Checked = true;
                }

                preBox.Text = str.Substring(numE + 8);

                //カレントディレクトリ内のフォルダ列挙
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(System.IO.Directory.GetCurrentDirectory()
                    + "/" + systemName.Text
                    + "/" + "【" + campaignName.Text + "】" + scenarioName.Text);

                IEnumerable<System.IO.FileInfo> files =
                    di.EnumerateFiles("*", System.IO.SearchOption.TopDirectoryOnly);

                dataList1.Items.Clear();
                dataList2.Items.Clear();

                //ファイルを列挙する
                foreach (System.IO.FileInfo f in files)
                {
                    dataList1.Items.Add(f.Name.Substring(0, f.Name.Length - 4));
                    dataList2.Items.Add(f.Name.Substring(0, f.Name.Length - 4));
                }

                dataList1.Items.RemoveAt(0);
                dataList2.Items.RemoveAt(0);
            }
        }


        private void Edit_Click(object sender, EventArgs e)
        {
            Mode();

            isEdit = true;
        }

        private void View_Click(object sender, EventArgs e)
        {
            Mode();

            isEdit = true;
        }

        private void PredataSave_Click(object sender, EventArgs e)
        {
            string typename = "未定";
            if (vsE.Checked)
            {
                typename = "協力";
            }
            if (vsP.Checked)
            {
                typename = "対立";
            }
            if (vsQ.Checked)
            {
                typename = "特殊";
            }

            // 文字コードを指定
            Encoding enc = Encoding.GetEncoding("Shift_JIS");

            // ファイルを開く
            StreamWriter writer = new StreamWriter(System.IO.Directory.GetCurrentDirectory()
                    + "/" + systemName.Text
                    + "/" + "【" + campaignName.Text + "】" + scenarioName.Text
                    + "/" + "PreData.txt",
                    false,
                    enc);

            writer.WriteLine("人数：" + num.Value.ToString());
            writer.WriteLine("形式：" + typename);
            writer.Write(preBox.Text);

            // ファイルを閉じる
            writer.Close();
        }

        private void newData1_Click(object sender, EventArgs e)
        {
            dataName1.Text = "";
            box1.Text = "";
            ho1.Checked = false;
            sc1.Checked = false;
            info1.Checked = false;
            data1.Checked = false;
        }

        private void newData2_Click(object sender, EventArgs e)
        {
            dataName2.Text = "";
            box2.Text = "";
            ho2.Checked = false;
            sc2.Checked = false;
            info2.Checked = false;
            data2.Checked = false;
        }

        private void loadData1()
        {
            int start = dataList1.SelectedItem.ToString().LastIndexOf("】");
            dataName1.Text = dataList1.SelectedItem.ToString().Substring(start + 1);

            string str = dataList1.SelectedItem.ToString().Substring(1, dataList1.SelectedItem.ToString().IndexOf("】")-1);

            if(str == "ハンドアウト")
            {
                ho1.Checked = true;
            }
            if (str == "シーン")
            {
                sc1.Checked = true;
            }
            if (str == "情報")
            {
                info1.Checked = true;
            }
            if (str == "データ")
            {
                data1.Checked = true;
            }

            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory()
                + "/" + systemName.Text
                + "/" + "【" + campaignName.Text + "】" + scenarioName.Text
                + "/" + "【" + str + "】" + dataName1.Text + ".txt",
                Encoding.GetEncoding("Shift_JIS"));

            box1.Text = sr.ReadToEnd();

            sr.Close();

        }

        private void loadData2()
        {
            int start = dataList2.SelectedItem.ToString().LastIndexOf("】");
            dataName2.Text = dataList2.SelectedItem.ToString().Substring(start + 1);

            string str = dataList2.SelectedItem.ToString().Substring(1, dataList2.SelectedItem.ToString().IndexOf("】")-1);

            if (str == "ハンドアウト")
            {
                ho2.Checked = true;
            }
            if (str == "シーン")
            {
                sc2.Checked = true;
            }
            if (str == "情報")
            {
                info2.Checked = true;
            }
            if (str == "データ")
            {
                data2.Checked = true;
            }


            StreamReader sr = new StreamReader(Directory.GetCurrentDirectory()
                + "/" + systemName.Text
                + "/" + "【" + campaignName.Text + "】" + scenarioName.Text
                + "/" + "【" + str + "】" + dataName2.Text + ".txt",
                Encoding.GetEncoding("Shift_JIS"));

            box2.Text = sr.ReadToEnd();

            sr.Close();
        }

        private void edit1_Click(object sender, EventArgs e)
        {
            loadData1();

            box1.ReadOnly = !isEdit;
            save1.Enabled = true;

            if(dataName1.Text == dataName2.Text)
            {
                box1.ReadOnly = false;
                save1.Enabled = false;
            }
        }

        private void edit2_Click(object sender, EventArgs e)
        {
            loadData2();

            box2.ReadOnly = !isEdit;
            save2.Enabled = true;

            if (dataName1.Text == dataName2.Text)
            {
                box2.ReadOnly = false;
                save2.Enabled = false;
            }
        }

        private void view1_Click(object sender, EventArgs e)
        {
            loadData1();

            box1.ReadOnly = false;
            save1.Enabled = false;
        }

        private void view2_Click(object sender, EventArgs e)
        {
            loadData2();

            box2.ReadOnly = false;
            save2.Enabled = false;
        }

        private void save1_Click(object sender, EventArgs e)
        {
            string title = "【";

            if (ho1.Checked)
            {
                title += "ハンドアウト";
            }
            if (sc1.Checked)
            {
                title += "シーン";
            }
            if (info1.Checked)
            {
                title += "情報";
            }
            if (data1.Checked)
            {
                title += "データ";
            }

            title += "】";


            // 文字コードを指定
            Encoding enc = Encoding.GetEncoding("Shift_JIS");

            // ファイルを開く
            StreamWriter writer = new StreamWriter(System.IO.Directory.GetCurrentDirectory()
                    + "/" + systemName.Text
                    + "/" + "【" + campaignName.Text + "】" + scenarioName.Text
                    + "/" + title + dataName1.Text + ".txt",
                    false,
                    enc);

            writer.Write(box1.Text);

            // ファイルを閉じる
            writer.Close();
        }

        private void save2_Click(object sender, EventArgs e)
        {
            string title = "【";

            if (ho2.Checked)
            {
                title += "ハンドアウト";
            }
            if (sc2.Checked)
            {
                title += "シーン";
            }
            if (info2.Checked)
            {
                title += "情報";
            }
            if (data2.Checked)
            {
                title += "データ";
            }

            title += "】";


            // 文字コードを指定
            Encoding enc = Encoding.GetEncoding("Shift_JIS");

            // ファイルを開く
            StreamWriter writer = new StreamWriter(System.IO.Directory.GetCurrentDirectory()
                    + "/" + systemName.Text
                    + "/" + "【" + campaignName.Text + "】" + scenarioName.Text
                    + "/" + title + dataName2.Text + ".txt",
                    false,
                    enc);

            writer.Write(box2.Text);

            // ファイルを閉じる
            writer.Close();
        }

        private void newAllSave_Click(object sender, EventArgs e)
        {
            PredataSave_Click(sender, e);
            if (box1.Text != "")
            {
                save1_Click(sender, e);
            }
            if (box2.Text != "")
            {
                save2_Click(sender, e);
            }
        }
    }
}
