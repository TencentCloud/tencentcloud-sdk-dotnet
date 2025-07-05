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

    public class DescribeBackupsRequest : AbstractModel
    {
        
        /// <summary>
        /// 开始时间(yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间(yyyy-MM-dd HH:mm:ss)
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 实例ID，形如mssql-njj2mtpl
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 分页返回，每页返回的数目，取值为1-100，默认值为20
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 分页返回，页编号，默认值为第0页
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 按照备份名称筛选，不填则不筛选此项
        /// </summary>
        [JsonProperty("BackupName")]
        public string BackupName{ get; set; }

        /// <summary>
        /// 按照备份策略筛选，0-实例备份，1-多库备份，不填则不筛选此项
        /// </summary>
        [JsonProperty("Strategy")]
        public long? Strategy{ get; set; }

        /// <summary>
        /// 按照备份方式筛选，0-后台自动定时备份，1-用户手动临时备份，2-定期备份，不填则不筛选此项
        /// </summary>
        [JsonProperty("BackupWay")]
        public long? BackupWay{ get; set; }

        /// <summary>
        /// 按照备份ID筛选，不填则不筛选此项
        /// </summary>
        [JsonProperty("BackupId")]
        public ulong? BackupId{ get; set; }

        /// <summary>
        /// 按照备份的库名称筛选，不填则不筛选此项
        /// </summary>
        [JsonProperty("DatabaseName")]
        public string DatabaseName{ get; set; }

        /// <summary>
        /// 是否分组查询，默认是0，单库备份情况下 0-兼容老方式不分组，1-单库备份分组后展示
        /// </summary>
        [JsonProperty("Group")]
        public long? Group{ get; set; }

        /// <summary>
        /// 备份类型，1-数据备份，2-日志备份，默认值为1
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 按照备份文件形式筛选，pkg-打包备份文件，single-单库备份文件
        /// </summary>
        [JsonProperty("BackupFormat")]
        public string BackupFormat{ get; set; }

        /// <summary>
        /// 备份存储策略 0-跟随自定义备份保留策略 1-跟随实例生命周期直到实例下线，默认取值0
        /// </summary>
        [JsonProperty("StorageStrategy")]
        public long? StorageStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "BackupName", this.BackupName);
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamSimple(map, prefix + "BackupWay", this.BackupWay);
            this.SetParamSimple(map, prefix + "BackupId", this.BackupId);
            this.SetParamSimple(map, prefix + "DatabaseName", this.DatabaseName);
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "BackupFormat", this.BackupFormat);
            this.SetParamSimple(map, prefix + "StorageStrategy", this.StorageStrategy);
        }
    }
}

