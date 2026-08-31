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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleEngineCustomAction : AbstractModel
    {
        
        /// <summary>
        /// <p>定制配置唯一 ID。</p>
        /// </summary>
        [JsonProperty("ActionId")]
        public string ActionId{ get; set; }

        /// <summary>
        /// <p>定制配置名称。</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>定制配置描述。</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>定制配置参数定义列表。</p>
        /// </summary>
        [JsonProperty("Parameters")]
        public RuleEngineCustomActionParameterSchema[] Parameters{ get; set; }

        /// <summary>
        /// <p>定制配置支持的匹配条件。</p><p>支持匹配条件参考官方文档 <a href="https://cloud.tencent.com/document/product/1552/125344">通用参考-配置语法-变量</a>。</p>
        /// </summary>
        [JsonProperty("SupportedConditions")]
        public string[] SupportedConditions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActionId", this.ActionId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "Parameters.", this.Parameters);
            this.SetParamArraySimple(map, prefix + "SupportedConditions.", this.SupportedConditions);
        }
    }
}

