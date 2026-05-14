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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WorkflowRunConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>工作流运行最大并发数，取值范围：[1, 1000]</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxConcurrentNum")]
        public ulong? MaxConcurrentNum{ get; set; }

        /// <summary>
        /// <p>1：开启  0：关闭<br>当工作流达到最大并发上限时，若开启，新工作流运行排队等待，直到其他运行释放并发，最大等待时长为48小时，超过则自动跳过不再执行；若关闭，新工作流直接跳过结束。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("QueuingMode")]
        public ulong? QueuingMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxConcurrentNum", this.MaxConcurrentNum);
            this.SetParamSimple(map, prefix + "QueuingMode", this.QueuingMode);
        }
    }
}

