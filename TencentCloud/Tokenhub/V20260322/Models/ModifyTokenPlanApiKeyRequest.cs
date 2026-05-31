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
        /// API Key ID。
        /// </summary>
        [JsonProperty("ApiKeyId")]
        public string ApiKeyId{ get; set; }

        /// <summary>
        /// 可用模型列表。不传则不修改。
        /// 
        /// - 如果套餐类型为企业版专业套餐：
        /// 1）传入“all“ ：使用套餐支持的所有模型
        /// 2）传入 Model ID：指定具体模型。“all“和具体的 Model ID 不能同时传入。
        /// 
        /// - 如果套餐类型为企业版轻享套餐，不允许传该参数。
        /// </summary>
        [JsonProperty("AllowedModels")]
        public string[] AllowedModels{ get; set; }

        /// <summary>
        /// 独占额度，不传则不修改。单位说明：
        /// 
        /// - 套餐类型为专业套餐，单位取值为积分；
        /// - 套餐类型为轻享套餐，单位取值为 token。
        /// </summary>
        [JsonProperty("ExclusiveQuota")]
        public long? ExclusiveQuota{ get; set; }

        /// <summary>
        /// 总额度上限。-1 表示不限，必须为 -1 或 >= API Key 当前的 ExclusiveQuota（独占额度），不传则不修改。单位说明如下：
        /// - 套餐类型为专业套餐，单位取值为积分；
        /// - 套餐类型为轻享套餐，单位取值为 token。
        /// </summary>
        [JsonProperty("TotalQuota")]
        public long? TotalQuota{ get; set; }

        /// <summary>
        /// 是否启用该 API Key。取值：enable（启用）、disable（停用），不传则不修改。
        /// </summary>
        [JsonProperty("UseStatus")]
        public string UseStatus{ get; set; }

        /// <summary>
        /// TPM（Tokens Per Minute）限制。不传则不修改。必须 >= 0 且 <= 套餐 TPM。
        /// </summary>
        [JsonProperty("TPM")]
        public long? TPM{ get; set; }


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
        }
    }
}

