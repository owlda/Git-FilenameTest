using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class File
    {
        public File()
        {

        }

        protected string filename, path;
        protected DataTable data = new DataTable();
        protected bool hasChanged = false;

        internal void Create(File fileCreate, string filename, string path)
        {


            fileCreate.Filename = filename;
            fileCreate.Path = path;
            fileCreate.Data = new DataTable();

            Console.WriteLine($"File name : {fileCreate.Filename} . Path : {fileCreate.Path}  File has been changed : {fileCreate.HasChanged.ToString()}");
            Console.ReadKey();
        }

        internal void Save(string newname)
        {
            this.Filename = newname;
            
        }
        internal void Show()
        {
            Console.WriteLine($"File name : {this.Filename} . Path : {this.Path}  File has been changed : {this.HasChanged.ToString()}");
        }
        public string Filename
        {
            get { return filename; }
            set
            {
                if (this.filename != value)

                {
                    this.filename = value;
                    this.hasChanged = true;
                }
                
            
            }
        }

        public string Path
        {
            get { return path; }
            set { path = value; }

        }

        public DataTable Data
        {
            get { return data; }
            set { data = value; }
        }

        public bool HasChanged
        {
            get { return hasChanged; }
            set
            {
                HasChanged = value;
            }
        }
    }
}
