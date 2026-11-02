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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloneViralRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>爆款视频Url</p>
        /// </summary>
        [JsonProperty("VideoUrl")]
        public string VideoUrl{ get; set; }

        /// <summary>
        /// <p>处理类型</p><p>枚举值：</p><ul><li>script ： 脚本级爆款复刻</li><li>motion： 动作级爆款复刻</li><li>depth： 深度估计</li></ul>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// <p>产品信息。除深度提取外，其他模式必填</p>
        /// </summary>
        [JsonProperty("Product")]
        public CloneViralProduct Product{ get; set; }

        /// <summary>
        /// <p>AIGC生视频相关参数</p>
        /// </summary>
        [JsonProperty("AIGCParam")]
        public CloneViralAIGC AIGCParam{ get; set; }

        /// <summary>
        /// <p>内容/风格相关参数</p>
        /// </summary>
        [JsonProperty("ContentParam")]
        public CloneViralContent ContentParam{ get; set; }

        /// <summary>
        /// <p>模特形象</p>
        /// </summary>
        [JsonProperty("Persona")]
        public CloneViralPersona Persona{ get; set; }

        /// <summary>
        /// <p>输出相关参数</p>
        /// </summary>
        [JsonProperty("Output")]
        public CloneViralOutputOption Output{ get; set; }

        /// <summary>
        /// <p>其他参考素材（如背景、服装）</p>
        /// </summary>
        [JsonProperty("Reference")]
        public CloneViralReference Reference{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VideoUrl", this.VideoUrl);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamObj(map, prefix + "Product.", this.Product);
            this.SetParamObj(map, prefix + "AIGCParam.", this.AIGCParam);
            this.SetParamObj(map, prefix + "ContentParam.", this.ContentParam);
            this.SetParamObj(map, prefix + "Persona.", this.Persona);
            this.SetParamObj(map, prefix + "Output.", this.Output);
            this.SetParamObj(map, prefix + "Reference.", this.Reference);
        }
    }
}

