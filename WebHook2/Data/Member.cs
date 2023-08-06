using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebHook1.Data
{
    public class Member
    {
        public ObjectId _id { get; set; }  //隨機Id
        public string LineId { get; set; } //會員的LineId; 是放Line Token
        public string? LineNickName { get; set; } //Line的暱稱
        public string? Phone { get; set; } //會員電話號碼
        public string? UserName { get; set; } //會員名字
        public string? Email { get; set; } //會員email
        public string? Gender { get; set; } //會員性別
        public string? Birth { get; set; } //會員生日
        //public List<Discount>? Discounts { get; set; } //會員點數集合,可以有很多品牌的點數,

    }
}
