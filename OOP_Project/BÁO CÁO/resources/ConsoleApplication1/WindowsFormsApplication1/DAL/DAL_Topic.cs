using System;
using System.Collections.Generic;
using WindowsFormsApplication1.DATABASE;

namespace WindowsFormsApplication1.DAL
{
    internal class DAL_Topic
    {
        OOP_PROJECTEntities db = new OOP_PROJECTEntities();
        public DAL_Topic()
        {
        }

        internal List<Topic> getTopics()
        {
            var select = db.Topics;
            List<Topic> lst_Topics = new List<Topic>();
            foreach(var tmp in select)
            {
                lst_Topics.Add((Topic)tmp);
            }
            return lst_Topics;
        }
    }
}