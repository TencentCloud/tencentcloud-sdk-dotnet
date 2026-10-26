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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWConsumerGroupBrief : AbstractModel
    {
        
        /// <summary>
        /// <p>消费者组名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>消费者组Id</p>
        /// </summary>
        [JsonProperty("ConsumerGroupId")]
        public string ConsumerGroupId{ get; set; }

        /// <summary>
        /// <p>消费者组（组织节点）的当前展示路径，可选。TokenUsageList 在网关版本不低于 3.9.8 时，从 Kong CP 当前目录补齐，用于展示当前直接所属组的位置；多父节点使用确定性路径。更早版本、无可用路径或未补齐此元数据的接口可省略；前端缺省时回退 Name。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConsumerGroupPath")]
        public string ConsumerGroupPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ConsumerGroupId", this.ConsumerGroupId);
            this.SetParamSimple(map, prefix + "ConsumerGroupPath", this.ConsumerGroupPath);
        }
    }
}

