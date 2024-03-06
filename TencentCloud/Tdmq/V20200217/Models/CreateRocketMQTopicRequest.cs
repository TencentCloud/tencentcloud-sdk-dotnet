/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateRocketMQTopicRequest : AbstractModel
    {
        
        /// <summary>
        /// 主题名称，3-64个字符，只能包含字母、数字、“-”及“_”
        /// </summary>
        [JsonProperty("Topic")]
        public string Topic{ get; set; }

        /// <summary>
        /// 主题所在的命名空间，目前支持在单个命名空间下创建主题
        /// </summary>
        [JsonProperty("Namespaces")]
        public string[] Namespaces{ get; set; }

        /// <summary>
        /// 主题类型，可选值为Normal, GlobalOrder, PartitionedOrder, Transaction, DelayScheduled。Transaction仅在专享版支持。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 主题说明，最大128个字符
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 分区数，全局顺序无效
        /// </summary>
        [JsonProperty("PartitionNum")]
        public long? PartitionNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Topic", this.Topic);
            this.SetParamArraySimple(map, prefix + "Namespaces.", this.Namespaces);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "PartitionNum", this.PartitionNum);
        }
    }
}

