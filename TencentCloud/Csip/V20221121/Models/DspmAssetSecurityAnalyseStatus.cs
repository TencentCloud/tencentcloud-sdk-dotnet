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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspmAssetSecurityAnalyseStatus : AbstractModel
    {
        
        /// <summary>
        /// 资产所属账号app id
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 资产实例Id
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 是否支持敏感数据识别。0 不支持；1 支持
        /// </summary>
        [JsonProperty("IdentifyScanSupported")]
        public long? IdentifyScanSupported{ get; set; }

        /// <summary>
        /// 是否支持日志投递。0-不支持 1-支持
        /// </summary>
        [JsonProperty("LogDeliverySupported")]
        public long? LogDeliverySupported{ get; set; }

        /// <summary>
        /// 安全分析状态（0-关闭 1-打开 2-开通中 3-关闭中）
        /// </summary>
        [JsonProperty("SecurityAnalyseStatus")]
        public long? SecurityAnalyseStatus{ get; set; }

        /// <summary>
        /// 日志投递状态。
        /// 0-投递关闭 1-投递打开 2-投递开通中 3-投递关闭中
        /// </summary>
        [JsonProperty("LogDeliveryStatus")]
        public long? LogDeliveryStatus{ get; set; }

        /// <summary>
        /// 日志审计禁止开通的原因，可选值：VersionNotSupportLogSubscription, InstanceIsUpgrading,CdbRuleAuditEnabled
        /// </summary>
        [JsonProperty("LogDeliveryDisableReason")]
        public string LogDeliveryDisableReason{ get; set; }

        /// <summary>
        /// 当前实例的总日志数
        /// </summary>
        [JsonProperty("TotalAuditLogs")]
        public ulong? TotalAuditLogs{ get; set; }

        /// <summary>
        /// 已识别敏感数据项个数
        /// </summary>
        [JsonProperty("DataScanDetailRuleCount")]
        public ulong? DataScanDetailRuleCount{ get; set; }

        /// <summary>
        /// 操作错误信息
        /// </summary>
        [JsonProperty("OperationErrorMsg")]
        public string OperationErrorMsg{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "IdentifyScanSupported", this.IdentifyScanSupported);
            this.SetParamSimple(map, prefix + "LogDeliverySupported", this.LogDeliverySupported);
            this.SetParamSimple(map, prefix + "SecurityAnalyseStatus", this.SecurityAnalyseStatus);
            this.SetParamSimple(map, prefix + "LogDeliveryStatus", this.LogDeliveryStatus);
            this.SetParamSimple(map, prefix + "LogDeliveryDisableReason", this.LogDeliveryDisableReason);
            this.SetParamSimple(map, prefix + "TotalAuditLogs", this.TotalAuditLogs);
            this.SetParamSimple(map, prefix + "DataScanDetailRuleCount", this.DataScanDetailRuleCount);
            this.SetParamSimple(map, prefix + "OperationErrorMsg", this.OperationErrorMsg);
        }
    }
}

