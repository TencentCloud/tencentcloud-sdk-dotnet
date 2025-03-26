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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAutoCalloutTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用 ID（必填），可以查看 https://console.cloud.tencent.com/ccc
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 任务起始时间戳，Unix 秒级时间戳
        /// </summary>
        [JsonProperty("NotBefore")]
        public long? NotBefore{ get; set; }

        /// <summary>
        /// 被叫号码列表
        /// </summary>
        [JsonProperty("Callees")]
        public string[] Callees{ get; set; }

        /// <summary>
        /// 主叫号码列表
        /// </summary>
        [JsonProperty("Callers")]
        public string[] Callers{ get; set; }

        /// <summary>
        /// 呼叫使用的 IVR Id，不填时需要填写 AIAgentId
        /// </summary>
        [JsonProperty("IvrId")]
        public ulong? IvrId{ get; set; }

        /// <summary>
        /// 任务名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 任务停止时间戳，Unix 秒级时间戳
        /// </summary>
        [JsonProperty("NotAfter")]
        public long? NotAfter{ get; set; }

        /// <summary>
        /// 最大尝试次数，1-3 次
        /// </summary>
        [JsonProperty("Tries")]
        public ulong? Tries{ get; set; }

        /// <summary>
        /// 自定义变量（仅高级版支持）
        /// </summary>
        [JsonProperty("Variables")]
        public Variable[] Variables{ get; set; }

        /// <summary>
        /// UUI
        /// </summary>
        [JsonProperty("UUI")]
        public string UUI{ get; set; }

        /// <summary>
        /// 被叫属性
        /// </summary>
        [JsonProperty("CalleeAttributes")]
        public CalleeAttribute[] CalleeAttributes{ get; set; }

        /// <summary>
        /// IANA 时区名称，参考 https://datatracker.ietf.org/doc/html/draft-ietf-netmod-iana-timezones
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// 可用时间段
        /// </summary>
        [JsonProperty("AvailableTime")]
        public TimeRange[] AvailableTime{ get; set; }

        /// <summary>
        /// 智能体 ID，不填写时需要填写 IvrId
        /// </summary>
        [JsonProperty("AIAgentId")]
        public long? AIAgentId{ get; set; }


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
        }
    }
}

