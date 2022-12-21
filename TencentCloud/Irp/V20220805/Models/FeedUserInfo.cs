/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Irp.V20220805.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FeedUserInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户唯一ID，客户自定义用户ID，作为一个用户的唯一标识
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 用户设备ID数组，可传入用户的多个类型ID，详见UserIdInfo结构体，建议补齐，<b>用于构建用户画像信息</b>
        /// </summary>
        [JsonProperty("UserIdList")]
        public UserIdInfo[] UserIdList{ get; set; }

        /// <summary>
        /// 用户标签，多个标签用英文冒号联接，<b>用作特征，强烈建议</b>
        /// </summary>
        [JsonProperty("Tags")]
        public string Tags{ get; set; }

        /// <summary>
        /// 过滤列表，<b>会在推荐结果里过滤掉这类内容</b>
        /// </summary>
        [JsonProperty("DislikeInfoList")]
        public DislikeInfo[] DislikeInfoList{ get; set; }

        /// <summary>
        /// 用户年龄
        /// </summary>
        [JsonProperty("Age")]
        public long? Age{ get; set; }

        /// <summary>
        /// 用户性别： 0 - 未知 1 - 男 2 - 女
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
        /// 用户职业
        /// </summary>
        [JsonProperty("Occupation")]
        public string Occupation{ get; set; }

        /// <summary>
        /// 用户所属行业
        /// </summary>
        [JsonProperty("Industry")]
        public string Industry{ get; set; }

        /// <summary>
        /// 用户常驻国家，ISO 3166-1 alpha-2编码，参考<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2" target="_blank">ISO 3166-1 alpha-2</a>，中国：“CN”
        /// </summary>
        [JsonProperty("ResidentCountry")]
        public string ResidentCountry{ get; set; }

        /// <summary>
        /// 用户常驻省份，ISO 3166-2行政区编码，如中国参考<a href="https://zh.wikipedia.org/wiki/ISO_3166-2:CN" target="_blank">ISO_3166-2:CN</a>，广东省：“CN-GD”
        /// </summary>
        [JsonProperty("ResidentProvince")]
        public string ResidentProvince{ get; set; }

        /// <summary>
        /// 用户常驻城市，统一用国家最新标准地区行政编码，如：<a href="https://www.mca.gov.cn/article/sj/xzqh/2020/" target="_blank">2020年行政区编码</a>，
        /// </summary>
        [JsonProperty("ResidentCity")]
        public string ResidentCity{ get; set; }

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
        /// json字符串，用于画像数据的扩展，需要base64加密
        /// </summary>
        [JsonProperty("Extension")]
        public string Extension{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamArrayObj(map, prefix + "UserIdList.", this.UserIdList);
            this.SetParamSimple(map, prefix + "Tags", this.Tags);
            this.SetParamArrayObj(map, prefix + "DislikeInfoList.", this.DislikeInfoList);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Degree", this.Degree);
            this.SetParamSimple(map, prefix + "School", this.School);
            this.SetParamSimple(map, prefix + "Occupation", this.Occupation);
            this.SetParamSimple(map, prefix + "Industry", this.Industry);
            this.SetParamSimple(map, prefix + "ResidentCountry", this.ResidentCountry);
            this.SetParamSimple(map, prefix + "ResidentProvince", this.ResidentProvince);
            this.SetParamSimple(map, prefix + "ResidentCity", this.ResidentCity);
            this.SetParamSimple(map, prefix + "RegisterTimestamp", this.RegisterTimestamp);
            this.SetParamSimple(map, prefix + "MembershipLevel", this.MembershipLevel);
            this.SetParamSimple(map, prefix + "LastLoginTimestamp", this.LastLoginTimestamp);
            this.SetParamSimple(map, prefix + "LastLoginIp", this.LastLoginIp);
            this.SetParamSimple(map, prefix + "LastModifyTimestamp", this.LastModifyTimestamp);
            this.SetParamSimple(map, prefix + "Extension", this.Extension);
        }
    }
}

