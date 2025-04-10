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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudNativeAPIGatewayRateLimitDetail : AbstractModel
    {
        
        /// <summary>
        /// 插件启用状态
        /// </summary>
        [JsonProperty("Enabled")]
        public bool? Enabled{ get; set; }

        /// <summary>
        /// qps阈值
        /// </summary>
        [JsonProperty("QpsThresholds")]
        public QpsThreshold[] QpsThresholds{ get; set; }

        /// <summary>
        /// 需要进行流量控制的请求路径
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 需要进行流量控制的请求头Key
        /// </summary>
        [JsonProperty("Header")]
        public string Header{ get; set; }

        /// <summary>
        /// 限流依据
        /// ip service consumer credential path header
        /// </summary>
        [JsonProperty("LimitBy")]
        public string LimitBy{ get; set; }

        /// <summary>
        /// 外部redis配置
        /// </summary>
        [JsonProperty("ExternalRedis")]
        public ExternalRedis ExternalRedis{ get; set; }

        /// <summary>
        /// 计数器策略 
        /// local 单机
        /// redis  默认redis
        /// external_redis 外部redis
        /// </summary>
        [JsonProperty("Policy")]
        public string Policy{ get; set; }

        /// <summary>
        /// 响应配置，响应策略为text
        /// </summary>
        [JsonProperty("RateLimitResponse")]
        public RateLimitResponse RateLimitResponse{ get; set; }

        /// <summary>
        /// 请求转发地址
        /// </summary>
        [JsonProperty("RateLimitResponseUrl")]
        public string RateLimitResponseUrl{ get; set; }

        /// <summary>
        /// 响应策略
        /// url请求转发
        /// text 响应配置
        /// default 直接返回
        /// </summary>
        [JsonProperty("ResponseType")]
        public string ResponseType{ get; set; }

        /// <summary>
        /// 是否隐藏限流客户端响应头
        /// </summary>
        [JsonProperty("HideClientHeaders")]
        public bool? HideClientHeaders{ get; set; }

        /// <summary>
        /// 排队时间
        /// </summary>
        [JsonProperty("LineUpTime")]
        public long? LineUpTime{ get; set; }

        /// <summary>
        /// 是否开启请求排队
        /// </summary>
        [JsonProperty("IsDelay")]
        public bool? IsDelay{ get; set; }

        /// <summary>
        /// 基础限流
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BasicLimitQpsThresholds")]
        public QpsThreshold[] BasicLimitQpsThresholds{ get; set; }

        /// <summary>
        /// 参数限流的规则
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LimitRules")]
        public LimitRule[] LimitRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enabled", this.Enabled);
            this.SetParamArrayObj(map, prefix + "QpsThresholds.", this.QpsThresholds);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Header", this.Header);
            this.SetParamSimple(map, prefix + "LimitBy", this.LimitBy);
            this.SetParamObj(map, prefix + "ExternalRedis.", this.ExternalRedis);
            this.SetParamSimple(map, prefix + "Policy", this.Policy);
            this.SetParamObj(map, prefix + "RateLimitResponse.", this.RateLimitResponse);
            this.SetParamSimple(map, prefix + "RateLimitResponseUrl", this.RateLimitResponseUrl);
            this.SetParamSimple(map, prefix + "ResponseType", this.ResponseType);
            this.SetParamSimple(map, prefix + "HideClientHeaders", this.HideClientHeaders);
            this.SetParamSimple(map, prefix + "LineUpTime", this.LineUpTime);
            this.SetParamSimple(map, prefix + "IsDelay", this.IsDelay);
            this.SetParamArrayObj(map, prefix + "BasicLimitQpsThresholds.", this.BasicLimitQpsThresholds);
            this.SetParamArrayObj(map, prefix + "LimitRules.", this.LimitRules);
        }
    }
}

