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

    public class TokenPlanApiKeyListItem : AbstractModel
    {
        
        /// <summary>
        /// API Key ID。
        /// </summary>
        [JsonProperty("ApiKeyId")]
        public string ApiKeyId{ get; set; }

        /// <summary>
        /// API Key 密钥值（脱敏）。
        /// </summary>
        [JsonProperty("ApiKey")]
        public string ApiKey{ get; set; }

        /// <summary>
        /// API Key 名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 所属套餐 ID。
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }

        /// <summary>
        /// 账号APP ID。
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 主账号 UIN。最大 128 字符。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// API Key 可用模型列表（JSON 数组字符串）。
        /// </summary>
        [JsonProperty("AllowedModels")]
        public string AllowedModels{ get; set; }

        /// <summary>
        /// API Key 是否可用。取值：enable（启用）、disable（停用）。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// API Key 停用原因。取值：NORMAL（正常，默认值），QUOTA_EXHAUSTED（API Key额度包耗尽），ABNORMAL（异常，需人工介入）
        /// </summary>
        [JsonProperty("StopReason")]
        public string StopReason{ get; set; }

        /// <summary>
        /// 用户侧开关。取值：enable（启用）、disable（停用）。
        /// </summary>
        [JsonProperty("UseStatus")]
        public string UseStatus{ get; set; }

        /// <summary>
        /// 密钥版本号。
        /// </summary>
        [JsonProperty("KeyVersion")]
        public long? KeyVersion{ get; set; }

        /// <summary>
        /// 最近一次重置时间。（ISO 8601）
        /// </summary>
        [JsonProperty("LastRotatedAt")]
        public string LastRotatedAt{ get; set; }

        /// <summary>
        /// 创建人，如果是子账号创建，则该值为子账号UIN。
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// 更新时间。
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// API Key 额度用量信息
        /// </summary>
        [JsonProperty("Balance")]
        public SubPackageBalance Balance{ get; set; }

        /// <summary>
        /// 套餐类型。取值：enterprise（企业版专业套餐）、enterprise-auto（企业版轻享套餐）。
        /// </summary>
        [JsonProperty("ProductType")]
        public string ProductType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApiKeyId", this.ApiKeyId);
            this.SetParamSimple(map, prefix + "ApiKey", this.ApiKey);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "TeamId", this.TeamId);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "AllowedModels", this.AllowedModels);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StopReason", this.StopReason);
            this.SetParamSimple(map, prefix + "UseStatus", this.UseStatus);
            this.SetParamSimple(map, prefix + "KeyVersion", this.KeyVersion);
            this.SetParamSimple(map, prefix + "LastRotatedAt", this.LastRotatedAt);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamObj(map, prefix + "Balance.", this.Balance);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
        }
    }
}

