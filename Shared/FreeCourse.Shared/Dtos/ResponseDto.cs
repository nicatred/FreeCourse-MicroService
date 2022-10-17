using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FreeCourse.Shared.Dtos
{
    public class Response<T>
    {
        public T Data { get; set; }

        [JsonIgnore]
        public int StatusCode { get; set; }


        [JsonIgnore]
        public bool IsSuccess { get; set; }

        public List<string> Errors { get; set; }

        public static Response<T> Success (T data,int statusCode)
        {
            return new Response<T> { Data = data, StatusCode = statusCode,IsSuccess =true};
        }
        public static Response<T> Success(int statusCode)
        {
            return new Response<T> {Data = default , StatusCode = statusCode, IsSuccess = true };
        }
        public static Response<T> Fail(List<string> errors,int statusCode)
        {
            return new Response<T> {Errors= errors,Data = default, StatusCode = statusCode, IsSuccess = false };
        }
        public static Response<T> Fail(string error, int statusCode)
        {
            return new Response<T> { Errors = new List<string> { error}, Data = default, StatusCode = statusCode, IsSuccess = false };
        }
    }
}
