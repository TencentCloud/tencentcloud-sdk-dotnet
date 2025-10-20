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

    public class BeautyEffectItemConfig : AbstractModel
    {
        
        /// <summary>
        /// 类型名称。取值如下：
        /// <li>Whiten：美白</li>
        /// <li>BlackAlpha1：美黑</li>
        /// <li>BlackAlpha2：较强美黑</li>
        /// <li>FoundationAlpha2：美白-粉白</li>
        /// <li>Clear：清晰度</li>
        /// <li>Sharpen：锐化</li>
        /// <li>Smooth：磨皮</li>
        /// <li>BeautyThinFace：瘦脸</li>
        /// <li>NatureFace：自然脸型</li>
        /// <li>VFace：V脸</li>
        /// <li>EnlargeEye：大眼</li>
        /// <li>EyeLighten：亮眼</li>
        /// <li>RemoveEyeBags：祛眼袋</li>
        /// <li>ThinNose：瘦鼻</li>
        /// <li>RemoveLawLine：祛法令纹</li>
        /// <li>CheekboneThin：瘦颧骨</li>
        /// <li>FaceFeatureLipsLut：口红</li>
        /// <li>ToothWhiten：牙齿美白</li>
        /// <li>FaceFeatureSoftlight：柔光</li>
        /// <li>Makeup：美妆</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 能力配置开关，可选值：
        /// <li>ON：开启；</li>
        /// <li>OFF：关闭。</li>
        /// 默认值：ON。
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }

        /// <summary>
        /// 效果强度，值范围：[0, 100]。
        /// </summary>
        [JsonProperty("Value")]
        public long? Value{ get; set; }

        /// <summary>
        /// 附加资源路径。
        /// </summary>
        [JsonProperty("ResourcePath")]
        public string ResourcePath{ get; set; }

        /// <summary>
        /// 自定义参数。
        /// </summary>
        [JsonProperty("ExtInfo")]
        public string ExtInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
            this.SetParamSimple(map, prefix + "Value", this.Value);
            this.SetParamSimple(map, prefix + "ResourcePath", this.ResourcePath);
            this.SetParamSimple(map, prefix + "ExtInfo", this.ExtInfo);
        }
    }
}

