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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Backup : AbstractModel
    {
        
        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 文件大小，单位 KB
        /// </summary>
        [JsonProperty("Size")]
        public long? Size{ get; set; }

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
        /// 内网下载地址
        /// </summary>
        [JsonProperty("InternalAddr")]
        public string InternalAddr{ get; set; }

        /// <summary>
        /// 外网下载地址
        /// </summary>
        [JsonProperty("ExternalAddr")]
        public string ExternalAddr{ get; set; }

        /// <summary>
        /// 备份文件唯一标识，RestoreInstance接口会用到该字段
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 备份文件状态（0-创建中；1-成功；2-失败）
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 多库备份时的DB列表
        /// </summary>
        [JsonProperty("DBs")]
        public string[] DBs{ get; set; }

        /// <summary>
        /// 备份策略（0-实例备份；1-多库备份）
        /// </summary>
        [JsonProperty("Strategy")]
        public long? Strategy{ get; set; }

        /// <summary>
        /// 备份方式，0-定时备份；1-手动临时备份
        /// </summary>
        [JsonProperty("BackupWay")]
        public long? BackupWay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "Size", this.Size);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "InternalAddr", this.InternalAddr);
            this.SetParamSimple(map, prefix + "ExternalAddr", this.ExternalAddr);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "DBs.", this.DBs);
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamSimple(map, prefix + "BackupWay", this.BackupWay);
        }
    }
}

