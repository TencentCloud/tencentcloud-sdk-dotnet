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

namespace TencentCloud.Bma.V20221115.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BrandData : AbstractModel
    {
        
        /// <summary>
        /// 品牌Id
        /// </summary>
        [JsonProperty("CompanyId")]
        public long? CompanyId{ get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }

        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonProperty("BrandName")]
        public string BrandName{ get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 营业执照
        /// </summary>
        [JsonProperty("License")]
        public string License{ get; set; }

        /// <summary>
        /// 营业执照审核状态
        /// </summary>
        [JsonProperty("LicenseStatus")]
        public long? LicenseStatus{ get; set; }

        /// <summary>
        /// 营业执照审核状态说明
        /// </summary>
        [JsonProperty("LicenseNote")]
        public string LicenseNote{ get; set; }

        /// <summary>
        /// 授权书
        /// </summary>
        [JsonProperty("Authorization")]
        public string Authorization{ get; set; }

        /// <summary>
        /// 授权书审核状态
        /// </summary>
        [JsonProperty("AuthorizationStatus")]
        public long? AuthorizationStatus{ get; set; }

        /// <summary>
        /// 授权书审核状态说明
        /// </summary>
        [JsonProperty("AuthorizationNote")]
        public string AuthorizationNote{ get; set; }

        /// <summary>
        /// 商标信息
        /// </summary>
        [JsonProperty("Trademarks")]
        public TrademarkData[] Trademarks{ get; set; }

        /// <summary>
        /// 新增时间
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// 服务信息
        /// </summary>
        [JsonProperty("Services")]
        public ServiceData Services{ get; set; }

        /// <summary>
        /// 账号id
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
            this.SetParamSimple(map, prefix + "BrandName", this.BrandName);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "License", this.License);
            this.SetParamSimple(map, prefix + "LicenseStatus", this.LicenseStatus);
            this.SetParamSimple(map, prefix + "LicenseNote", this.LicenseNote);
            this.SetParamSimple(map, prefix + "Authorization", this.Authorization);
            this.SetParamSimple(map, prefix + "AuthorizationStatus", this.AuthorizationStatus);
            this.SetParamSimple(map, prefix + "AuthorizationNote", this.AuthorizationNote);
            this.SetParamArrayObj(map, prefix + "Trademarks.", this.Trademarks);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamObj(map, prefix + "Services.", this.Services);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
        }
    }
}

