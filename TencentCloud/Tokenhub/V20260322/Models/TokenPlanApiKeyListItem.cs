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
        /// <p>API Key ID。</p>
        /// </summary>
        [JsonProperty("ApiKeyId")]
        public string ApiKeyId{ get; set; }

        /// <summary>
        /// <p>API Key 密钥值（脱敏）。</p>
        /// </summary>
        [JsonProperty("ApiKey")]
        public string ApiKey{ get; set; }

        /// <summary>
        /// <p>API Key 名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>所属套餐 ID。</p>
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }

        /// <summary>
        /// <p>账号APP ID。</p>
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// <p>主账号 UIN。最大 128 字符。</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>API Key 可用模型列表（JSON 数组字符串）。</p>
        /// </summary>
        [JsonProperty("AllowedModels")]
        public string AllowedModels{ get; set; }

        /// <summary>
        /// <p>API Key 是否可用。取值：enable（启用）、disable（停用）。</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>API Key 停用原因。取值：NORMAL（正常，默认值），QUOTA_EXHAUSTED（API Key额度包耗尽），ABNORMAL（异常，需人工介入）</p>
        /// </summary>
        [JsonProperty("StopReason")]
        public string StopReason{ get; set; }

        /// <summary>
        /// <p>用户侧开关。取值：enable（启用）、disable（停用）。</p>
        /// </summary>
        [JsonProperty("UseStatus")]
        public string UseStatus{ get; set; }

        /// <summary>
        /// <p>密钥版本号。</p>
        /// </summary>
        [JsonProperty("KeyVersion")]
        public long? KeyVersion{ get; set; }

        /// <summary>
        /// <p>最近一次重置时间。（ISO 8601）</p>
        /// </summary>
        [JsonProperty("LastRotatedAt")]
        public string LastRotatedAt{ get; set; }

        /// <summary>
        /// <p>创建人，如果是子账号创建，则该值为子账号UIN。</p>
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>创建时间。</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>更新时间。</p>
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// <p>API Key 额度用量信息</p>
        /// </summary>
        [JsonProperty("Balance")]
        public SubPackageBalance Balance{ get; set; }

        /// <summary>
        /// <p>套餐类型。取值：enterprise（企业版专业套餐）、enterprise-auto（企业版轻享套餐）。</p>
        /// </summary>
        [JsonProperty("ProductType")]
        public string ProductType{ get; set; }

        /// <summary>
        /// <p>IP 白名单列表。支持 IPv4 单地址与 IPv4 CIDR 格式，空数组表示不限制。</p>
        /// </summary>
        [JsonProperty("IpWhitelist")]
        public string[] IpWhitelist{ get; set; }

        /// <summary>
        /// <p>是否开启超额按量计费。开启后，若 APIKey 用量达到总额度上限，并且使用的模型已开启按量计费，将自动切换至按量计费模式；未开启时用量达上限后调用报错。</p>
        /// </summary>
        [JsonProperty("OverageEnabled")]
        public bool? OverageEnabled{ get; set; }


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
            this.SetParamArraySimple(map, prefix + "IpWhitelist.", this.IpWhitelist);
            this.SetParamSimple(map, prefix + "OverageEnabled", this.OverageEnabled);
        }
    }
}

