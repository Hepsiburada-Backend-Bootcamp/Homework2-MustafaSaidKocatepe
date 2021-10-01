using Newtonsoft.Json;
using ResponseStates.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResponseStates.Models
{
    public class ResponseState
    {
        public Status Status { get; set; }

        public ResponseState()
        {
            Status = new Status();
        }

        public ResponseState(StateCode stateCode)
        {
            Status = new Status(stateCode);
        }

        public ResponseState(StateCode stateCode, params object[] message)
        {
            Status = new Status(stateCode, message);
        }

        public ResponseState(int code, string message)
        {
            Status = new Status(code, message);
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
    public class ResponseState<T>
    {
        public Status Status { get; set; }
        public T Content { get; set; }

        public ResponseState()
        {
            Status = new Status(StateCode.OK);
        }

        public ResponseState(T content)
        {
            Status = new Status(StateCode.OK);
            Content = content;
        }

        public ResponseState(StateCode stateCode)
        {
            Status = new Status(stateCode);
            Content = default;
        }

        public ResponseState(StateCode stateCode, T content) : this(content)
        {
            Status = new Status(stateCode);
        }

        public ResponseState(StateCode stateCode, T content, params object[] message) : this(content)
        {
            Status = new Status(stateCode, message);
        }

        public ResponseState(int code, string message, T content) : this(content)
        {
            Status = new Status(code, message);
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
