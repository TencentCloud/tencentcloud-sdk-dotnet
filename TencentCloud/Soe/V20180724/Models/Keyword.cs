/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Soe.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Keyword : AbstractModel
    {
        
        /// <summary>
        /// 被评估语音对应的文本，句子模式下不超过个 20 单词或者中文文字，段落模式不超过 120 单词或者中文文字，中文评估使用 utf-8 编码，自由说模式该值无效。如需要在单词模式和句子模式下使用自定义音素，可以通过设置 TextMode 使用[音素标注](https://cloud.tencent.com/document/product/884/33698)。
        /// </summary>
        [JsonProperty("RefText")]
        public string RefText{ get; set; }

        /// <summary>
        /// 评估模式，0：词模式（中文评测模式下为文字模式），1：句子模式，2：段落模式，3：自由说模式，当为词模式评估时，能够提供每个音节的评估信息，当为句子模式时，能够提供完整度和流利度信息。
        /// </summary>
        [JsonProperty("EvalMode")]
        public ulong? EvalMode{ get; set; }

        /// <summary>
        /// 评价苛刻指数，取值为[1.0 - 4.0]范围内的浮点数，用于平滑不同年龄段的分数，1.0为小年龄段，4.0为最高年龄段
        /// </summary>
        [JsonProperty("ScoreCoeff")]
        public float? ScoreCoeff{ get; set; }

        /// <summary>
        /// 评估语言，0：英文，1：中文。
        /// </summary>
        [JsonProperty("ServerType")]
        public ulong? ServerType{ get; set; }

        /// <summary>
        /// 输入文本模式，0: 普通文本，1：[音素结构](https://cloud.tencent.com/document/product/884/33698)文本。
        /// </summary>
        [JsonProperty("TextMode")]
        public ulong? TextMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RefText", this.RefText);
            this.SetParamSimple(map, prefix + "EvalMode", this.EvalMode);
            this.SetParamSimple(map, prefix + "ScoreCoeff", this.ScoreCoeff);
            this.SetParamSimple(map, prefix + "ServerType", this.ServerType);
            this.SetParamSimple(map, prefix + "TextMode", this.TextMode);
        }
    }
}

