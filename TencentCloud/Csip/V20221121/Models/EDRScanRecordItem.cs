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

    public class EDRScanRecordItem : AbstractModel
    {
        
        /// <summary>
        /// <p>任务主键 ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// <p>任务名称，如 Malware_20260702_030000</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// <p>扫描类型</p><p>枚举值：</p><ul><li>MANNAL： 手动扫描</li><li>CYCLE： 定时扫描</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TriggerType")]
        public string TriggerType{ get; set; }

        /// <summary>
        /// <p>定时调度描述（ScanType=1 时有值），如“每天 03:00:00”</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScheduleDesc")]
        public string ScheduleDesc{ get; set; }

        /// <summary>
        /// <p>任务资产类型：0=主机扫描，1=容器扫描</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>扫描目标涉及的账号AppId列表</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TargetAppIDs")]
        public ulong?[] TargetAppIDs{ get; set; }

        /// <summary>
        /// <p>任务创建者账号名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountName")]
        public string AccountName{ get; set; }

        /// <summary>
        /// <p>云类型：0=腾讯云，1=AWS，2=Azure，4=阿里云</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }

        /// <summary>
        /// <p>资产选择方式：all=全部资产，tag=按标签选择，direct=直接选择</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetSelectionType")]
        public string AssetSelectionType{ get; set; }

        /// <summary>
        /// <p>扫描资产总数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalAssetCount")]
        public long? TotalAssetCount{ get; set; }

        /// <summary>
        /// <p>创建者账号AppId（前端据此判断操作权限）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateAppID")]
        public ulong? CreateAppID{ get; set; }

        /// <summary>
        /// <p>创建者账号uin</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>创建者账号名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatorName")]
        public string CreatorName{ get; set; }

        /// <summary>
        /// <p>创建者云类型：0=腾讯云, 1=AWS, 2=Azure, 4=阿里云</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatorCloudType")]
        public long? CreatorCloudType{ get; set; }

        /// <summary>
        /// <p>任务开始时间，格式 2006-01-02 15:04:05</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>任务结束时间，未结束为空字符串</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>WAIT：待扫描，SCANNING：扫描中，FINISHED：已完成，FAILED：失败，CANCELED：已停止</p><p>枚举值：</p><ul><li>WAIT： 待扫描</li><li>SCANNING： 扫描中</li><li>FINISHED： 已完成</li><li>FAILED： 失败</li><li>CANCELED： 已停止</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TriggerType", this.TriggerType);
            this.SetParamSimple(map, prefix + "ScheduleDesc", this.ScheduleDesc);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamArraySimple(map, prefix + "TargetAppIDs.", this.TargetAppIDs);
            this.SetParamSimple(map, prefix + "AccountName", this.AccountName);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamSimple(map, prefix + "AssetSelectionType", this.AssetSelectionType);
            this.SetParamSimple(map, prefix + "TotalAssetCount", this.TotalAssetCount);
            this.SetParamSimple(map, prefix + "CreateAppID", this.CreateAppID);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreatorName", this.CreatorName);
            this.SetParamSimple(map, prefix + "CreatorCloudType", this.CreatorCloudType);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

