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

namespace TencentCloud.Irp.V20220324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PortraitInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户id列表
        /// </summary>
        [JsonProperty("UserIdList")]
        public UserIdInfo[] UserIdList{ get; set; }

        /// <summary>
        /// 如果"userIdType"是10则必传，在微信开放平台上查看appId
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 用户年龄，值域在 0-200
        /// </summary>
        [JsonProperty("Age")]
        public long? Age{ get; set; }

        /// <summary>
        /// 用户性别：0-未知，1-男， 2-女
        /// </summary>
        [JsonProperty("Gender")]
        public long? Gender{ get; set; }

        /// <summary>
        /// 用户学历 ：小学，初中，高中，大专，本科，硕士，博士
        /// </summary>
        [JsonProperty("Degree")]
        public string Degree{ get; set; }

        /// <summary>
        /// 用户毕业学校全称
        /// </summary>
        [JsonProperty("School")]
        public string School{ get; set; }

        /// <summary>
        /// 用户职业，保证业务的唯一性
        /// </summary>
        [JsonProperty("Occupation")]
        public string Occupation{ get; set; }

        /// <summary>
        /// 用户所属行业，保证业务的唯一性
        /// </summary>
        [JsonProperty("Industry")]
        public string Industry{ get; set; }

        /// <summary>
        /// 用户常驻国家，统一用简写，比如中国则填写CN
        /// </summary>
        [JsonProperty("ResidentCountry")]
        public string ResidentCountry{ get; set; }

        /// <summary>
        /// 用户常驻省份
        /// </summary>
        [JsonProperty("ResidentProvince")]
        public string ResidentProvince{ get; set; }

        /// <summary>
        /// 用户常驻城市
        /// </summary>
        [JsonProperty("ResidentCity")]
        public string ResidentCity{ get; set; }

        /// <summary>
        /// 用户常驻区县
        /// </summary>
        [JsonProperty("ResidentDistrict")]
        public string ResidentDistrict{ get; set; }

        /// <summary>
        /// 用户手机的MD5值
        /// </summary>
        [JsonProperty("PhoneMd5")]
        public string PhoneMd5{ get; set; }

        /// <summary>
        /// 用户手机的IMEI号
        /// </summary>
        [JsonProperty("PhoneImei")]
        public string PhoneImei{ get; set; }

        /// <summary>
        /// 设备idfa信息
        /// </summary>
        [JsonProperty("Idfa")]
        public string Idfa{ get; set; }

        /// <summary>
        /// 用户注册时间，秒级时间戳（1639624786）
        /// </summary>
        [JsonProperty("RegisterTimestamp")]
        public long? RegisterTimestamp{ get; set; }

        /// <summary>
        /// 用户会员等级
        /// </summary>
        [JsonProperty("MembershipLevel")]
        public string MembershipLevel{ get; set; }

        /// <summary>
        /// 用户上一次登录时间，秒级时间戳（1639624786）
        /// </summary>
        [JsonProperty("LastLoginTimestamp")]
        public long? LastLoginTimestamp{ get; set; }

        /// <summary>
        /// 用户上一次登录的ip
        /// </summary>
        [JsonProperty("LastLoginIp")]
        public string LastLoginIp{ get; set; }

        /// <summary>
        /// 用户信息的最后修改时间戳，秒级时间戳（1639624786）
        /// </summary>
        [JsonProperty("LastModifyTimestamp")]
        public long? LastModifyTimestamp{ get; set; }

        /// <summary>
        /// 用户标签
        /// </summary>
        [JsonProperty("TagInfoList")]
        public TagInfo[] TagInfoList{ get; set; }

        /// <summary>
        /// 用户关注作者列表
        /// </summary>
        [JsonProperty("AuthorInfoList")]
        public AuthorInfo[] AuthorInfoList{ get; set; }

        /// <summary>
        /// 用户不喜欢列表
        /// </summary>
        [JsonProperty("DislikeInfoList")]
        public DislikeInfo[] DislikeInfoList{ get; set; }

        /// <summary>
        /// json字符串，用于画像数据的扩展
        /// </summary>
        [JsonProperty("Extension")]
        public string Extension{ get; set; }

        /// <summary>
        /// 设备oaid信息
        /// </summary>
        [JsonProperty("Oaid")]
        public string Oaid{ get; set; }

        /// <summary>
        /// 设备AndroidId信息
        /// </summary>
        [JsonProperty("AndroidId")]
        public string AndroidId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "UserIdList.", this.UserIdList);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Degree", this.Degree);
            this.SetParamSimple(map, prefix + "School", this.School);
            this.SetParamSimple(map, prefix + "Occupation", this.Occupation);
            this.SetParamSimple(map, prefix + "Industry", this.Industry);
            this.SetParamSimple(map, prefix + "ResidentCountry", this.ResidentCountry);
            this.SetParamSimple(map, prefix + "ResidentProvince", this.ResidentProvince);
            this.SetParamSimple(map, prefix + "ResidentCity", this.ResidentCity);
            this.SetParamSimple(map, prefix + "ResidentDistrict", this.ResidentDistrict);
            this.SetParamSimple(map, prefix + "PhoneMd5", this.PhoneMd5);
            this.SetParamSimple(map, prefix + "PhoneImei", this.PhoneImei);
            this.SetParamSimple(map, prefix + "Idfa", this.Idfa);
            this.SetParamSimple(map, prefix + "RegisterTimestamp", this.RegisterTimestamp);
            this.SetParamSimple(map, prefix + "MembershipLevel", this.MembershipLevel);
            this.SetParamSimple(map, prefix + "LastLoginTimestamp", this.LastLoginTimestamp);
            this.SetParamSimple(map, prefix + "LastLoginIp", this.LastLoginIp);
            this.SetParamSimple(map, prefix + "LastModifyTimestamp", this.LastModifyTimestamp);
            this.SetParamArrayObj(map, prefix + "TagInfoList.", this.TagInfoList);
            this.SetParamArrayObj(map, prefix + "AuthorInfoList.", this.AuthorInfoList);
            this.SetParamArrayObj(map, prefix + "DislikeInfoList.", this.DislikeInfoList);
            this.SetParamSimple(map, prefix + "Extension", this.Extension);
            this.SetParamSimple(map, prefix + "Oaid", this.Oaid);
            this.SetParamSimple(map, prefix + "AndroidId", this.AndroidId);
        }
    }
}

