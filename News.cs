using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApplication1.ASM4
{
    public class News : INews
    {
        public int ID;
        public String Title;
        public String PublishDate;
        public String Author;
        public String Content;
        public float AverageRate;
        public int[] RateList = new int[3];

        public News(int ID, String Title, String PublishDate, String Author, String Content, int[] RateList)
        {
            this.ID = ID;
            this.Title = Title;
            this.PublishDate = PublishDate;
            this.Author = Author;
            this.Content = Content;
            this.RateList = RateList;
        }
        
        public News()
        {}

        public int getID()
        {
            return ID;
        }
       
        public void setID(int ID){
            this.ID = ID;
        }
        
        public String getTitle(){
            return Title;
        }

        public void setTitle(String Title){
            this.Title = Title;
        }

        public String getPublishDate(){
            return PublishDate;
        }

        public void setPublishDate(String PublishDate){
            this.PublishDate = PublishDate;
        }

        public String getAuthor(){
            return Author;
        }

        public void setAuthor(String Author){
            this.Author = Author;
        }

        public String getContent(){
            return Content;
        }

        public void setContent(String Content){
            this.Content = Content;
        }

        public float getAverageRate(){
            return AverageRate;
        }

        public void Display()
        {
            Console.WriteLine(this.getTitle()+"--"+this.getPublishDate()+"--"+this.getAuthor()+ " -- "+this.getContent()+" -- "+this.getAverageRate());
        }

        public void Calculate()
        {
            int sum = 0;
            foreach (int Rate  in RateList)
            {
                sum += Rate;
            }

            AverageRate = (float) sum / RateList.Length;
        }

        internal void Add(News @news)
        {
            throw new NotImplementedException();
        }

        internal void Add(int ID, string Title, string PublishDate, string Author, string Content, float Avergate, object a)
        {
            throw new NotImplementedException();
        }
    }
}