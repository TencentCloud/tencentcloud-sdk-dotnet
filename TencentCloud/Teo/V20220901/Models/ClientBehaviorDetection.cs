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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClientBehaviorDetection : AbstractModel
    {
        
        /// <summary>
        /// 工作量证明校验强度。取值有：<li>low：低；</li><li>medium：中；</li><li>high：高。</li>
        /// </summary>
        [JsonProperty("CryptoChallengeIntensity")]
        public string CryptoChallengeIntensity{ get; set; }

        /// <summary>
        /// 客户端行为校验的执行方式。取值有：<li>0ms：立即执行；</li><li>100ms：延迟 100ms 执行；</li><li>200ms：延迟 200ms 执行；</li><li>300ms：延迟 300ms 执行；</li><li>400ms：延迟 400ms 执行；</li><li>500ms：延迟 500ms 执行；</li><li>600ms：延迟 600ms 执行；</li><li>700ms：延迟 700ms 执行；</li><li>800ms：延迟 800ms 执行；</li><li>900ms：延迟 900ms 执行；</li><li>1000ms：延迟 1000ms 执行。</li> 
        /// </summary>
        [JsonProperty("CryptoChallengeDelayBefore")]
        public string CryptoChallengeDelayBefore{ get; set; }

        /// <summary>
        /// 触发阈值统计的时间窗口，取值有：<li>5s：5 秒内；</li><li>10s：10 秒内；</li><li>15s：15 秒内；</li><li>30s：30 秒内；</li><li>60s：60 秒内；</li><li>5m：5 分钟内；</li><li>10m：10 分钟内；</li><li>30m：30 分钟内；</li><li>60m：60 分钟内。</li> 
        /// </summary>
        [JsonProperty("MaxChallengeCountInterval")]
        public string MaxChallengeCountInterval{ get; set; }

        /// <summary>
        /// 触发阈值统计的累计次数，取值范围 1 ~ 100000000。
        /// </summary>
        [JsonProperty("MaxChallengeCountThreshold")]
        public long? MaxChallengeCountThreshold{ get; set; }

        /// <summary>
        /// 客户端未启用 JS（未完成检测）时的执行动作。 SecurityAction 的 Name 取值支持：<li>Deny：拦截，其中 DenyActionParameters 中支持 Stall 配置；</li><li>Monitor：观察；</li><li>Allow：等待后响应，其中 AllowActionParameters 需要 MinDelayTime 和 MaxDelayTime 配置。</li>
        /// </summary>
        [JsonProperty("ChallengeNotFinishedAction")]
        public SecurityAction ChallengeNotFinishedAction{ get; set; }

        /// <summary>
        /// 客户端检测超时的执行动作。 SecurityAction 的 Name 取值支持：<li>Deny：拦截，其中 DenyActionParameters 中支持 Stall 配置；</li><li>Monitor：观察；</li><li>Allow：等待后响应，其中 AllowActionParameters 需要 MinDelayTime 和 MaxDelayTime 配置。</li>
        /// </summary>
        [JsonProperty("ChallengeTimeoutAction")]
        public SecurityAction ChallengeTimeoutAction{ get; set; }

        /// <summary>
        /// Bot 客户端的执行动作。 SecurityAction 的 Name 取值支持：<li>Deny：拦截，其中 DenyActionParameters 中支持 Stall 配置；</li><li>Monitor：观察；</li><li>Allow：等待后响应，其中 AllowActionParameters 需要 MinDelayTime 和 MaxDelayTime 配置。</li>
        /// </summary>
        [JsonProperty("BotClientAction")]
        public SecurityAction BotClientAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CryptoChallengeIntensity", this.CryptoChallengeIntensity);
            this.SetParamSimple(map, prefix + "CryptoChallengeDelayBefore", this.CryptoChallengeDelayBefore);
            this.SetParamSimple(map, prefix + "MaxChallengeCountInterval", this.MaxChallengeCountInterval);
            this.SetParamSimple(map, prefix + "MaxChallengeCountThreshold", this.MaxChallengeCountThreshold);
            this.SetParamObj(map, prefix + "ChallengeNotFinishedAction.", this.ChallengeNotFinishedAction);
            this.SetParamObj(map, prefix + "ChallengeTimeoutAction.", this.ChallengeTimeoutAction);
            this.SetParamObj(map, prefix + "BotClientAction.", this.BotClientAction);
        }
    }
}

