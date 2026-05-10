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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WidgetParam : AbstractModel
    {
        
        /// <summary>
        /// <p>参数名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>参数类型</p><p>枚举值：</p><ul><li>0： string</li><li>1： int</li><li>2： float</li><li>3： bool</li><li>4： object</li><li>5： array_string</li><li>6： array_int</li><li>7： array_float</li><li>8： array_bool</li><li>9： array_object</li><li>20： array_array</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>子参数</p>
        /// </summary>
        [JsonProperty("SubParams")]
        public WidgetParam[] SubParams{ get; set; }

        /// <summary>
        /// <p>默认值, Input未指定时，使用该值</p>
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// <p>输入的值</p>
        /// </summary>
        [JsonProperty("Input")]
        public AgentInput Input{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "SubParams.", this.SubParams);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamObj(map, prefix + "Input.", this.Input);
        }
    }
}

