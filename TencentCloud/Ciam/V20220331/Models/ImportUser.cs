/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Ciam.V20220331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImportUser : AbstractModel
    {
        
        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonProperty("ResidentIdentityCard")]
        public string ResidentIdentityCard{ get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 用户组ID
        /// </summary>
        [JsonProperty("UserGroup")]
        public string[] UserGroup{ get; set; }

        /// <summary>
        /// QQ qqOpenId
        /// </summary>
        [JsonProperty("QqOpenId")]
        public string QqOpenId{ get; set; }

        /// <summary>
        /// QQ qqUnionId
        /// </summary>
        [JsonProperty("QqUnionId")]
        public string QqUnionId{ get; set; }

        /// <summary>
        /// 微信wechatOpenId
        /// </summary>
        [JsonProperty("WechatOpenId")]
        public string WechatOpenId{ get; set; }

        /// <summary>
        /// 微信wechatUnionId
        /// </summary>
        [JsonProperty("WechatUnionId")]
        public string WechatUnionId{ get; set; }

        /// <summary>
        /// 支付宝alipayUserId
        /// </summary>
        [JsonProperty("AlipayUserId")]
        public string AlipayUserId{ get; set; }

        /// <summary>
        /// 企业微信weComUserId
        /// </summary>
        [JsonProperty("WeComUserId")]
        public string WeComUserId{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [JsonProperty("Birthdate")]
        public string Birthdate{ get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 坐标
        /// </summary>
        [JsonProperty("Locale")]
        public string Locale{ get; set; }

        /// <summary>
        /// 性别（MALE;FEMALE;UNKNOWN）
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender{ get; set; }

        /// <summary>
        /// 实名核验方式
        /// </summary>
        [JsonProperty("IdentityVerificationMethod")]
        public string IdentityVerificationMethod{ get; set; }

        /// <summary>
        /// 是否已实名核验
        /// </summary>
        [JsonProperty("IdentityVerified")]
        public bool? IdentityVerified{ get; set; }

        /// <summary>
        /// 工作
        /// </summary>
        [JsonProperty("Job")]
        public string Job{ get; set; }

        /// <summary>
        /// 国家
        /// </summary>
        [JsonProperty("Nationality")]
        public string Nationality{ get; set; }

        /// <summary>
        /// 时区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 密码密文
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 自定义属性
        /// </summary>
        [JsonProperty("CustomizationAttributes")]
        public MemberMap[] CustomizationAttributes{ get; set; }

        /// <summary>
        /// 密码盐
        /// </summary>
        [JsonProperty("Salt")]
        public Salt Salt{ get; set; }

        /// <summary>
        /// 密码加密方式（SHA1;BCRYPT）
        /// </summary>
        [JsonProperty("PasswordEncryptTypeEnum")]
        public string PasswordEncryptTypeEnum{ get; set; }

        /// <summary>
        /// 索引字段1
        /// </summary>
        [JsonProperty("IndexedAttribute1")]
        public string IndexedAttribute1{ get; set; }

        /// <summary>
        /// 索引字段2
        /// </summary>
        [JsonProperty("IndexedAttribute2")]
        public string IndexedAttribute2{ get; set; }

        /// <summary>
        /// 索引字段3
        /// </summary>
        [JsonProperty("IndexedAttribute3")]
        public string IndexedAttribute3{ get; set; }

        /// <summary>
        /// 索引字段4
        /// </summary>
        [JsonProperty("IndexedAttribute4")]
        public string IndexedAttribute4{ get; set; }

        /// <summary>
        /// 索引字段5
        /// </summary>
        [JsonProperty("IndexedAttribute5")]
        public string IndexedAttribute5{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "ResidentIdentityCard", this.ResidentIdentityCard);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamArraySimple(map, prefix + "UserGroup.", this.UserGroup);
            this.SetParamSimple(map, prefix + "QqOpenId", this.QqOpenId);
            this.SetParamSimple(map, prefix + "QqUnionId", this.QqUnionId);
            this.SetParamSimple(map, prefix + "WechatOpenId", this.WechatOpenId);
            this.SetParamSimple(map, prefix + "WechatUnionId", this.WechatUnionId);
            this.SetParamSimple(map, prefix + "AlipayUserId", this.AlipayUserId);
            this.SetParamSimple(map, prefix + "WeComUserId", this.WeComUserId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Birthdate", this.Birthdate);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Locale", this.Locale);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "IdentityVerificationMethod", this.IdentityVerificationMethod);
            this.SetParamSimple(map, prefix + "IdentityVerified", this.IdentityVerified);
            this.SetParamSimple(map, prefix + "Job", this.Job);
            this.SetParamSimple(map, prefix + "Nationality", this.Nationality);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamArrayObj(map, prefix + "CustomizationAttributes.", this.CustomizationAttributes);
            this.SetParamObj(map, prefix + "Salt.", this.Salt);
            this.SetParamSimple(map, prefix + "PasswordEncryptTypeEnum", this.PasswordEncryptTypeEnum);
            this.SetParamSimple(map, prefix + "IndexedAttribute1", this.IndexedAttribute1);
            this.SetParamSimple(map, prefix + "IndexedAttribute2", this.IndexedAttribute2);
            this.SetParamSimple(map, prefix + "IndexedAttribute3", this.IndexedAttribute3);
            this.SetParamSimple(map, prefix + "IndexedAttribute4", this.IndexedAttribute4);
            this.SetParamSimple(map, prefix + "IndexedAttribute5", this.IndexedAttribute5);
        }
    }
}

