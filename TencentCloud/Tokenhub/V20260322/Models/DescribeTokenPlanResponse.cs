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

    public class DescribeTokenPlanResponse : AbstractModel
    {
        
        /// <summary>
        /// 套餐 ID。
        /// </summary>
        [JsonProperty("TeamId")]
        public string TeamId{ get; set; }

        /// <summary>
        /// 套餐名称。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 主账号 APP ID。
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 主账号 UIN。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 状态。取值：enable（启用）、disable（停用）。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 关停原因。取值：取值：NORMAL（套餐正常）、ISOLATED（隔离/欠费）、FROZEN（冻结）、EXHAUSTED（额度耗尽）、DESTROYED（已销毁）。
        /// </summary>
        [JsonProperty("StopReason")]
        public string StopReason{ get; set; }

        /// <summary>
        /// 可创建APIKey 上限。
        /// </summary>
        [JsonProperty("ApiKeyMax")]
        public long? ApiKeyMax{ get; set; }

        /// <summary>
        /// 云计费预付费资源包 ID。
        /// </summary>
        [JsonProperty("PrepayResourceID")]
        public string PrepayResourceID{ get; set; }

        /// <summary>
        /// 创建人，子账号创建的套餐将展示子账号UIN。
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
        /// 套餐包基本信息
        /// </summary>
        [JsonProperty("PackageInfo")]
        public TokenPlanPackageInfo PackageInfo{ get; set; }

        /// <summary>
        /// 自动续费标识。取值：0（手动续费）、1（自动续费）、2（明确不自动续费）。未绑定预付费资源时不返回。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 当前已创建的 API Key 数量
        /// </summary>
        [JsonProperty("ApiKeyCount")]
        public long? ApiKeyCount{ get; set; }

        /// <summary>
        /// 当前周期 Token 用量明细
        /// </summary>
        [JsonProperty("TokenSummary")]
        public TokenSummary TokenSummary{ get; set; }

        /// <summary>
        /// 套餐类型。取值：enterprise（企业版专业套餐）、enterprise-auto（企业版轻享套餐）
        /// </summary>
        [JsonProperty("ProductType")]
        public string ProductType{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TeamId", this.TeamId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StopReason", this.StopReason);
            this.SetParamSimple(map, prefix + "ApiKeyMax", this.ApiKeyMax);
            this.SetParamSimple(map, prefix + "PrepayResourceID", this.PrepayResourceID);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamObj(map, prefix + "PackageInfo.", this.PackageInfo);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamSimple(map, prefix + "ApiKeyCount", this.ApiKeyCount);
            this.SetParamObj(map, prefix + "TokenSummary.", this.TokenSummary);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

