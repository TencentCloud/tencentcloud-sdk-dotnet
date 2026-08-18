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
        /// <p>数据流动管理 ID</p>
        /// </summary>
        [JsonProperty("DataFlowId")]
        public string DataFlowId{ get; set; }

        /// <summary>
        /// <p>数据流动名称</p>
        /// </summary>
        [JsonProperty("DataFlowName")]
        public string DataFlowName{ get; set; }

        /// <summary>
        /// <p>源端数据类型</p>
        /// </summary>
        [JsonProperty("SourceStorageType")]
        public string SourceStorageType{ get; set; }

        /// <summary>
        /// <p>源端存储地址</p>
        /// </summary>
        [JsonProperty("SourceStorageAddress")]
        public string SourceStorageAddress{ get; set; }

        /// <summary>
        /// <p>源端路径</p>
        /// </summary>
        [JsonProperty("SourcePath")]
        public string SourcePath{ get; set; }

        /// <summary>
        /// <p>设置数据流动时指定的文件系统内目标路径，必须以 /cfs/ 开头，代表文件存储实例内部的逻辑路径，而非本地挂载点路径。<br>示例：</p><ul><li>若挂载的是CFS根目录 /，需将对象存储上的源端目录与挂载路径下的 test1/test2 建立映射关系，则入参值为 /cfs/test1/test2</li><li>若挂载的是CFS子目录 /subdir，需将对象存储上的源端目录与挂载路径下的 test1/test2 建立映射关系，则入参值为 /cfs/subdir/test1/test2</li></ul>
        /// </summary>
        [JsonProperty("TargetPath")]
        public string TargetPath{ get; set; }

        /// <summary>
        /// <p>available：已生效<br>pending：配置中<br>unavailable：失效<br>deleting：删除中</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// <p>文件系统 ID</p>
        /// </summary>
        [JsonProperty("FileSystemId")]
        public string FileSystemId{ get; set; }

        /// <summary>
        /// <p>0：不开启自动更新</p><p>1：开启自动更新</p>
        /// </summary>
        [JsonProperty("AutoRefresh")]
        public ulong? AutoRefresh{ get; set; }

        /// <summary>
        /// <p>KafkaConsumer 消费时使用的Topic参数</p>
        /// </summary>
        [JsonProperty("UserKafkaTopic")]
        public string UserKafkaTopic{ get; set; }

        /// <summary>
        /// <p>服务地址</p>
        /// </summary>
        [JsonProperty("ServerAddr")]
        public string ServerAddr{ get; set; }

        /// <summary>
        /// <p>Kafka消费用户名</p>
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// <p>自动刷新的状态，available：已生效<br>pending：配置中<br>unavailable：失效</p>
        /// </summary>
        [JsonProperty("AutoRefreshStatus")]
        public string AutoRefreshStatus{ get; set; }

        /// <summary>
        /// <p>自动刷新开启时间</p>
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

