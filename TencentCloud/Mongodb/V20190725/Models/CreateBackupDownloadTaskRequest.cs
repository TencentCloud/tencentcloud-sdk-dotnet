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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBackupDownloadTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID，格式如：cmgo-p8vnipr5。与云数据库控制台页面中显示的实例ID相同。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 要下载的备份文件名，可通过DescribeDBBackups接口获取。
        /// </summary>
        [JsonProperty("BackupName")]
        public string BackupName{ get; set; }

        /// <summary>
        /// 指定要下载的副本集的节点名称 或 分片集群的分片名称列表。
        /// 如副本集cmgo-p8vnipr5，示例(固定取值)：BackupSets.0=cmgo-p8vnipr5_0，可下载全量数据。
        /// 如分片集群cmgo-p8vnipr5，示例：BackupSets.0=cmgo-p8vnipr5_0&BackupSets.1=cmgo-p8vnipr5_1，即下载分片0和分片1的数据，分片集群如需全量下载，请按示例方式传入全部分片名称。
        /// </summary>
        [JsonProperty("BackupSets")]
        public ReplicaSetInfo[] BackupSets{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupName", this.BackupName);
            this.SetParamArrayObj(map, prefix + "BackupSets.", this.BackupSets);
        }
    }
}

