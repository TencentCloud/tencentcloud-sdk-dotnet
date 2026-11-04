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
        /// <p>备份点ID</p>
        /// </summary>
        [JsonProperty("BackupId")]
        public string BackupId{ get; set; }

        /// <summary>
        /// <p>备份名称</p>
        /// </summary>
        [JsonProperty("BackupName")]
        public string BackupName{ get; set; }

        /// <summary>
        /// <p>所属计划ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// <p>策略ID</p>
        /// </summary>
        [JsonProperty("AspInstanceId")]
        public string AspInstanceId{ get; set; }

        /// <summary>
        /// <p>资源ID</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>备份状态，取值如下：<br>0 备份完成<br>1 创建中（备份进行中）<br>2 部分成功（指定的备份路径中部分目录不存在）<br>3 恢复中（该备份点正在被恢复任务使用）<br>92  已取消<br>98 创建失败<br>99 已删除<br>100 删除中</p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>备份路径</p>
        /// </summary>
        [JsonProperty("BackupPaths")]
        public string[] BackupPaths{ get; set; }

        /// <summary>
        /// <p>包含文件类型</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncludeFileTypes")]
        public string[] IncludeFileTypes{ get; set; }

        /// <summary>
        /// <p>排除路径</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExcludePatterns")]
        public string[] ExcludePatterns{ get; set; }

        /// <summary>
        /// <p>是否排除系统目录</p>
        /// </summary>
        [JsonProperty("ExcludeSystemDirectories")]
        public bool? ExcludeSystemDirectories{ get; set; }

        /// <summary>
        /// <p>备份库ID</p>
        /// </summary>
        [JsonProperty("VaultId")]
        public string VaultId{ get; set; }

        /// <summary>
        /// <p>扫描文件数</p>
        /// </summary>
        [JsonProperty("ScannedFileCount")]
        public long? ScannedFileCount{ get; set; }

        /// <summary>
        /// <p>扫描大小(字节)</p>
        /// </summary>
        [JsonProperty("ScannedSize")]
        public long? ScannedSize{ get; set; }

        /// <summary>
        /// <p>扫描大小(格式化)</p>
        /// </summary>
        [JsonProperty("ScannedSizeFormatted")]
        public string ScannedSizeFormatted{ get; set; }

        /// <summary>
        /// <p>已备份文件数量</p>
        /// </summary>
        [JsonProperty("BackupFileCount")]
        public long? BackupFileCount{ get; set; }

        /// <summary>
        /// <p>已备份大小(字节)</p>
        /// </summary>
        [JsonProperty("BackupSize")]
        public long? BackupSize{ get; set; }

        /// <summary>
        /// <p>已备份大小(格式化)</p>
        /// </summary>
        [JsonProperty("BackupSizeFormatted")]
        public string BackupSizeFormatted{ get; set; }

        /// <summary>
        /// <p>备份进度(0-100)</p>
        /// </summary>
        [JsonProperty("Progress")]
        public float? Progress{ get; set; }

        /// <summary>
        /// <p>任务ID</p>
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// <p>开始时间</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>结束时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>是否为永久保留</p>
        /// </summary>
        [JsonProperty("IsPermanent")]
        public bool? IsPermanent{ get; set; }

        /// <summary>
        /// <p>到期时间</p>
        /// </summary>
        [JsonProperty("Deadline")]
        public string Deadline{ get; set; }

        /// <summary>
        /// <p>不存在的路径信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NonExistSourcePaths")]
        public string[] NonExistSourcePaths{ get; set; }

        /// <summary>
        /// <p>备份失败原因</p>
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// <p>备份所属AppId</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>备份类型</p>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// <p>cos备份场景使用，标识是否清单生成中</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsInventoryPending")]
        public bool? IsInventoryPending{ get; set; }

        /// <summary>
        /// <p>是否备份对象ACL（仅COS备份支持）</p><p>枚举值：</p><ul><li>true： 是</li><li>false： 否</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableObjectAcl")]
        public bool? EnableObjectAcl{ get; set; }

        /// <summary>
        /// <p>是否备份对象标签（仅COS备份支持）</p><p>枚举值：</p><ul><li>true： 是</li><li>false： 否</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableObjectTags")]
        public bool? EnableObjectTags{ get; set; }

        /// <summary>
        /// <p>云上资源ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CloudResourceId")]
        public string CloudResourceId{ get; set; }

        /// <summary>
        /// <p>产品存储类型</p><p>枚举值：</p><ul><li>SD： 文件系统通用标准型存储</li><li>HP： 文件系统通用性能性存储</li><li>TB： 文件系统Turbo标准型存储</li><li>TP： 文件系统Turbo性能型存储</li><li>THP： 文件系统Turbo吞吐型存储</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductType")]
        public string ProductType{ get; set; }


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
            this.SetParamSimple(map, prefix + "IsInventoryPending", this.IsInventoryPending);
            this.SetParamSimple(map, prefix + "EnableObjectAcl", this.EnableObjectAcl);
            this.SetParamSimple(map, prefix + "EnableObjectTags", this.EnableObjectTags);
            this.SetParamSimple(map, prefix + "CloudResourceId", this.CloudResourceId);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
        }
    }
}

