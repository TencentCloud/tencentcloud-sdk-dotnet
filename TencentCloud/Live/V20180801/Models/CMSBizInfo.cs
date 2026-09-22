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

namespace TencentCloud.Live.V20180801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CMSBizInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>策略类型，可选值：<br>Text：文本ShortAudio：音频<br>Image:<br>图片。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StrategyType")]
        public string StrategyType{ get; set; }

        /// <summary>
        /// <p>策略标识（自动生成）。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// <p>策略开通状态。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public bool? Status{ get; set; }

        /// <summary>
        /// <p>策略配置。<br>json字符串。</p><p>具体取值方式如下：举例：色情：&quot;{"ability":{"asr_text":true,"audio":true},"asr_text_labels":{"porn":["OVR","Pornography","PornographyObscene"]},"audio_labels":{},"user_text_libs":["320fb40e-9305-4b00-a191-945c219b5cc0"]}&quot;    可选项： {     value: &#39;OVR&#39;,     text: t(&#39;低俗语音识别&#39;),     msg: t(&#39;示例：呻吟、娇喘、娇喘等性暗示相关的语音&#39;),   },   {     value: &#39;Pornography&#39;,     text: t(&#39;严重色情&#39;),     msg: t(&#39;性行为、性器官等相关描述&#39;),   },   {     value: &#39;PornographyObscene&#39;,     text: t(&#39;色情低俗&#39;),     msg: t(&#39;低俗行为、性暗示等相关描述&#39;),   }</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StrategyConfig")]
        public string StrategyConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StrategyType", this.StrategyType);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StrategyConfig", this.StrategyConfig);
        }
    }
}

