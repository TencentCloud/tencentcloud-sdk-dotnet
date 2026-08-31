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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteTWeSeeTasksByConditionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>产品 ID</p>
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// <p>设备名称</p>
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// <p>算法类目。</p><p>枚举值：</p><ul><li>COMPREHENSION： 视觉理解</li><li>HIGHLIGHT： 视频浓缩</li><li>SUMMARIZATION： 每日/每周总结</li></ul>
        /// </summary>
        [JsonProperty("ServiceCategory")]
        public string ServiceCategory{ get; set; }

        /// <summary>
        /// <p>任务删除条件，至少传入一个条件。不同条件之间为 AND 关系，同一条件的 Values 之间为 OR 关系。</p>
        /// </summary>
        [JsonProperty("Conditions")]
        public SeeDeleteTaskCondition[] Conditions{ get; set; }

        /// <summary>
        /// <p>通道 ID</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("ChannelId")]
        public ulong? ChannelId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "ServiceCategory", this.ServiceCategory);
            this.SetParamArrayObj(map, prefix + "Conditions.", this.Conditions);
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
        }
    }
}

