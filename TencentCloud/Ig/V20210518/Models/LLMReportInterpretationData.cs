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

namespace TencentCloud.Ig.V20210518.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LLMReportInterpretationData : AbstractModel
    {
        
        /// <summary>
        /// <p>大模型返回问答内容</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>大模型返回思考内容</p>
        /// </summary>
        [JsonProperty("Think")]
        public string Think{ get; set; }

        /// <summary>
        /// <p>序号，无业务含义，标识流式结果的序号</p>
        /// </summary>
        [JsonProperty("Sort")]
        public long? Sort{ get; set; }

        /// <summary>
        /// <p>流式输出结束标识，false:未结束，true:结束</p>
        /// </summary>
        [JsonProperty("IsFinish")]
        public bool? IsFinish{ get; set; }

        /// <summary>
        /// <p>是否命中敏感词，false:否，true:是；</p>
        /// </summary>
        [JsonProperty("IsSensitive")]
        public bool? IsSensitive{ get; set; }

        /// <summary>
        /// <p>是否支持报告类型，false:否，true:是； 默认返回true，不支持的报告类型返回false</p>
        /// </summary>
        [JsonProperty("IsSupportFile")]
        public bool? IsSupportFile{ get; set; }

        /// <summary>
        /// <p>返回的报告列表，和传入报告文件顺序一致</p>
        /// </summary>
        [JsonProperty("ReportInfos")]
        public ReportFileInfoRsp[] ReportInfos{ get; set; }

        /// <summary>
        /// <p>引用资料列表，流式输出方式，只在流式输出第一次返回；</p>
        /// </summary>
        [JsonProperty("ReferResourceItems")]
        public ReferResourceInfo[] ReferResourceItems{ get; set; }

        /// <summary>
        /// <p>猜你想问列表，流式输出方式，只在流式结束输出结果；</p>
        /// </summary>
        [JsonProperty("GuessQuestions")]
        public GuessQuestion[] GuessQuestions{ get; set; }

        /// <summary>
        /// <p>高亮词列表，流式输出方式在流式过程中输出结果。</p>
        /// </summary>
        [JsonProperty("HighlightWords")]
        public HighlightWordInfo[] HighlightWords{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Think", this.Think);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "IsFinish", this.IsFinish);
            this.SetParamSimple(map, prefix + "IsSensitive", this.IsSensitive);
            this.SetParamSimple(map, prefix + "IsSupportFile", this.IsSupportFile);
            this.SetParamArrayObj(map, prefix + "ReportInfos.", this.ReportInfos);
            this.SetParamArrayObj(map, prefix + "ReferResourceItems.", this.ReferResourceItems);
            this.SetParamArrayObj(map, prefix + "GuessQuestions.", this.GuessQuestions);
            this.SetParamArrayObj(map, prefix + "HighlightWords.", this.HighlightWords);
        }
    }
}

