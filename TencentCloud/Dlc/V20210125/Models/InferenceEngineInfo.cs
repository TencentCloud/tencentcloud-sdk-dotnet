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

    public class InferenceEngineInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>引擎标识符</p>
        /// </summary>
        [JsonProperty("EngineId")]
        public string EngineId{ get; set; }

        /// <summary>
        /// <p>引擎名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>引擎版本</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>引擎描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// </summary>
        [JsonProperty("Tags")]
        public string[] Tags{ get; set; }

        /// <summary>
        /// <p>支持的模型类型</p>
        /// </summary>
        [JsonProperty("ModelTypes")]
        public string[] ModelTypes{ get; set; }

        /// <summary>
        /// <p>是否独占，如果为 true，表示自定义模型看不到这个推理引擎，通常用于自研内置模型</p>
        /// </summary>
        [JsonProperty("Exclusive")]
        public bool? Exclusive{ get; set; }

        /// <summary>
        /// <p>是否启用</p>
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// <p>引擎能力声明</p>
        /// </summary>
        [JsonProperty("Capabilities")]
        public EngineCapabilities Capabilities{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineId", this.EngineId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "ModelTypes.", this.ModelTypes);
            this.SetParamSimple(map, prefix + "Exclusive", this.Exclusive);
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamObj(map, prefix + "Capabilities.", this.Capabilities);
        }
    }
}

