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

    public class CreatePartitionQueueRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>分区编码</p>
        /// </summary>
        [JsonProperty("PartitionCode")]
        public string PartitionCode{ get; set; }

        /// <summary>
        /// <p>队列名称</p>
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// <p>资源规格列表，定义队列的资源类型及大小范围</p>
        /// </summary>
        [JsonProperty("ResourceUsages")]
        public ResourceUsage[] ResourceUsages{ get; set; }

        /// <summary>
        /// <p>队列类型：1-独占型，2-共享型</p>
        /// </summary>
        [JsonProperty("QueueType")]
        public long? QueueType{ get; set; }

        /// <summary>
        /// <p>队列描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PartitionCode", this.PartitionCode);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamArrayObj(map, prefix + "ResourceUsages.", this.ResourceUsages);
            this.SetParamSimple(map, prefix + "QueueType", this.QueueType);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

