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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BackupInfo : AbstractModel
    {
        
        /// <summary>
        /// 备份点ID
        /// </summary>
        [JsonProperty("BackupId")]
        public string BackupId{ get; set; }

        /// <summary>
        /// 备份名称
        /// </summary>
        [JsonProperty("BackupName")]
        public string BackupName{ get; set; }

        /// <summary>
        /// 所属计划ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// 策略ID
        /// </summary>
        [JsonProperty("AspInstanceId")]
        public string AspInstanceId{ get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 备份状态，取值如下：
        /// 0 备份完成
        /// 1 创建中（备份进行中）
        /// 2 部分成功（指定的备份路径中部分目录不存在）
        /// 3 恢复中（该备份点正在被恢复任务使用）
        /// 92  已取消
        /// 98 创建失败
        /// 99 已删除
        /// 100 删除中
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 备份路径
        /// </summary>
        [JsonProperty("BackupPaths")]
        public string[] BackupPaths{ get; set; }

        /// <summary>
        /// 包含文件类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncludeFileTypes")]
        public string[] IncludeFileTypes{ get; set; }

        /// <summary>
        /// 排除路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExcludePatterns")]
        public string[] ExcludePatterns{ get; set; }

        /// <summary>
        /// 是否排除系统目录
        /// </summary>
        [JsonProperty("ExcludeSystemDirectories")]
        public bool? ExcludeSystemDirectories{ get; set; }

        /// <summary>
        /// 备份库ID
        /// </summary>
        [JsonProperty("VaultId")]
        public string VaultId{ get; set; }

        /// <summary>
        /// 扫描文件数
        /// </summary>
        [JsonProperty("ScannedFileCount")]
        public long? ScannedFileCount{ get; set; }

        /// <summary>
        /// 扫描大小(字节)
        /// </summary>
        [JsonProperty("ScannedSize")]
        public long? ScannedSize{ get; set; }

        /// <summary>
        /// 扫描大小(格式化)
        /// </summary>
        [JsonProperty("ScannedSizeFormatted")]
        public string ScannedSizeFormatted{ get; set; }

        /// <summary>
        /// 已备份文件数量
        /// </summary>
        [JsonProperty("BackupFileCount")]
        public long? BackupFileCount{ get; set; }

        /// <summary>
        /// 已备份大小(字节)
        /// </summary>
        [JsonProperty("BackupSize")]
        public long? BackupSize{ get; set; }

        /// <summary>
        /// 已备份大小(格式化)
        /// </summary>
        [JsonProperty("BackupSizeFormatted")]
        public string BackupSizeFormatted{ get; set; }

        /// <summary>
        /// 备份进度(0-100)
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 是否为永久保留
        /// </summary>
        [JsonProperty("IsPermanent")]
        public bool? IsPermanent{ get; set; }

        /// <summary>
        /// 到期时间
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }

        /// <summary>
        /// 不存在的路径信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NonExistSourcePaths")]
        public string[] NonExistSourcePaths{ get; set; }

        /// <summary>
        /// 备份失败原因
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// 备份所属AppId
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 备份类型
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BackupId", this.BackupId);
            this.SetParamSimple(map, prefix + "BackupName", this.BackupName);
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "AspInstanceId", this.AspInstanceId);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "BackupPaths.", this.BackupPaths);
            this.SetParamArraySimple(map, prefix + "IncludeFileTypes.", this.IncludeFileTypes);
            this.SetParamArraySimple(map, prefix + "ExcludePatterns.", this.ExcludePatterns);
            this.SetParamSimple(map, prefix + "ExcludeSystemDirectories", this.ExcludeSystemDirectories);
            this.SetParamSimple(map, prefix + "VaultId", this.VaultId);
            this.SetParamSimple(map, prefix + "ScannedFileCount", this.ScannedFileCount);
            this.SetParamSimple(map, prefix + "ScannedSize", this.ScannedSize);
            this.SetParamSimple(map, prefix + "ScannedSizeFormatted", this.ScannedSizeFormatted);
            this.SetParamSimple(map, prefix + "BackupFileCount", this.BackupFileCount);
            this.SetParamSimple(map, prefix + "BackupSize", this.BackupSize);
            this.SetParamSimple(map, prefix + "BackupSizeFormatted", this.BackupSizeFormatted);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "IsPermanent", this.IsPermanent);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamArraySimple(map, prefix + "NonExistSourcePaths.", this.NonExistSourcePaths);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
        }
    }
}

