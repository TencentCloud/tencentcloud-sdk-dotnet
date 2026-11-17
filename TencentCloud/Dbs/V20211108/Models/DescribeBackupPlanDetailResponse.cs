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

namespace TencentCloud.Dbs.V20211108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupPlanDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>地域。</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>备份计划 ID。</p>
        /// </summary>
        [JsonProperty("BackupPlanId")]
        public string BackupPlanId{ get; set; }

        /// <summary>
        /// <p>备份计划名称。</p>
        /// </summary>
        [JsonProperty("BackupPlanName")]
        public string BackupPlanName{ get; set; }

        /// <summary>
        /// <p>备份计划状态。取值：</p><ul><li>creating：创建中</li><li>notStarted：未启动</li><li>notConfigured：未配置</li><li>checkNotPass：校验未通过</li><li>checkPass：校验通过</li><li>checking：校验中</li><li>readyRun：待运行</li><li>running：运行中</li><li>fullBacking：全量备份中</li><li>paused：已暂停</li><li>isolating：隔离中</li><li>isolated：已隔离</li><li>offlining：下线中</li><li>offlined：已下线</li><li>completed：已完成</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>源库连接信息列表。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceEndPoint")]
        public Endpoint[] SourceEndPoint{ get; set; }

        /// <summary>
        /// <p>备份对象信息。</p>
        /// </summary>
        [JsonProperty("BackupObject")]
        public BackupObject BackupObject{ get; set; }

        /// <summary>
        /// <p>备份策略。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupStrategy")]
        public BackupStrategyItem BackupStrategy{ get; set; }

        /// <summary>
        /// <p>备份进度信息。</p>
        /// </summary>
        [JsonProperty("Progress")]
        public BackupProgress Progress{ get; set; }

        /// <summary>
        /// <p>错误异常信息。</p>
        /// </summary>
        [JsonProperty("ErrorInfo")]
        public ErrorInfo ErrorInfo{ get; set; }

        /// <summary>
        /// <p>创建时间。格式为 YYYY-MM-DD HH:mm:ss，如 2024-01-01 00:00:00。</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>到期时间。格式为 YYYY-MM-DD HH:mm:ss，如 2024-01-01 00:00:00，后付费计划无到期时间时为空字符串。</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>下线时间。格式为 YYYY-MM-DD HH:mm:ss，如 2024-01-01 00:00:00，尚未下线时为空字符串。</p>
        /// </summary>
        [JsonProperty("OfflineTime")]
        public string OfflineTime{ get; set; }

        /// <summary>
        /// <p>自动续费标识。取值：</p><ul><li>0：不自动续费</li><li>1：自动续费</li></ul>
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// <p>主节点连接信息。云数据库实例为实例 ID，云服务器自建为实例 ID:端口，其余为 ip:port。</p>
        /// </summary>
        [JsonProperty("SourceInfo")]
        public string[] SourceInfo{ get; set; }

        /// <summary>
        /// <p>从节点连接信息，格式同 SourceInfo。</p>
        /// </summary>
        [JsonProperty("SetSourceInfo")]
        public string[] SetSourceInfo{ get; set; }

        /// <summary>
        /// <p>标签信息列表。未绑定标签时返回 null。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>上次备份作业时间。格式为 YYYY-MM-DD HH:mm:ss，如 2024-01-01 00:00:00，尚未执行过备份作业时为空字符串。</p>
        /// </summary>
        [JsonProperty("LastBackupJobTime")]
        public string LastBackupJobTime{ get; set; }

        /// <summary>
        /// <p>上次全量备份作业状态。</p>
        /// </summary>
        [JsonProperty("LastFullBackupJobStatus")]
        public string LastFullBackupJobStatus{ get; set; }

        /// <summary>
        /// <p>上次增量备份作业状态。</p>
        /// </summary>
        [JsonProperty("LastIncBackupJobStatus")]
        public string LastIncBackupJobStatus{ get; set; }

        /// <summary>
        /// <p>下次备份作业时间。格式为 YYYY-MM-DD HH:mm:ss，如 2024-01-01 00:00:00，尚未确定时为空字符串。</p>
        /// </summary>
        [JsonProperty("NextBackupJobTime")]
        public string NextBackupJobTime{ get; set; }

        /// <summary>
        /// <p>上次恢复作业时间。格式为 YYYY-MM-DD HH:mm:ss，如 2024-01-01 00:00:00，尚未执行过恢复作业时为空字符串。</p>
        /// </summary>
        [JsonProperty("LastRestoreJobTime")]
        public string LastRestoreJobTime{ get; set; }

        /// <summary>
        /// <p>上次恢复作业状态。</p>
        /// </summary>
        [JsonProperty("LastRestoreJobStatus")]
        public string LastRestoreJobStatus{ get; set; }

        /// <summary>
        /// <p>付费信息。</p>
        /// </summary>
        [JsonProperty("PayInfo")]
        public BackupPlanPayInfo PayInfo{ get; set; }

        /// <summary>
        /// <p>全量备份并行数上限。</p>
        /// </summary>
        [JsonProperty("UpperParallel")]
        public long? UpperParallel{ get; set; }

        /// <summary>
        /// <p>带宽上限，单位：MB/s。</p>
        /// </summary>
        [JsonProperty("UpperBandwidth")]
        public long? UpperBandwidth{ get; set; }

        /// <summary>
        /// <p>当前状态下允许的操作。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AllowedActions")]
        public string[] AllowedActions{ get; set; }

        /// <summary>
        /// <p>可恢复时间范围。</p>
        /// </summary>
        [JsonProperty("RestoreRange")]
        public RestoreRange RestoreRange{ get; set; }

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
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "BackupPlanId", this.BackupPlanId);
            this.SetParamSimple(map, prefix + "BackupPlanName", this.BackupPlanName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "SourceEndPoint.", this.SourceEndPoint);
            this.SetParamObj(map, prefix + "BackupObject.", this.BackupObject);
            this.SetParamObj(map, prefix + "BackupStrategy.", this.BackupStrategy);
            this.SetParamObj(map, prefix + "Progress.", this.Progress);
            this.SetParamObj(map, prefix + "ErrorInfo.", this.ErrorInfo);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "OfflineTime", this.OfflineTime);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamArraySimple(map, prefix + "SourceInfo.", this.SourceInfo);
            this.SetParamArraySimple(map, prefix + "SetSourceInfo.", this.SetSourceInfo);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "LastBackupJobTime", this.LastBackupJobTime);
            this.SetParamSimple(map, prefix + "LastFullBackupJobStatus", this.LastFullBackupJobStatus);
            this.SetParamSimple(map, prefix + "LastIncBackupJobStatus", this.LastIncBackupJobStatus);
            this.SetParamSimple(map, prefix + "NextBackupJobTime", this.NextBackupJobTime);
            this.SetParamSimple(map, prefix + "LastRestoreJobTime", this.LastRestoreJobTime);
            this.SetParamSimple(map, prefix + "LastRestoreJobStatus", this.LastRestoreJobStatus);
            this.SetParamObj(map, prefix + "PayInfo.", this.PayInfo);
            this.SetParamSimple(map, prefix + "UpperParallel", this.UpperParallel);
            this.SetParamSimple(map, prefix + "UpperBandwidth", this.UpperBandwidth);
            this.SetParamArraySimple(map, prefix + "AllowedActions.", this.AllowedActions);
            this.SetParamObj(map, prefix + "RestoreRange.", this.RestoreRange);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

