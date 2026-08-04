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

    public class ModifyPartitionQueueRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源队列ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 分区编码
        /// </summary>
        [JsonProperty("PartitionCode")]
        public string PartitionCode{ get; set; }

        /// <summary>
        /// 队列名称
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// 队列描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 资源规格列表，定义队列的资源类型及大小范围
        /// </summary>
        [JsonProperty("ResourceUsages")]
        public ResourceUsage[] ResourceUsages{ get; set; }

        /// <summary>
        /// 队列类型：1-独占型，2-共享型
        /// </summary>
        [JsonProperty("QueueType")]
        public long? QueueType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "PartitionCode", this.PartitionCode);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "ResourceUsages.", this.ResourceUsages);
            this.SetParamSimple(map, prefix + "QueueType", this.QueueType);
        }
    }
}

