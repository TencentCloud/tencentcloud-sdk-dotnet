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

    public class DescribeAgentCruiseDialingCampaignResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 座席账号
        /// </summary>
        [JsonProperty("Agent")]
        public string Agent{ get; set; }

        /// <summary>
        /// 单轮并发呼叫量 1-20
        /// </summary>
        [JsonProperty("ConcurrencyNumber")]
        public long? ConcurrencyNumber{ get; set; }

        /// <summary>
        /// 任务启动时间，Unix 时间戳，到此时间后会自动启动任务
        /// </summary>
        [JsonProperty("StartTime")]
        public long? StartTime{ get; set; }

        /// <summary>
        /// 任务结束时间，Unix 时间戳，到此时间后会自动终止任务
        /// </summary>
        [JsonProperty("EndTime")]
        public long? EndTime{ get; set; }

        /// <summary>
        /// 被叫呼叫顺序 0 随机 1 顺序
        /// </summary>
        [JsonProperty("CallOrder")]
        public long? CallOrder{ get; set; }

        /// <summary>
        /// 调用方自定义数据，最大长度 1024
        /// </summary>
        [JsonProperty("UUI")]
        public string UUI{ get; set; }

        /// <summary>
        /// 任务状态 0 未启动 1 运行中 2 已完成 3 已终止
        /// </summary>
        [JsonProperty("State")]
        public long? State{ get; set; }

        /// <summary>
        /// 被叫总数
        /// </summary>
        [JsonProperty("TotalCalleeCount")]
        public long? TotalCalleeCount{ get; set; }

        /// <summary>
        /// 已呼被叫数
        /// </summary>
        [JsonProperty("CalledCalleeCount")]
        public long? CalledCalleeCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Agent", this.Agent);
            this.SetParamSimple(map, prefix + "ConcurrencyNumber", this.ConcurrencyNumber);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "CallOrder", this.CallOrder);
            this.SetParamSimple(map, prefix + "UUI", this.UUI);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "TotalCalleeCount", this.TotalCalleeCount);
            this.SetParamSimple(map, prefix + "CalledCalleeCount", this.CalledCalleeCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

