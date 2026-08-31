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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SetQueueAutoScalingRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群 ID。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 队列名称。
        /// </summary>
        [JsonProperty("QueueName")]
        public string QueueName{ get; set; }

        /// <summary>
        /// <p>伸缩容量策略，用于设置目标容量及容量单位。单独传入时仅更新容量相关配置，未传字段保持原值。</p>
        /// </summary>
        [JsonProperty("ScalingPolicy")]
        public ScalingPolicy ScalingPolicy{ get; set; }

        /// <summary>
        /// <p>扩容策略，用于配置启动模板、机型族、GPU 卡数、规格优先级和多可用区等扩容方式。单独传入时仅更新扩容相关配置，未传字段保持原值。</p>
        /// </summary>
        [JsonProperty("ExpansionPolicy")]
        public ExpansionPolicy ExpansionPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "QueueName", this.QueueName);
            this.SetParamObj(map, prefix + "ScalingPolicy.", this.ScalingPolicy);
            this.SetParamObj(map, prefix + "ExpansionPolicy.", this.ExpansionPolicy);
        }
    }
}

