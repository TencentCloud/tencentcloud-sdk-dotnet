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

    public class CheckpointConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>Checkpoint 产出存储的 Catalog 配置 JSON（结构同顶层 Catalog）</p>
        /// </summary>
        [JsonProperty("Catalog")]
        public string Catalog{ get; set; }

        /// <summary>
        /// <p>保存策略：steps / epoch / none，默认 steps；GRPO 仅支持 steps / none</p>
        /// </summary>
        [JsonProperty("SaveStrategy")]
        public string SaveStrategy{ get; set; }

        /// <summary>
        /// <p>保存频率（每 N 步或每 N epoch），默认 500</p>
        /// </summary>
        [JsonProperty("SaveFreq")]
        public long? SaveFreq{ get; set; }

        /// <summary>
        /// <p>最大保留数量，0 表示不限制，默认 3</p>
        /// </summary>
        [JsonProperty("MaxKeep")]
        public long? MaxKeep{ get; set; }

        /// <summary>
        /// <p>容器内输出目录回退值（可选；正常场景由 Checkpoint 挂载路径决定，仅在挂载路径为空时生效，默认 /workspace/output/{mode}）</p>
        /// </summary>
        [JsonProperty("OutputDir")]
        public string OutputDir{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Catalog", this.Catalog);
            this.SetParamSimple(map, prefix + "SaveStrategy", this.SaveStrategy);
            this.SetParamSimple(map, prefix + "SaveFreq", this.SaveFreq);
            this.SetParamSimple(map, prefix + "MaxKeep", this.MaxKeep);
            this.SetParamSimple(map, prefix + "OutputDir", this.OutputDir);
        }
    }
}

