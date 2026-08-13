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

    public class DescribeEDRScanTaskDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>任务ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// <p>任务名称</p>
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>整体状态：WAIT/SCANNING/FINISHED/FAILED/CANCELED/TERMINATED/TIMEOUT</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>任务类型：HOST/CONTAINER</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>触发方式：MANUAL/CYCLE</p>
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// <p>任务开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>任务结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>检测模式：full/quick/include/exclude</p>
        /// </summary>
        [JsonProperty("ScanType")]
        public string ScanType{ get; set; }

        /// <summary>
        /// <p>自选路径列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomPaths")]
        public string[] CustomPaths{ get; set; }

        /// <summary>
        /// <p>超时时间（秒）</p>
        /// </summary>
        [JsonProperty("Timeout")]
        public long? Timeout{ get; set; }

        /// <summary>
        /// <p>是否开启深度检测：0-否/1-是</p>
        /// </summary>
        [JsonProperty("EnableMemShellScan")]
        public long? EnableMemShellScan{ get; set; }

        /// <summary>
        /// <p>创建者账号AppId</p>
        /// </summary>
        [JsonProperty("CreateAppID")]
        public ulong? CreateAppID{ get; set; }

        /// <summary>
        /// <p>任务创建者账号名称（后端富化）</p>
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// <p>创建者云类型</p>
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }

        /// <summary>
        /// <p>任务总资产数</p>
        /// </summary>
        [JsonProperty("TotalAssetCount")]
        public long? TotalAssetCount{ get; set; }

        /// <summary>
        /// <p>已完成资产数</p>
        /// </summary>
        [JsonProperty("FinishedAssetCount")]
        public long? FinishedAssetCount{ get; set; }

        /// <summary>
        /// <p>风险资产数</p>
        /// </summary>
        [JsonProperty("RiskAssetCount")]
        public long? RiskAssetCount{ get; set; }

        /// <summary>
        /// <p>主机资产列表（TaskType=HOST时有值）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostList")]
        public EDRScanTaskHostItem[] HostList{ get; set; }

        /// <summary>
        /// <p>容器资产列表（TaskType=CONTAINER时有值）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContainerList")]
        public EDRScanTaskContainerItem[] ContainerList{ get; set; }

        /// <summary>
        /// <p>当前筛选条件下资产列表总条数</p>
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "ScanType", this.ScanType);
            this.SetParamArraySimple(map, prefix + "CustomPaths.", this.CustomPaths);
            this.SetParamSimple(map, prefix + "Timeout", this.Timeout);
            this.SetParamSimple(map, prefix + "EnableMemShellScan", this.EnableMemShellScan);
            this.SetParamSimple(map, prefix + "CreateAppID", this.CreateAppID);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamSimple(map, prefix + "TotalAssetCount", this.TotalAssetCount);
            this.SetParamSimple(map, prefix + "FinishedAssetCount", this.FinishedAssetCount);
            this.SetParamSimple(map, prefix + "RiskAssetCount", this.RiskAssetCount);
            this.SetParamArrayObj(map, prefix + "HostList.", this.HostList);
            this.SetParamArrayObj(map, prefix + "ContainerList.", this.ContainerList);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

