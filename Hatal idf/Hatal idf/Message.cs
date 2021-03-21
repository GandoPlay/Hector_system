using Hatal_idf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public enum ErrorType
{
    invaild_Type,
    success,
    invaild_Action,
    invaild_Time,
    invaild_Rate,
    invaild_Urgency
}
public class Message : IErrorChecker
{
    public Message()
    {
    }

    public DateTime Time { get; set; }
    public TypeMessage Type { get; set; }
    public ActionMessage Action { get; set; }

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }
    public  ErrorType CheckMessage()
    {
       
        if (DateTime.Compare(Time, DateTime.Today) > 0)
        {
            return ErrorType.invaild_Time;
        }
        if (Type.End + Type.Start > 1)
        {
            return ErrorType.invaild_Type;
        }
        else if(Type.classification!=null)
        {
            if (Type.End == 1 || Type.Start == 1)
                return ErrorType.invaild_Type;
            else if (Type.classification.Rate > 5 || Type.classification.Rate < 0)
                return ErrorType.invaild_Rate;
            else if (Type.classification.Urgency < 0 || Type.classification.Urgency > 10)
                return ErrorType.invaild_Urgency;
        }
        if(Action.Action!="request"&& Action.Action != "answer")
        {
            return ErrorType.invaild_Action;
        }
        else if (Action.IsOk)
        {
            if (Action.Action == "request")
            {
                return ErrorType.invaild_Action;
            }
        }
        return ErrorType.success;




    }




    public override string ToString()
    {
        return "||Time: " + Time + " ||Type: " + Type.ToString() + " ||Action: " + Action.ToString()+ " ||";
    }

    public class ActionMessage
    {
        public string Action { get; set; }

        public bool IsOk { get; set; }

        public override string ToString()
        {
            string mes = "Action: " + Action;
            if (Action == "answer")
            {
                if (IsOk)
                    mes += " succeded!";
                else
                    mes += " ERROR";
            }
            return mes;
        }
    }

    public class TypeMessage
    {
        public Classification classification { get; set; }
        public int End { get; set; }
        public int Start { get; set; }

        public override string ToString()
        {
            if (End == 1)
            {
                return "End communication";
            }
            else if (Start == 1)
            {
                return "Start communication";
            }
            else
            {
                return "Classifcation: " + classification.ToString();
            }
        }

        public class Classification
        {
            public int Urgency { get; set; }
            public int Rate { get; set; }
            public override string ToString()
            {
                return "Urgency: " + Urgency + " Rate: " + Rate;
            }
        }


    }


}
    