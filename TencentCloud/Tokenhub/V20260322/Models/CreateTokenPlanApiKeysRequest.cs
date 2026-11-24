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

namespace TencentCloud.Tokenhub.V20260322.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTokenPlanApiKeysRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>套餐 ID。可通过DescribeTokenPlanList接口获取。</p>
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }

        /// <summary>
        /// <p>API Key 名称，最大 128 字符。如果创建 API Key 的数量超过1个，实际名称格式为 {ApiKeyName}-{序号}（如 mykey-1, mykey-2）。</p>
        /// </summary>
        [JsonProperty("ApiKeyName")]
        public string ApiKeyName{ get; set; }

        /// <summary>
        /// <p>创建数量。取值范围：1 ~ 10。</p>
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// <p>可用模型列表。如果套餐类型为企业版专业套餐，该字段必传！可以指定模型，也可以传入“all”，传入 “all“表示可以使用套餐支持的所有模型，如果要指定具体模型，传入 Model ID，“all“和具体的 Model ID 不能同时传入。如果套餐类型为企业版轻享套餐，则无论是否传入该字段，以及该字段传入什么值，都会被强制覆盖为[&quot;auto&quot;]。</p>
        /// </summary>
        [JsonProperty("AllowedModels")]
        public string[] AllowedModels{ get; set; }

        /// <summary>
        /// <p>独占额度。不传则为0，代表该 API Key 不被分配任何独占配额。单位说明如下：</p><ul><li>套餐类型为专业，单位取值为积分；</li><li>套餐类型为轻享套餐，单位取值为 token。</li></ul>
        /// </summary>
        [JsonProperty("ExclusiveQuota")]
        public long? ExclusiveQuota{ get; set; }

        /// <summary>
        /// <p>总额度上限。-1 表示不限，必须为 -1 或 &gt;= API Key 当前的 ExclusiveQuota（独占额度）。不传表示不设置上限。单位说明如下：</p><ul><li>套餐类型为专业，单位取值为积分；</li><li>套餐类型为轻享套餐，单位取值为 token。</li></ul>
        /// </summary>
        [JsonProperty("TotalQuota")]
        public long? TotalQuota{ get; set; }

        /// <summary>
        /// <p>TPM（Tokens Per Minute）限制。不传使用套餐级别 TPM。必须 &gt;= 0 且 &lt;= 套餐 TPM。</p>
        /// </summary>
        [JsonProperty("TPM")]
        public long? TPM{ get; set; }

        /// <summary>
        /// <p>IP 白名单列表。支持 IPv4 单地址（如 1.2.3.4）和 IPv4 CIDR（如 10.0.0.0/24）格式。最多 50 个条目，不允许重复；不支持 IPv6 与 IP 范围。不传或传空数组表示不限制。批量创建时所有 APIKey 共用同一份白名单。</p>
        /// </summary>
        [JsonProperty("IpWhitelist")]
        public string[] IpWhitelist{ get; set; }

        /// <summary>
        /// <p>是否开启超额按量计费。默认值为 false。开启后，若 APIKey 用量达到总额度上限，并且使用的模型已开启按量计费，将自动切换至按量计费模式，该部分将按所用模型的按量计费定价额外计费；未开启时用量达上限后调用报错。</p>
        /// </summary>
        [JsonProperty("OverageEnabled")]
        public bool? OverageEnabled{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TeamId", this.TeamId);
            this.SetParamSimple(map, prefix + "ApiKeyName", this.ApiKeyName);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamArraySimple(map, prefix + "AllowedModels.", this.AllowedModels);
            this.SetParamSimple(map, prefix + "ExclusiveQuota", this.ExclusiveQuota);
            this.SetParamSimple(map, prefix + "TotalQuota", this.TotalQuota);
            this.SetParamSimple(map, prefix + "TPM", this.TPM);
            this.SetParamArraySimple(map, prefix + "IpWhitelist.", this.IpWhitelist);
            this.SetParamSimple(map, prefix + "OverageEnabled", this.OverageEnabled);
        }
    }
}

