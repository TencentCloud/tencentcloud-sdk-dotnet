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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CompanyInfo : AbstractModel
    {
        
        /// <summary>
        /// 公司名称
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }

        /// <summary>
        /// 公司ID
        /// </summary>
        [JsonProperty("CompanyId")]
        public long? CompanyId{ get; set; }

        /// <summary>
        /// 公司所在国家
        /// </summary>
        [JsonProperty("CompanyCountry")]
        public string CompanyCountry{ get; set; }

        /// <summary>
        /// 公司所在省份
        /// </summary>
        [JsonProperty("CompanyProvince")]
        public string CompanyProvince{ get; set; }

        /// <summary>
        /// 公司所在城市
        /// </summary>
        [JsonProperty("CompanyCity")]
        public string CompanyCity{ get; set; }

        /// <summary>
        /// 公司所在详细地址
        /// </summary>
        [JsonProperty("CompanyAddress")]
        public string CompanyAddress{ get; set; }

        /// <summary>
        /// 公司电话
        /// </summary>
        [JsonProperty("CompanyPhone")]
        public string CompanyPhone{ get; set; }

        /// <summary>
        /// 公司证件类型，取值范围：
        /// TYDMZ（统一社会信用代码 ）：仅CFCA类型证书需要使用本字段， 其他类型证书不需要使用本字段
        /// OTHERS（其他）
        /// </summary>
        [JsonProperty("IdType")]
        public string IdType{ get; set; }

        /// <summary>
        /// 公司证件号码，取值范围：
        /// TYDMZ（统一社会信用代码 ）：11532xxxxxxxx24820
        /// </summary>
        [JsonProperty("IdNumber")]
        public string IdNumber{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "CompanyCountry", this.CompanyCountry);
            this.SetParamSimple(map, prefix + "CompanyProvince", this.CompanyProvince);
            this.SetParamSimple(map, prefix + "CompanyCity", this.CompanyCity);
            this.SetParamSimple(map, prefix + "CompanyAddress", this.CompanyAddress);
            this.SetParamSimple(map, prefix + "CompanyPhone", this.CompanyPhone);
            this.SetParamSimple(map, prefix + "IdType", this.IdType);
            this.SetParamSimple(map, prefix + "IdNumber", this.IdNumber);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

