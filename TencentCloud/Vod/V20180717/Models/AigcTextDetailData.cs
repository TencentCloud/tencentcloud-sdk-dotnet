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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AigcTextDetailData : AbstractModel
    {
        
        /// <summary>
        /// <p>请求开始时间(RFC3339)</p>
        /// </summary>
        [JsonProperty("Timestamp")]
        public string Timestamp{ get; set; }

        /// <summary>
        /// <p>网关层请求 ID</p>
        /// </summary>
        [JsonProperty("ReqId")]
        public string ReqId{ get; set; }

        /// <summary>
        /// <p>后端模型返回的对话 ID</p>
        /// </summary>
        [JsonProperty("ChatId")]
        public string ChatId{ get; set; }

        /// <summary>
        /// <p>返回给客户端的 HTTP 状态码</p>
        /// </summary>
        [JsonProperty("StatusCode")]
        public ulong? StatusCode{ get; set; }

        /// <summary>
        /// <p>模型名</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>应用ID</p>
        /// </summary>
        [JsonProperty("SubAppId")]
        public ulong? SubAppId{ get; set; }

        /// <summary>
        /// <p>脱敏后的 api_key:前 8 位 + ****(长度 ≤ 8 时原样返回)</p>
        /// </summary>
        [JsonProperty("ApiKey")]
        public string ApiKey{ get; set; }

        /// <summary>
        /// <p>是否流式返回</p>
        /// </summary>
        [JsonProperty("Stream")]
        public bool? Stream{ get; set; }

        /// <summary>
        /// <p>输入 token 数</p>
        /// </summary>
        [JsonProperty("InputTokens")]
        public long? InputTokens{ get; set; }

        /// <summary>
        /// <p>输出 token 数</p>
        /// </summary>
        [JsonProperty("OutputTokens")]
        public long? OutputTokens{ get; set; }

        /// <summary>
        /// <p>命中 prompt 缓存的 token 数</p>
        /// </summary>
        [JsonProperty("CacheInputTokens")]
        public long? CacheInputTokens{ get; set; }

        /// <summary>
        /// <p>总 token 数</p>
        /// </summary>
        [JsonProperty("TotalTokens")]
        public long? TotalTokens{ get; set; }

        /// <summary>
        /// <p>生成阶段的tokens/秒</p>
        /// </summary>
        [JsonProperty("TPS")]
        public float? TPS{ get; set; }

        /// <summary>
        /// <p>首字延迟(Time To First Token)</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("TTFT")]
        public float? TTFT{ get; set; }

        /// <summary>
        /// <p>端到端总耗时</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("Total")]
        public float? Total{ get; set; }

        /// <summary>
        /// <p>入口协议:completions / responses / anthropic</p>
        /// </summary>
        [JsonProperty("ApiType")]
        public string ApiType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "ReqId", this.ReqId);
            this.SetParamSimple(map, prefix + "ChatId", this.ChatId);
            this.SetParamSimple(map, prefix + "StatusCode", this.StatusCode);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "ApiKey", this.ApiKey);
            this.SetParamSimple(map, prefix + "Stream", this.Stream);
            this.SetParamSimple(map, prefix + "InputTokens", this.InputTokens);
            this.SetParamSimple(map, prefix + "OutputTokens", this.OutputTokens);
            this.SetParamSimple(map, prefix + "CacheInputTokens", this.CacheInputTokens);
            this.SetParamSimple(map, prefix + "TotalTokens", this.TotalTokens);
            this.SetParamSimple(map, prefix + "TPS", this.TPS);
            this.SetParamSimple(map, prefix + "TTFT", this.TTFT);
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "ApiType", this.ApiType);
        }
    }
}

