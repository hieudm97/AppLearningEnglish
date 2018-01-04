using System;
using System.Collections.Generic;
using WindowsFormsApplication1.DATABASE;

namespace WindowsFormsApplication1.BUS
{
    internal class BUS_Topic
    {
        DAL.DAL_Topic dal_topic = new DAL.DAL_Topic();
        internal List<Topic> getTopics()
        {
            List<Topic> lst_topics = dal_topic.getTopics();
            return lst_topics;
        }
    }
}