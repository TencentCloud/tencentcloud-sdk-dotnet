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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ContactInfo : AbstractModel
    {
        
        /// <summary>
        /// 注册人（中文）
        /// </summary>
        [JsonProperty("OrganizationNameCN")]
        public string OrganizationNameCN{ get; set; }

        /// <summary>
        /// 注册人（英文）
        /// </summary>
        [JsonProperty("OrganizationName")]
        public string OrganizationName{ get; set; }

        /// <summary>
        /// 联系人（中文）
        /// </summary>
        [JsonProperty("RegistrantNameCN")]
        public string RegistrantNameCN{ get; set; }

        /// <summary>
        /// 联系人（英文）
        /// </summary>
        [JsonProperty("RegistrantName")]
        public string RegistrantName{ get; set; }

        /// <summary>
        /// 省份（中文）
        /// </summary>
        [JsonProperty("ProvinceCN")]
        public string ProvinceCN{ get; set; }

        /// <summary>
        /// 城市（中文）
        /// </summary>
        [JsonProperty("CityCN")]
        public string CityCN{ get; set; }

        /// <summary>
        /// 街道（中文）
        /// </summary>
        [JsonProperty("StreetCN")]
        public string StreetCN{ get; set; }

        /// <summary>
        /// 街道（英文）
        /// </summary>
        [JsonProperty("Street")]
        public string Street{ get; set; }

        /// <summary>
        /// 国家（中文）
        /// </summary>
        [JsonProperty("CountryCN")]
        public string CountryCN{ get; set; }

        /// <summary>
        /// 联系人手机号
        /// </summary>
        [JsonProperty("Telephone")]
        public string Telephone{ get; set; }

        /// <summary>
        /// 联系人邮箱
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 邮编
        /// </summary>
        [JsonProperty("ZipCode")]
        public string ZipCode{ get; set; }

        /// <summary>
        /// 用户类型 E:组织， I:个人
        /// </summary>
        [JsonProperty("RegistrantType")]
        public string RegistrantType{ get; set; }

        /// <summary>
        /// 省份（英文）。作为入参时可以不填
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// 城市（英文）。作为入参时可以不填
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// 国家（英文）。作为入参时可以不填
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrganizationNameCN", this.OrganizationNameCN);
            this.SetParamSimple(map, prefix + "OrganizationName", this.OrganizationName);
            this.SetParamSimple(map, prefix + "RegistrantNameCN", this.RegistrantNameCN);
            this.SetParamSimple(map, prefix + "RegistrantName", this.RegistrantName);
            this.SetParamSimple(map, prefix + "ProvinceCN", this.ProvinceCN);
            this.SetParamSimple(map, prefix + "CityCN", this.CityCN);
            this.SetParamSimple(map, prefix + "StreetCN", this.StreetCN);
            this.SetParamSimple(map, prefix + "Street", this.Street);
            this.SetParamSimple(map, prefix + "CountryCN", this.CountryCN);
            this.SetParamSimple(map, prefix + "Telephone", this.Telephone);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "ZipCode", this.ZipCode);
            this.SetParamSimple(map, prefix + "RegistrantType", this.RegistrantType);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Country", this.Country);
        }
    }
}

