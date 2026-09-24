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

namespace TencentCloud.Dataagent.V20250513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelList : AbstractModel
    {
        
        /// <summary>
        /// <p>模型版本名称</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>模型厂商</p>
        /// </summary>
        [JsonProperty("Vendor")]
        public string Vendor{ get; set; }

        /// <summary>
        /// <p>展示名称</p>
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// <p>模型描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>上下文窗口大小，单位 token</p>
        /// </summary>
        [JsonProperty("ContextWindow")]
        public long? ContextWindow{ get; set; }

        /// <summary>
        /// <p>模型图标 URL</p>
        /// </summary>
        [JsonProperty("IconUrl")]
        public string IconUrl{ get; set; }

        /// <summary>
        /// <p>计费倍率</p>
        /// </summary>
        [JsonProperty("CreditMultiplier")]
        public float? CreditMultiplier{ get; set; }

        /// <summary>
        /// <p>思考配置</p>
        /// </summary>
        [JsonProperty("Thinking")]
        public Thinking Thinking{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "Vendor", this.Vendor);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ContextWindow", this.ContextWindow);
            this.SetParamSimple(map, prefix + "IconUrl", this.IconUrl);
            this.SetParamSimple(map, prefix + "CreditMultiplier", this.CreditMultiplier);
            this.SetParamObj(map, prefix + "Thinking.", this.Thinking);
        }
    }
}

