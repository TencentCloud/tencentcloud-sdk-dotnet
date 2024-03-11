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

namespace TencentCloud.Tms.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModerateTextResponse : AbstractModel
    {
        
        /// <summary>
        /// 该字段用于返回检测对象对应请求参数中的DataId，与输入的DataId字段中的内容对应
        /// </summary>
        [JsonProperty("DataId")]
        public string DataId{ get; set; }

        /// <summary>
        /// 该字段用于返回请求参数中的BizType参数
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// 该字段用于返回后续操作建议。当您获取到判定结果后，返回值表示系统推荐的后续操作；建议您按照业务所需，对不同违规类型与建议值进行处理。
        /// 返回值：Block：建议屏蔽，Review ：建议人工复审，Pass：建议通过
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }

        /// <summary>
        /// 命中标签，可参阅对应数据结构（LabelGrade）的详细描述
        /// </summary>
        [JsonProperty("Label")]
        public LabelGrade Label{ get; set; }

        /// <summary>
        /// 命中标签对应腾讯侧定义的标签
        /// </summary>
        [JsonProperty("TcLabelCodes")]
        public string[] TcLabelCodes{ get; set; }

        /// <summary>
        /// 该字段用于返回当前标签（Label）下被检测文本命中的关键词信息，用于标注文本违规的具体原因（如：加我微信）。该参数可能会有多个返回值，代表命中的多个关键词；如返回值为空且Score不为空，则代表识别结果所对应的恶意标签（Label）是来自于语义模型判断的返回值
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }

        /// <summary>
        /// 该字段用于返回文本审核的详细结果，返回值信息可参阅对应数据结构（ModerationDetail）的详细描述
        /// </summary>
        [JsonProperty("ModerationDetails")]
        public ModerationDetail[] ModerationDetails{ get; set; }

        /// <summary>
        /// 该字段用于返回审核结果置信度，使用百分制。分数越高表示结果可信度越高。
        /// </summary>
        [JsonProperty("Score")]
        public ulong? Score{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataId", this.DataId);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
            this.SetParamObj(map, prefix + "Label.", this.Label);
            this.SetParamArraySimple(map, prefix + "TcLabelCodes.", this.TcLabelCodes);
            this.SetParamArraySimple(map, prefix + "Keywords.", this.Keywords);
            this.SetParamArrayObj(map, prefix + "ModerationDetails.", this.ModerationDetails);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

