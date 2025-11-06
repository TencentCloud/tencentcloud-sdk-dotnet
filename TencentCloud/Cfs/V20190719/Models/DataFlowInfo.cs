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

    public class DataFlowInfo : AbstractModel
    {
        
        /// <summary>
        /// 数据流动管理 ID
        /// </summary>
        [JsonProperty("DataFlowId")]
        public string DataFlowId{ get; set; }

        /// <summary>
        /// 数据流动名称
        /// </summary>
        [JsonProperty("DataFlowName")]
        public string DataFlowName{ get; set; }

        /// <summary>
        /// 源端数据类型
        /// </summary>
        [JsonProperty("SourceStorageType")]
        public string SourceStorageType{ get; set; }

        /// <summary>
        /// 源端存储地址
        /// </summary>
        [JsonProperty("SourceStorageAddress")]
        public string SourceStorageAddress{ get; set; }

        /// <summary>
        /// 源端路径
        /// </summary>
        [JsonProperty("SourcePath")]
        public string SourcePath{ get; set; }

        /// <summary>
        /// 目录路径
        /// </summary>
        [JsonProperty("TargetPath")]
        public string TargetPath{ get; set; }

        /// <summary>
        /// available：已生效
        /// pending：配置中
        /// unavailable：失效
        /// deleting：删除中
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// 文件系统 ID
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// 0：不开启自动更新
        /// 
        /// 1：开启自动更新
        /// </summary>
        [JsonProperty("AutoRefresh")]
        public ulong? AutoRefresh{ get; set; }

        /// <summary>
        /// KafkaConsumer 消费时使用的Topic参数
        /// </summary>
        [JsonProperty("UserKafkaTopic")]
        public string UserKafkaTopic{ get; set; }

        /// <summary>
        /// 服务地址
        /// </summary>
        [JsonProperty("ServerAddr")]
        public string ServerAddr{ get; set; }

        /// <summary>
        /// Kafka消费用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 自动刷新的状态，available：已生效
        /// pending：配置中
        /// unavailable：失效
        /// </summary>
        [JsonProperty("AutoRefreshStatus")]
        public string AutoRefreshStatus{ get; set; }

        /// <summary>
        /// 自动刷新开启时间
        /// </summary>
        [JsonProperty("AutoRefreshTime")]
        public string AutoRefreshTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataFlowId", this.DataFlowId);
            this.SetParamSimple(map, prefix + "DataFlowName", this.DataFlowName);
            this.SetParamSimple(map, prefix + "SourceStorageType", this.SourceStorageType);
            this.SetParamSimple(map, prefix + "SourceStorageAddress", this.SourceStorageAddress);
            this.SetParamSimple(map, prefix + "SourcePath", this.SourcePath);
            this.SetParamSimple(map, prefix + "TargetPath", this.TargetPath);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "FileSystemId", this.FileSystemId);
            this.SetParamSimple(map, prefix + "AutoRefresh", this.AutoRefresh);
            this.SetParamSimple(map, prefix + "UserKafkaTopic", this.UserKafkaTopic);
            this.SetParamSimple(map, prefix + "ServerAddr", this.ServerAddr);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "AutoRefreshStatus", this.AutoRefreshStatus);
            this.SetParamSimple(map, prefix + "AutoRefreshTime", this.AutoRefreshTime);
        }
    }
}

