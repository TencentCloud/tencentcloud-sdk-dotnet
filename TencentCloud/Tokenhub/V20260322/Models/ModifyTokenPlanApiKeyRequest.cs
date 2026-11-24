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

    public class ModifyTokenPlanApiKeyRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>API Key ID。</p>
        /// </summary>
        [JsonProperty("ApiKeyId")]
        public string ApiKeyId{ get; set; }

        /// <summary>
        /// <p>可用模型列表。不传则不修改。</p><ul><li><p>如果套餐类型为企业版专业套餐：<br>1）传入“all“ ：使用套餐支持的所有模型<br>2）传入 Model ID：指定具体模型。“all“和具体的 Model ID 不能同时传入。</p></li><li><p>如果套餐类型为企业版轻享套餐，不允许传该参数。</p></li></ul>
        /// </summary>
        [JsonProperty("AllowedModels")]
        public string[] AllowedModels{ get; set; }

        /// <summary>
        /// <p>独占额度，不传则不修改。单位说明：</p><ul><li>套餐类型为专业套餐，单位取值为积分；</li><li>套餐类型为轻享套餐，单位取值为 token。</li></ul>
        /// </summary>
        [JsonProperty("ExclusiveQuota")]
        public long? ExclusiveQuota{ get; set; }

        /// <summary>
        /// <p>总额度上限。-1 表示不限，必须为 -1 或 &gt;= API Key 当前的 ExclusiveQuota（独占额度），不传则不修改。单位说明如下：</p><ul><li>套餐类型为专业套餐，单位取值为积分；</li><li>套餐类型为轻享套餐，单位取值为 token。</li></ul>
        /// </summary>
        [JsonProperty("TotalQuota")]
        public long? TotalQuota{ get; set; }

        /// <summary>
        /// <p>是否启用该 API Key。取值：enable（启用）、disable（停用），不传则不修改。</p>
        /// </summary>
        [JsonProperty("UseStatus")]
        public string UseStatus{ get; set; }

        /// <summary>
        /// <p>TPM（Tokens Per Minute）限制。不传则不修改。必须 &gt;= 0 且 &lt;= 套餐 TPM。</p>
        /// </summary>
        [JsonProperty("TPM")]
        public long? TPM{ get; set; }

        /// <summary>
        /// <p>IP 白名单列表。不传则不修改；传空数组表示清空（不限制 IP）；传非空数组表示覆盖。支持 IPv4 单地址（如 1.2.3.4）和 IPv4 CIDR（如 10.0.0.0/24）格式，最多 50 个条目，不允许重复；不支持 IPv6 与 IP 范围。</p>
        /// </summary>
        [JsonProperty("IpWhitelist")]
        public string[] IpWhitelist{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApiKeyId", this.ApiKeyId);
            this.SetParamArraySimple(map, prefix + "AllowedModels.", this.AllowedModels);
            this.SetParamSimple(map, prefix + "ExclusiveQuota", this.ExclusiveQuota);
            this.SetParamSimple(map, prefix + "TotalQuota", this.TotalQuota);
            this.SetParamSimple(map, prefix + "UseStatus", this.UseStatus);
            this.SetParamSimple(map, prefix + "TPM", this.TPM);
            this.SetParamArraySimple(map, prefix + "IpWhitelist.", this.IpWhitelist);
        }
    }
}

