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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AgentToolOutputParameter : AbstractModel
    {
        
        /// <summary>
        /// <p>参数名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>变量描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>参数类型</p><p>枚举值：</p><ul><li>0： STRING</li><li>1： INT</li><li>2： FLOAT</li><li>3： BOOL</li><li>4： OBJECT</li><li>5： ARRAY_STRING</li><li>6： ARRAY_INT</li><li>7： ARRAY_FLOAT</li><li>8： ARRAY_BOOL</li><li>9： ARRAY_OBJECT</li><li>20： ARRAY_ARRAY</li><li>99： NULL</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>子参数，仅 OBJECT 或 ARRAY_OBJECT 类型时使用</p>
        /// </summary>
        [JsonProperty("SubParameterList")]
        public AgentToolOutputParameter[] SubParameterList{ get; set; }

        /// <summary>
        /// <p>解析方式</p>
        /// </summary>
        [JsonProperty("RenderMode")]
        public long? RenderMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "SubParameterList.", this.SubParameterList);
            this.SetParamSimple(map, prefix + "RenderMode", this.RenderMode);
        }
    }
}

