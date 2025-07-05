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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackupByFlowIdResponse : AbstractModel
    {
        
        /// <summary>
        /// 备份文件唯一标识，RestoreInstance接口会用到该字段，对于单库备份文件只返回第一条记录的备份文件唯一标识；单库备份文件需要通过DescribeBackupFiles接口获取全部记录的可回档的ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 文件名，对于单库备份文件只返回第一条记录的文件名；单库备份文件需要通过DescribeBackupFiles接口获取全部记录的文件名
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 备份任务名称，可自定义
        /// </summary>
        [JsonProperty("BackupName")]
        public string BackupName{ get; set; }

        /// <summary>
        /// 备份开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 备份结束时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 文件大小，单位 KB，对于单库备份文件只返回第一条记录的文件大小；单库备份文件需要通过DescribeBackupFiles接口获取全部记录的文件大小
        /// </summary>
        [JsonProperty("Size")]
        public ulong? Size{ get; set; }

        /// <summary>
        /// 备份策略，0-实例备份；1-多库备份；实例状态是0-创建中时，该字段为默认值0，无实际意义
        /// </summary>
        [JsonProperty("Strategy")]
        public long? Strategy{ get; set; }

        /// <summary>
        /// 备份文件状态，0-创建中；1-成功；2-失败
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 备份方式，0-定时备份；1-手动临时备份；实例状态是0-创建中时，该字段为默认值0，无实际意义
        /// </summary>
        [JsonProperty("BackupWay")]
        public long? BackupWay{ get; set; }

        /// <summary>
        /// DB列表，对于单库备份文件只返回第一条记录包含的库名；单库备份文件需要通过DescribeBackupFiles接口获取全部记录的库名。
        /// </summary>
        [JsonProperty("DBs")]
        public string[] DBs{ get; set; }

        /// <summary>
        /// 内网下载地址，对于单库备份文件只返回第一条记录的内网下载地址；单库备份文件需要通过DescribeBackupFiles接口获取全部记录的下载地址
        /// </summary>
        [JsonProperty("InternalAddr")]
        public string InternalAddr{ get; set; }

        /// <summary>
        /// 外网下载地址，对于单库备份文件只返回第一条记录的外网下载地址；单库备份文件需要通过DescribeBackupFiles接口获取全部记录的下载地址
        /// </summary>
        [JsonProperty("ExternalAddr")]
        public string ExternalAddr{ get; set; }

        /// <summary>
        /// 聚合Id，对于打包备份文件不返回此值。通过此值调用DescribeBackupFiles接口，获取单库备份文件的详细信息
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

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
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "BackupName", this.BackupName);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "BackupWay", this.BackupWay);
            this.SetParamArraySimple(map, prefix + "DBs.", this.DBs);
            this.SetParamSimple(map, prefix + "InternalAddr", this.InternalAddr);
            this.SetParamSimple(map, prefix + "ExternalAddr", this.ExternalAddr);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

