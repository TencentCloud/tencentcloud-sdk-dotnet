/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MigrationTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// 迁移任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 迁移任务id
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 迁移方式标志位，默认为0。0: 桶迁移；1: 清单迁移
        /// </summary>
        [JsonProperty("MigrationType")]
        public ulong? MigrationType{ get; set; }

        /// <summary>
        /// 迁移模式，默认为0。0: 全量迁移
        /// </summary>
        [JsonProperty("MigrationMode")]
        public ulong? MigrationMode{ get; set; }

        /// <summary>
        /// 数据源桶名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 数据源桶地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BucketRegion")]
        public string BucketRegion{ get; set; }

        /// <summary>
        /// 数据源桶地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BucketAddress")]
        public string BucketAddress{ get; set; }

        /// <summary>
        /// 清单地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ListAddress")]
        public string ListAddress{ get; set; }

        /// <summary>
        /// 文件系统实例名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FsName")]
        public string FsName{ get; set; }

        /// <summary>
        /// 文件系统实例Id
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// 文件系统路径
        /// </summary>
        [JsonProperty("FsPath")]
        public string FsPath{ get; set; }

        /// <summary>
        /// 同名文件迁移时覆盖策略，默认为0。0: 最后修改时间优先；1: 全覆盖；2: 不覆盖
        /// </summary>
        [JsonProperty("CoverType")]
        public ulong? CoverType{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 完成/终止时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 迁移状态。0: 已完成；1: 进行中；2: 已终止
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 文件数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileTotalCount")]
        public ulong? FileTotalCount{ get; set; }

        /// <summary>
        /// 已迁移文件数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileMigratedCount")]
        public ulong? FileMigratedCount{ get; set; }

        /// <summary>
        /// 迁移失败文件数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileFailedCount")]
        public ulong? FileFailedCount{ get; set; }

        /// <summary>
        /// 文件容量，单位Byte
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileTotalSize")]
        public long? FileTotalSize{ get; set; }

        /// <summary>
        /// 已迁移文件容量，单位Byte
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileMigratedSize")]
        public long? FileMigratedSize{ get; set; }

        /// <summary>
        /// 迁移失败文件容量，单位Byte
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileFailedSize")]
        public long? FileFailedSize{ get; set; }

        /// <summary>
        /// 全部清单
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileTotalList")]
        public string FileTotalList{ get; set; }

        /// <summary>
        /// 已完成文件清单
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileCompletedList")]
        public string FileCompletedList{ get; set; }

        /// <summary>
        /// 失败文件清单
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileFailedList")]
        public string FileFailedList{ get; set; }

        /// <summary>
        /// 源桶路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BucketPath")]
        public string BucketPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "MigrationType", this.MigrationType);
            this.SetParamSimple(map, prefix + "MigrationMode", this.MigrationMode);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "BucketRegion", this.BucketRegion);
            this.SetParamSimple(map, prefix + "BucketAddress", this.BucketAddress);
            this.SetParamSimple(map, prefix + "ListAddress", this.ListAddress);
            this.SetParamSimple(map, prefix + "FsName", this.FsName);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "FsPath", this.FsPath);
            this.SetParamSimple(map, prefix + "CoverType", this.CoverType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "FileTotalCount", this.FileTotalCount);
            this.SetParamSimple(map, prefix + "FileMigratedCount", this.FileMigratedCount);
            this.SetParamSimple(map, prefix + "FileFailedCount", this.FileFailedCount);
            this.SetParamSimple(map, prefix + "FileTotalSize", this.FileTotalSize);
            this.SetParamSimple(map, prefix + "FileMigratedSize", this.FileMigratedSize);
            this.SetParamSimple(map, prefix + "FileFailedSize", this.FileFailedSize);
            this.SetParamSimple(map, prefix + "FileTotalList", this.FileTotalList);
            this.SetParamSimple(map, prefix + "FileCompletedList", this.FileCompletedList);
            this.SetParamSimple(map, prefix + "FileFailedList", this.FileFailedList);
            this.SetParamSimple(map, prefix + "BucketPath", this.BucketPath);
        }
    }
}

