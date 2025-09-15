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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConsumerGroup : AbstractModel
    {
        
        /// <summary>
        /// 消费组名称
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// 状态。
        /// 
        /// - Empty：组内没有成员，但存在已提交的偏移量。所有消费者都离开但保留了偏移量
        /// - Dead：组内没有成员，且没有已提交的偏移量。组被删除或长时间无活动
        /// - Stable：组内成员正常消费，分区分配平衡。正常运行状态
        /// - PreparingRebalance：组正在准备重新平衡。有新成员加入或现有成员离开
        /// - CompletingRebalance：组正在准备重新平衡。有新成员加入或现有成员离开
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 分区分配策略均衡算法名称。
        /// 
        /// - 常见均衡算法如下：
        ///     - range:按分区范围分配
        ///     - roundrobin:轮询式分配
        ///     - sticky:粘性分配（避免不必要的重平衡）
        /// </summary>
        [JsonProperty("ProtocolName")]
        public string ProtocolName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "ProtocolName", this.ProtocolName);
        }
    }
}

