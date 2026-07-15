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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWTokenLengthRoute : AbstractModel
    {
        
        /// <summary>
        /// <p>默认tokenizer编码器</p><p>枚举值：</p><ul><li>o200k_base： OpenApi o200k_base</li><li>cl100k_base： OpenApi cl100k_base</li><li>p50k_base： OpenApi p50k_base</li><li>r50k_base： OpenApi r50k_base</li></ul>
        /// </summary>
        [JsonProperty("DefaultEncodingName")]
        public string DefaultEncodingName{ get; set; }

        /// <summary>
        /// <p>token 计数失败、规则为空或未命中任何规则时执行的默认二级路由（暂时只能选择一个指定模型路由）</p>
        /// </summary>
        [JsonProperty("DefaultTarget")]
        public AIGWLLMModelServiceSubRoute DefaultTarget{ get; set; }

        /// <summary>
        /// <p>规则</p>
        /// </summary>
        [JsonProperty("Rules")]
        public AIGWTokenLengthRouteRule[] Rules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DefaultEncodingName", this.DefaultEncodingName);
            this.SetParamObj(map, prefix + "DefaultTarget.", this.DefaultTarget);
            this.SetParamArrayObj(map, prefix + "Rules.", this.Rules);
        }
    }
}

