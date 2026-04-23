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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAutoCalloutTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>应用 ID（必填），可以查看 https://console.cloud.tencent.com/ccc</p>
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// <p>任务起始时间戳，Unix 秒级时间戳</p>
        /// </summary>
        [JsonProperty("NotBefore")]
        public long? NotBefore{ get; set; }

        /// <summary>
        /// <p>被叫号码列表</p>
        /// </summary>
        [JsonProperty("Callees")]
        public string[] Callees{ get; set; }

        /// <summary>
        /// <p>主叫号码列表</p>
        /// </summary>
        [JsonProperty("Callers")]
        public string[] Callers{ get; set; }

        /// <summary>
        /// <p>呼叫使用的 IVR Id，不填时需要填写 AIAgentId</p>
        /// </summary>
        [JsonProperty("IvrId")]
        public ulong? IvrId{ get; set; }

        /// <summary>
        /// <p>任务名</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>任务描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>任务停止时间戳，Unix 秒级时间戳</p>
        /// </summary>
        [JsonProperty("NotAfter")]
        public long? NotAfter{ get; set; }

        /// <summary>
        /// <p>最大尝试次数，1-3 次</p>
        /// </summary>
        [JsonProperty("Tries")]
        public ulong? Tries{ get; set; }

        /// <summary>
        /// <p>自定义变量（仅高级版支持），CalleeAttributes 字段中使用相同变量会覆盖此处</p>
        /// </summary>
        [JsonProperty("Variables")]
        public Variable[] Variables{ get; set; }

        /// <summary>
        /// <p>用户自定义数据，CalleeAttributes 字段中使用 UUI 会覆盖此处</p>
        /// </summary>
        [JsonProperty("UUI")]
        public string UUI{ get; set; }

        /// <summary>
        /// <p>被叫属性</p>
        /// </summary>
        [JsonProperty("CalleeAttributes")]
        public CalleeAttribute[] CalleeAttributes{ get; set; }

        /// <summary>
        /// <p>IANA 时区名称，参考 https://datatracker.ietf.org/doc/html/draft-ietf-netmod-iana-timezones</p>
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// <p>可用时间段</p>
        /// </summary>
        [JsonProperty("AvailableTime")]
        public TimeRange[] AvailableTime{ get; set; }

        /// <summary>
        /// <p>智能体 ID，不填写时需要填写 IvrId</p>
        /// </summary>
        [JsonProperty("AIAgentId")]
        public long? AIAgentId{ get; set; }

        /// <summary>
        /// <p>任务失败重试时间间隔，重试间隔 600秒～86400 秒</p>
        /// </summary>
        [JsonProperty("RetryInterval")]
        public long? RetryInterval{ get; set; }

        /// <summary>
        /// <p>最大振铃时长，达到时长阈值自动挂断。 仅自携号码支持当前参数</p>
        /// </summary>
        [JsonProperty("MaxRingTimeoutSecond")]
        public long? MaxRingTimeoutSecond{ get; set; }

        /// <summary>
        /// <p>根据限定的挂断原因(可选挂断状态码:202,203,204,205,206,207,208,210,212,213,215,216,217,218,219,221,222,234)进行重试，只对使用AIAgentID的任务有效，挂断状态码说明</p><p><a href="https://cloud.tencent.com/document/product/679/123938">详见</a></p>
        /// </summary>
        [JsonProperty("RetryHangupTypes")]
        public string[] RetryHangupTypes{ get; set; }

        /// <summary>
        /// <p>根据限定的话后标签进行重试，只对使用对话模型的AIAgentID任务有效，标签信息可在智能体配置中查询</p>
        /// </summary>
        [JsonProperty("RetryTags")]
        public RetryTagItem[] RetryTags{ get; set; }

        /// <summary>
        /// <p>生效的工作时间配置。建议使用此字段代替AvailableTime 字段，当同时使用时，优先生效AvailableTime。</p>
        /// </summary>
        [JsonProperty("AvailableWorkTimeConfig")]
        public AvailableTimeConfig[] AvailableWorkTimeConfig{ get; set; }

        /// <summary>
        /// <p>触发策略</p>
        /// </summary>
        [JsonProperty("TriggerStrategy")]
        public TriggerStrategyItem[] TriggerStrategy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "NotBefore", this.NotBefore);
            this.SetParamArraySimple(map, prefix + "Callees.", this.Callees);
            this.SetParamArraySimple(map, prefix + "Callers.", this.Callers);
            this.SetParamSimple(map, prefix + "IvrId", this.IvrId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "NotAfter", this.NotAfter);
            this.SetParamSimple(map, prefix + "Tries", this.Tries);
            this.SetParamArrayObj(map, prefix + "Variables.", this.Variables);
            this.SetParamSimple(map, prefix + "UUI", this.UUI);
            this.SetParamArrayObj(map, prefix + "CalleeAttributes.", this.CalleeAttributes);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamArrayObj(map, prefix + "AvailableTime.", this.AvailableTime);
            this.SetParamSimple(map, prefix + "AIAgentId", this.AIAgentId);
            this.SetParamSimple(map, prefix + "RetryInterval", this.RetryInterval);
            this.SetParamSimple(map, prefix + "MaxRingTimeoutSecond", this.MaxRingTimeoutSecond);
            this.SetParamArraySimple(map, prefix + "RetryHangupTypes.", this.RetryHangupTypes);
            this.SetParamArrayObj(map, prefix + "RetryTags.", this.RetryTags);
            this.SetParamArrayObj(map, prefix + "AvailableWorkTimeConfig.", this.AvailableWorkTimeConfig);
            this.SetParamArrayObj(map, prefix + "TriggerStrategy.", this.TriggerStrategy);
        }
    }
}

