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

    public class CreateBPBrandRequest : AbstractModel
    {
        
        /// <summary>
        /// 品牌名称
        /// </summary>
        [JsonProperty("BrandName")]
        public string BrandName{ get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }

        /// <summary>
        /// 品牌logo
        /// </summary>
        [JsonProperty("BrandLogo")]
        public string BrandLogo{ get; set; }

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
        /// 授权书
        /// </summary>
        [JsonProperty("Authorization")]
        public string Authorization{ get; set; }

        /// <summary>
        /// 商标名称
        /// </summary>
        [JsonProperty("TrademarkNames")]
        public string[] TrademarkNames{ get; set; }

        /// <summary>
        /// 商标证明
        /// </summary>
        [JsonProperty("Trademarks")]
        public string[] Trademarks{ get; set; }

        /// <summary>
        /// 是否涉及转让: 0-不转让 1-转让
        /// </summary>
        [JsonProperty("IsTransfers")]
        public string[] IsTransfers{ get; set; }

        /// <summary>
        /// 转让证明
        /// </summary>
        [JsonProperty("Transfers")]
        public string[] Transfers{ get; set; }

        /// <summary>
        /// 保护网址
        /// </summary>
        [JsonProperty("ProtectURLs")]
        public string[] ProtectURLs{ get; set; }

        /// <summary>
        /// 保护应用
        /// </summary>
        [JsonProperty("ProtectAPPs")]
        public string[] ProtectAPPs{ get; set; }

        /// <summary>
        /// 保护公众号
        /// </summary>
        [JsonProperty("ProtectOfficialAccounts")]
        public string[] ProtectOfficialAccounts{ get; set; }

        /// <summary>
        /// 保护小程序
        /// </summary>
        [JsonProperty("ProtectMiniPrograms")]
        public string[] ProtectMiniPrograms{ get; set; }

        /// <summary>
        /// 请求来源：0-反钓鱼 2-反假冒
        /// </summary>
        [JsonProperty("APISource")]
        public long? APISource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BrandName", this.BrandName);
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
            this.SetParamSimple(map, prefix + "BrandLogo", this.BrandLogo);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "License", this.License);
            this.SetParamSimple(map, prefix + "Authorization", this.Authorization);
            this.SetParamArraySimple(map, prefix + "TrademarkNames.", this.TrademarkNames);
            this.SetParamArraySimple(map, prefix + "Trademarks.", this.Trademarks);
            this.SetParamArraySimple(map, prefix + "IsTransfers.", this.IsTransfers);
            this.SetParamArraySimple(map, prefix + "Transfers.", this.Transfers);
            this.SetParamArraySimple(map, prefix + "ProtectURLs.", this.ProtectURLs);
            this.SetParamArraySimple(map, prefix + "ProtectAPPs.", this.ProtectAPPs);
            this.SetParamArraySimple(map, prefix + "ProtectOfficialAccounts.", this.ProtectOfficialAccounts);
            this.SetParamArraySimple(map, prefix + "ProtectMiniPrograms.", this.ProtectMiniPrograms);
            this.SetParamSimple(map, prefix + "APISource", this.APISource);
        }
    }
}

