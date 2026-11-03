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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CustomGuardrailHit : AbstractModel
    {
        
        /// <summary>
        /// <p>业务网关请求 ID；不是本次云 API 响应的 RequestId。流式同一业务请求可产生多条审核记录。</p>
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }

        /// <summary>
        /// <p>审核记录 Unix 毫秒级时间戳；注意查询入参 StartTime/EndTime 为秒级。</p>
        /// </summary>
        [JsonProperty("Timestamp")]
        public long? Timestamp{ get; set; }

        /// <summary>
        /// <p>网关实例 ID</p>
        /// </summary>
        [JsonProperty("GatewayId")]
        public string GatewayId{ get; set; }

        /// <summary>
        /// <p>策略 ID</p>
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// <p>策略名称</p>
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// <p>业务资源类型</p>
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// <p>业务资源 ID</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>Kong Route ID</p>
        /// </summary>
        [JsonProperty("RouteId")]
        public string RouteId{ get; set; }

        /// <summary>
        /// <p>业务协议</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>审核方向：request 或 response</p>
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// <p>是否为流式审核</p>
        /// </summary>
        [JsonProperty("Streaming")]
        public bool? Streaming{ get; set; }

        /// <summary>
        /// <p>该审核单元是否标记为最终单元；不是是否命中/是否连接正常结束的判断依据。</p>
        /// </summary>
        [JsonProperty("Final")]
        public bool? Final{ get; set; }

        /// <summary>
        /// <p>归一化后的审核判定，可能为 allow、block、replace、error；不是原始自定义字段的任意值。观察模式仍可记录命中判定。</p>
        /// </summary>
        [JsonProperty("Decision")]
        public string Decision{ get; set; }

        /// <summary>
        /// <p>策略配置动作</p>
        /// </summary>
        [JsonProperty("ConfiguredAction")]
        public string ConfiguredAction{ get; set; }

        /// <summary>
        /// <p>该审核记录的策略处理结果，如 allow、block、replace、error。需与 Decision、ConfiguredAction、ErrorCode 联合分析；记录不等于客户端已成功收到全部响应。</p>
        /// </summary>
        [JsonProperty("EffectiveAction")]
        public string EffectiveAction{ get; set; }

        /// <summary>
        /// <p>内容是否被改写</p>
        /// </summary>
        [JsonProperty("Rewritten")]
        public bool? Rewritten{ get; set; }

        /// <summary>
        /// <p>请求或响应是否被拦截</p>
        /// </summary>
        [JsonProperty("Blocked")]
        public bool? Blocked{ get; set; }

        /// <summary>
        /// <p>本审核记录是否因失败放行发生降级；为 true 时不能认为内容已经审核通过。</p>
        /// </summary>
        [JsonProperty("Downgraded")]
        public bool? Downgraded{ get; set; }

        /// <summary>
        /// <p>审核服务 HTTP 状态码</p>
        /// </summary>
        [JsonProperty("ProviderStatusCode")]
        public long? ProviderStatusCode{ get; set; }

        /// <summary>
        /// <p>该审核调用耗时，单位毫秒，可含小数；不是完整模型请求时长或客户端首字延迟。</p>
        /// </summary>
        [JsonProperty("LatencyMs")]
        public float? LatencyMs{ get; set; }

        /// <summary>
        /// <p>稳定错误码</p>
        /// </summary>
        [JsonProperty("ErrorCode")]
        public string ErrorCode{ get; set; }

        /// <summary>
        /// <p>审核原因或错误摘要</p>
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
            this.SetParamSimple(map, prefix + "Timestamp", this.Timestamp);
            this.SetParamSimple(map, prefix + "GatewayId", this.GatewayId);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "RouteId", this.RouteId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "Streaming", this.Streaming);
            this.SetParamSimple(map, prefix + "Final", this.Final);
            this.SetParamSimple(map, prefix + "Decision", this.Decision);
            this.SetParamSimple(map, prefix + "ConfiguredAction", this.ConfiguredAction);
            this.SetParamSimple(map, prefix + "EffectiveAction", this.EffectiveAction);
            this.SetParamSimple(map, prefix + "Rewritten", this.Rewritten);
            this.SetParamSimple(map, prefix + "Blocked", this.Blocked);
            this.SetParamSimple(map, prefix + "Downgraded", this.Downgraded);
            this.SetParamSimple(map, prefix + "ProviderStatusCode", this.ProviderStatusCode);
            this.SetParamSimple(map, prefix + "LatencyMs", this.LatencyMs);
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}

