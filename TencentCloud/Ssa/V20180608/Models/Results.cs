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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Results : AbstractModel
    {
        
        /// <summary>
        /// 测绘类型统计
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Statistics")]
        public AssetTypeStatistic[] Statistics{ get; set; }

        /// <summary>
        /// 测绘结果列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Result")]
        public MappingResult[] Result{ get; set; }

        /// <summary>
        /// 测绘任务数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskCount")]
        public ulong? TaskCount{ get; set; }

        /// <summary>
        /// 最大测绘任务数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskMaxCount")]
        public ulong? TaskMaxCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Statistics.", this.Statistics);
            this.SetParamArrayObj(map, prefix + "Result.", this.Result);
            this.SetParamSimple(map, prefix + "TaskCount", this.TaskCount);
            this.SetParamSimple(map, prefix + "TaskMaxCount", this.TaskMaxCount);
        }
    }
}

