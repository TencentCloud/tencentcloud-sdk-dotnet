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
        /// 套餐 ID。可通过DescribeTokenPlanList接口获取。
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }

        /// <summary>
        /// API Key 名称，最大 128 字符。如果创建 API Key 的数量超过1个，实际名称格式为 {ApiKeyName}-{序号}（如 mykey-1, mykey-2）。
        /// </summary>
        [JsonProperty("ApiKeyName")]
        public string ApiKeyName{ get; set; }

        /// <summary>
        /// 创建数量。取值范围：1 ~ 10。
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 可用模型列表。如果套餐类型为企业版专业套餐，可以指定模型，也可以传入“all”，传入 “all“表示可以使用套餐支持的所有模型，如果要指定具体模型，传入 Model ID，“all“和具体的 Model ID 不能同时传入，如果不传则表示该API Key不支持任何模型，从而影响API Key的正常使用。如果套餐类型为企业版轻享套餐，则无论是否传入该字段，以及该字段传入什么值，都会被强制覆盖为["auto"]。
        /// </summary>
        [JsonProperty("AllowedModels")]
        public string[] AllowedModels{ get; set; }

        /// <summary>
        /// 独占额度。不传则为0，代表该 API Key 不被分配任何独占配额。单位说明如下：
        /// - 套餐类型为专业，单位取值为积分；
        /// - 套餐类型为轻享套餐，单位取值为 token。
        /// </summary>
        [JsonProperty("ExclusiveQuota")]
        public long? ExclusiveQuota{ get; set; }

        /// <summary>
        /// 总额度上限。-1 表示不限，必须为 -1 或 >= API Key 当前的 ExclusiveQuota（独占额度）。不传表示不设置上限。单位说明如下：
        /// - 套餐类型为专业，单位取值为积分；
        /// - 套餐类型为轻享套餐，单位取值为 token。
        /// </summary>
        [JsonProperty("TotalQuota")]
        public long? TotalQuota{ get; set; }

        /// <summary>
        /// TPM（Tokens Per Minute）限制。不传使用套餐级别 TPM。必须 >= 0 且 <= 套餐 TPM。
        /// </summary>
        [JsonProperty("TPM")]
        public long? TPM{ get; set; }


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
        }
    }
}

