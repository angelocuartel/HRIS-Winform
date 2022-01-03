
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace EISProject.DataBaseFunctions
{
    public sealed class DataGridAction<T>
    {
        public List<T> fullList { get; set; }

        public List<T> SearchedList { get; set; }
        Label labelEmptyHolder;
        Label recordlabelHolder;
        DataGridView dataGridView;
        public List<T> PrintList
        {
           get
            {
                if (isAllDisplayed)
                    return fullList;
                else
                    return SearchedList;
            }
        }
        private string showAllString;
        private bool isAllDisplayed;

        public   DataGridAction(Label labelEmptyHolder,Label recordLabelHolder,DataGridView dataGridView,List<T>list)
        {

                isAllDisplayed = true;
                this.labelEmptyHolder = labelEmptyHolder;
                this.recordlabelHolder = recordLabelHolder;
                this.dataGridView = dataGridView;
                fullList = list;
                SearchedList = list;
                this.dataGridView.AutoGenerateColumns = false;

              //  PopulateGridView(fullList);
            
          
            
        }

       

        public  Task PopulateGridView(List<T>list)
        {

           return Task.Run(() =>
            {
                if (list.Count > 0)
                {
                    this.labelEmptyHolder.Invoke((MethodInvoker)(() => this.labelEmptyHolder.Visible = false));
                    this.dataGridView.Invoke((MethodInvoker)(() => this.dataGridView.DataSource = list));
                }
                else
                {
                    this.dataGridView.Invoke((MethodInvoker)(() => this.dataGridView.DataSource = null));
                    this.labelEmptyHolder.Invoke((MethodInvoker)(() => this.labelEmptyHolder.Visible = true));
                }

                this.recordlabelHolder.Invoke((MethodInvoker)(() => this.recordlabelHolder.Text = list.Count.ToString()));

            });

        }





        public Task SearchGridView( string searchBy,params string[] specificPropertyNames)
        {
            return Task.Run(() =>
            {
                

                this.labelEmptyHolder.Invoke((MethodInvoker)(() => this.labelEmptyHolder.Visible = false));

                if (searchBy != string.Empty)
                {
                    foreach (var propertyName in specificPropertyNames)
                    {
                        SearchedList = fullList.AsQueryable().Where($"{propertyName}.ToString().Contains(@0)", searchBy).ToList();

                        isAllDisplayed = false;

                        if (SearchListIsZeroCount())
                        {
                            break;
                        }


                    }
                }
                else
                {
                    this.dataGridView.Invoke((MethodInvoker)(() => this.dataGridView.DataSource = fullList));

                    isAllDisplayed = true;
                }
            }
            );
          
        }

        private int FilterValidColumnHeader()
        {
            int count = 0;

            foreach (DataGridViewColumn item in this.dataGridView.Columns)
            {
                if (item.HeaderText == "" || item.HeaderText == "Action")
                {
                    count++;
                }
                    
            }

            return count;
        }


        public Task FilterGridView(string filterBy,string showAllString,bool hasImageColumn)
        {

            return Task.Run(() =>
            {

               

                var minus = hasImageColumn ? FilterValidColumnHeader(): 0;




                if (filterBy == showAllString)
                {
                    isAllDisplayed = true;
                    this.showAllString = showAllString;
                    this.dataGridView.Invoke((MethodInvoker)(() => this.dataGridView.DataSource = fullList));
                    this.labelEmptyHolder.Invoke((MethodInvoker)(() => this.labelEmptyHolder.Visible = false));

                }

                else if(filterBy == "UNASSIGNED")
                {
                    isAllDisplayed = false;
                    SearchedList = fullList.AsQueryable().Where("department_name.ToString().Contains(@0)", "UNASSIGNED").ToList();
                    SearchListIsZeroCount();
                }

                else
                {



                    this.showAllString = string.Empty;

                    for (int i = 0; i < this.dataGridView.Columns.Count - minus; i++)
                    {
                        SearchedList = fullList.AsQueryable().Where($"{this.dataGridView.Columns[i].DataPropertyName}.ToString().Contains(@0)", filterBy).ToList();

                        isAllDisplayed = false;

                        if (SearchListIsZeroCount())
                        {
                            break;
                        }



                    }
                }
            }
            );
          
           
        }






        private string sortType = "Ascending";
        public Task SortGridView(string propertyName)
        {
            return Task.Run(() =>
            {
                if (propertyName != string.Empty )
                {

                    if (SearchedList.Count < 1 && !labelEmptyHolder.Visible || showAllString != string.Empty)
                        PopulateGridView(fullList.AsQueryable().OrderBy($"{propertyName} {sortType}").ToList());
                    else
                        PopulateGridView(SearchedList.AsQueryable().OrderBy($"{propertyName} {sortType}").ToList());

                    sortType = sortType == "Ascending" ? "Descending" : "Ascending";
                }
               
            });
          
        }


        private bool SearchListIsZeroCount()
        {

            if (SearchedList.Count > 0)
            {
                this.labelEmptyHolder.Invoke((MethodInvoker)(() => this.labelEmptyHolder.Visible = false));
                this.dataGridView.Invoke((MethodInvoker)(() => this.dataGridView.DataSource = SearchedList));
                return true;
            }
            else
            {
                this.labelEmptyHolder.Invoke((MethodInvoker)(() => this.labelEmptyHolder.Visible = true));
                 this.dataGridView.Invoke((MethodInvoker)(() => this.dataGridView.DataSource = null));
                return false;
            }
        }








    }
}
