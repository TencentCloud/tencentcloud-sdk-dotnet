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

    public class LoraVersionMeta : AbstractModel
    {
        
        /// <summary>
        /// <p>Lora Rank</p>
        /// </summary>
        [JsonProperty("Rank")]
        public long? Rank{ get; set; }

        /// <summary>
        /// <p>Lora Alpha</p>
        /// </summary>
        [JsonProperty("Alpha")]
        public long? Alpha{ get; set; }

        /// <summary>
        /// <p>LoRA dropout</p>
        /// </summary>
        [JsonProperty("Dropout")]
        public float? Dropout{ get; set; }

        /// <summary>
        /// <p>注入的目标模块</p>
        /// </summary>
        [JsonProperty("TargetModules")]
        public string[] TargetModules{ get; set; }

        /// <summary>
        /// <p>PEFT 类型（如 LORA）</p>
        /// </summary>
        [JsonProperty("PEFTType")]
        public string PEFTType{ get; set; }

        /// <summary>
        /// <p>任务类型（如 CAUSAL_LM）</p>
        /// </summary>
        [JsonProperty("TaskType")]
        public string TaskType{ get; set; }

        /// <summary>
        /// <p>训练时声明的基座名称或路径（base_model_name_or_path）</p>
        /// </summary>
        [JsonProperty("BaseModelNameOrPath")]
        public string BaseModelNameOrPath{ get; set; }

        /// <summary>
        /// <p>最大 rank（含 rank_pattern 分模块 rank；仅当其大于 Rank 时返回）</p>
        /// </summary>
        [JsonProperty("MaxRank")]
        public long? MaxRank{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Rank", this.Rank);
            this.SetParamSimple(map, prefix + "Alpha", this.Alpha);
            this.SetParamSimple(map, prefix + "Dropout", this.Dropout);
            this.SetParamArraySimple(map, prefix + "TargetModules.", this.TargetModules);
            this.SetParamSimple(map, prefix + "PEFTType", this.PEFTType);
            this.SetParamSimple(map, prefix + "TaskType", this.TaskType);
            this.SetParamSimple(map, prefix + "BaseModelNameOrPath", this.BaseModelNameOrPath);
            this.SetParamSimple(map, prefix + "MaxRank", this.MaxRank);
        }
    }
}

