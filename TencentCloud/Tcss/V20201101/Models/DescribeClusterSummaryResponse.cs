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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeClusterSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 集群总数
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

        /// <summary>
        /// 有风险的集群数量
        /// </summary>
        [JsonProperty("RiskClusterCount")]
        public ulong? RiskClusterCount{ get; set; }

        /// <summary>
        /// 未检查的集群数量
        /// </summary>
        [JsonProperty("UncheckClusterCount")]
        public ulong? UncheckClusterCount{ get; set; }

        /// <summary>
        /// 托管集群数量
        /// </summary>
        [JsonProperty("ManagedClusterCount")]
        public ulong? ManagedClusterCount{ get; set; }

        /// <summary>
        /// 独立集群数量
        /// </summary>
        [JsonProperty("IndependentClusterCount")]
        public ulong? IndependentClusterCount{ get; set; }

        /// <summary>
        /// 无风险的集群数量
        /// </summary>
        [JsonProperty("NoRiskClusterCount")]
        public ulong? NoRiskClusterCount{ get; set; }

        /// <summary>
        /// 已经检查集群数
        /// </summary>
        [JsonProperty("CheckedClusterCount")]
        public ulong? CheckedClusterCount{ get; set; }

        /// <summary>
        /// 自动检查集群数
        /// </summary>
        [JsonProperty("AutoCheckClusterCount")]
        public ulong? AutoCheckClusterCount{ get; set; }

        /// <summary>
        /// 手动检查集群数
        /// </summary>
        [JsonProperty("ManualCheckClusterCount")]
        public ulong? ManualCheckClusterCount{ get; set; }

        /// <summary>
        /// 检查失败集群数
        /// </summary>
        [JsonProperty("FailedClusterCount")]
        public ulong? FailedClusterCount{ get; set; }

        /// <summary>
        /// 未导入的集群数量
        /// </summary>
        [JsonProperty("NotImportedClusterCount")]
        public ulong? NotImportedClusterCount{ get; set; }

        /// <summary>
        /// eks集群数量
        /// </summary>
        [JsonProperty("ServerlessClusterCount")]
        public ulong? ServerlessClusterCount{ get; set; }

        /// <summary>
        /// TKE集群数量
        /// </summary>
        [JsonProperty("TkeClusterCount")]
        public ulong? TkeClusterCount{ get; set; }

        /// <summary>
        /// 用户自建腾讯云集群数量
        /// </summary>
        [JsonProperty("UserCreateTencentClusterCount")]
        public ulong? UserCreateTencentClusterCount{ get; set; }

        /// <summary>
        /// 用户自建集群混合云数量
        /// </summary>
        [JsonProperty("UserCreateHybridClusterCount")]
        public ulong? UserCreateHybridClusterCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "RiskClusterCount", this.RiskClusterCount);
            this.SetParamSimple(map, prefix + "UncheckClusterCount", this.UncheckClusterCount);
            this.SetParamSimple(map, prefix + "ManagedClusterCount", this.ManagedClusterCount);
            this.SetParamSimple(map, prefix + "IndependentClusterCount", this.IndependentClusterCount);
            this.SetParamSimple(map, prefix + "NoRiskClusterCount", this.NoRiskClusterCount);
            this.SetParamSimple(map, prefix + "CheckedClusterCount", this.CheckedClusterCount);
            this.SetParamSimple(map, prefix + "AutoCheckClusterCount", this.AutoCheckClusterCount);
            this.SetParamSimple(map, prefix + "ManualCheckClusterCount", this.ManualCheckClusterCount);
            this.SetParamSimple(map, prefix + "FailedClusterCount", this.FailedClusterCount);
            this.SetParamSimple(map, prefix + "NotImportedClusterCount", this.NotImportedClusterCount);
            this.SetParamSimple(map, prefix + "ServerlessClusterCount", this.ServerlessClusterCount);
            this.SetParamSimple(map, prefix + "TkeClusterCount", this.TkeClusterCount);
            this.SetParamSimple(map, prefix + "UserCreateTencentClusterCount", this.UserCreateTencentClusterCount);
            this.SetParamSimple(map, prefix + "UserCreateHybridClusterCount", this.UserCreateHybridClusterCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

