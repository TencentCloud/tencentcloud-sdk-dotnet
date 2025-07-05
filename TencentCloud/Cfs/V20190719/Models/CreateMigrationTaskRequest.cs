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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMigrationTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 迁移任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

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
        /// 数据源账号的SecretId
        /// </summary>
        [JsonProperty("SrcSecretId")]
        public string SrcSecretId{ get; set; }

        /// <summary>
        /// 数据源账号的SecretKey
        /// </summary>
        [JsonProperty("SrcSecretKey")]
        public string SrcSecretKey{ get; set; }

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
        /// 数据源服务商。COS: 腾讯云COS，OSS: 阿里云OSS，OBS:华为云OBS
        /// </summary>
        [JsonProperty("SrcService")]
        public string SrcService{ get; set; }

        /// <summary>
        /// 数据源桶名称，名称和地址至少有一个
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 数据源桶地域
        /// </summary>
        [JsonProperty("BucketRegion")]
        public string BucketRegion{ get; set; }

        /// <summary>
        /// 数据源桶地址，名称和地址至少有一个
        /// </summary>
        [JsonProperty("BucketAddress")]
        public string BucketAddress{ get; set; }

        /// <summary>
        /// 清单地址，迁移方式为清单迁移时必填
        /// </summary>
        [JsonProperty("ListAddress")]
        public string ListAddress{ get; set; }

        /// <summary>
        /// 目标文件系统名称
        /// </summary>
        [JsonProperty("FsName")]
        public string FsName{ get; set; }

        /// <summary>
        /// 源桶路径，默认为/
        /// </summary>
        [JsonProperty("BucketPath")]
        public string BucketPath{ get; set; }

        /// <summary>
        /// 迁移方向。0: 对象存储迁移至文件系统，1: 文件系统迁移至对象存储。默认 0
        /// </summary>
        [JsonProperty("Direction")]
        public ulong? Direction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "MigrationType", this.MigrationType);
            this.SetParamSimple(map, prefix + "MigrationMode", this.MigrationMode);
            this.SetParamSimple(map, prefix + "SrcSecretId", this.SrcSecretId);
            this.SetParamSimple(map, prefix + "SrcSecretKey", this.SrcSecretKey);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "FsPath", this.FsPath);
            this.SetParamSimple(map, prefix + "CoverType", this.CoverType);
            this.SetParamSimple(map, prefix + "SrcService", this.SrcService);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "BucketRegion", this.BucketRegion);
            this.SetParamSimple(map, prefix + "BucketAddress", this.BucketAddress);
            this.SetParamSimple(map, prefix + "ListAddress", this.ListAddress);
            this.SetParamSimple(map, prefix + "FsName", this.FsName);
            this.SetParamSimple(map, prefix + "BucketPath", this.BucketPath);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
        }
    }
}

