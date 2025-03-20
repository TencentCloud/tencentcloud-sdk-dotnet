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

namespace TencentCloud.Hunyuan.V20230901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GroupChatCompletionsResponse : AbstractSSEModel
    {
        
        /// <summary>
        /// Unix 时间戳，单位为秒。
        /// </summary>
        [JsonProperty("Created")]
        public long? Created{ get; set; }

        /// <summary>
        /// Token 统计信息。
        /// 按照总 Token 数量计费。
        /// </summary>
        [JsonProperty("Usage")]
        public Usage Usage{ get; set; }

        /// <summary>
        /// 免责声明。
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// 本次请求的 RequestId。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 回复内容。
        /// </summary>
        [JsonProperty("Choices")]
        public Choice[] Choices{ get; set; }

        /// <summary>
        /// 错误信息。
        /// 如果流式返回中服务处理异常，返回该错误信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorMsg")]
        public ErrorMsg ErrorMsg{ get; set; }

        /// <summary>
        /// 搜索结果信息
        /// </summary>
        [JsonProperty("SearchInfo")]
        public SearchInfo SearchInfo{ get; set; }

        /// <summary>
        /// 多媒体信息。
        /// 说明：
        /// 1. 可以用多媒体信息替换回复内容里的占位符，得到完整的消息。
        /// 2. 可能会出现回复内容里存在占位符，但是因为审核等原因没有返回多媒体信息。
        /// </summary>
        [JsonProperty("Replaces")]
        public Replace[] Replaces{ get; set; }

        /// <summary>
        /// 推荐问答。
        /// </summary>
        [JsonProperty("RecommendedQuestions")]
        public string[] RecommendedQuestions{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。本接口为流式响应接口，当请求成功时，RequestId 会被放在 HTTP 响应的 Header "X-TC-RequestId" 中。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Created", this.Created);
            this.SetParamObj(map, prefix + "Usage.", this.Usage);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArrayObj(map, prefix + "Choices.", this.Choices);
            this.SetParamObj(map, prefix + "ErrorMsg.", this.ErrorMsg);
            this.SetParamObj(map, prefix + "SearchInfo.", this.SearchInfo);
            this.SetParamArrayObj(map, prefix + "Replaces.", this.Replaces);
            this.SetParamArraySimple(map, prefix + "RecommendedQuestions.", this.RecommendedQuestions);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

