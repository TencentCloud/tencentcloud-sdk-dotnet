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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMlflowServerRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>MlFlow Server 名称</p>
        /// </summary>
        [JsonProperty("ServerName")]
        public string ServerName{ get; set; }

        /// <summary>
        /// <p>资源分区 ID</p>
        /// </summary>
        [JsonProperty("ResourcePartitionId")]
        public string ResourcePartitionId{ get; set; }

        /// <summary>
        /// <p>资源组（逻辑队列名，可选）</p>
        /// </summary>
        [JsonProperty("Queue")]
        public string Queue{ get; set; }

        /// <summary>
        /// <p>MlFlow 镜像</p>
        /// </summary>
        [JsonProperty("Image")]
        public string Image{ get; set; }

        /// <summary>
        /// <p>存储配置 JSON，按 StorageMode 解释：cos={bucket,region,path}，cfs={fileSystemId,path}（cos/cfs 必填，local 为空）</p>
        /// </summary>
        [JsonProperty("StorageConfig")]
        public string StorageConfig{ get; set; }

        /// <summary>
        /// <p>存储模式: cos / cfs / local</p>
        /// </summary>
        [JsonProperty("StorageMode")]
        public string StorageMode{ get; set; }

        /// <summary>
        /// <p>MlFlow的资源配置</p>
        /// </summary>
        [JsonProperty("ResourceConfig")]
        public MlFlowResourceConfig ResourceConfig{ get; set; }

        /// <summary>
        /// <p>标签列表（TagKey-TagValue），用于将 MLflow Server 与腾讯云标签系统中的标签绑定</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServerName", this.ServerName);
            this.SetParamSimple(map, prefix + "ResourcePartitionId", this.ResourcePartitionId);
            this.SetParamSimple(map, prefix + "Queue", this.Queue);
            this.SetParamSimple(map, prefix + "Image", this.Image);
            this.SetParamSimple(map, prefix + "StorageConfig", this.StorageConfig);
            this.SetParamSimple(map, prefix + "StorageMode", this.StorageMode);
            this.SetParamObj(map, prefix + "ResourceConfig.", this.ResourceConfig);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

