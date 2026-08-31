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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAgentRecordTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>直播间URL</p>
        /// </summary>
        [JsonProperty("LiveRoomUrl")]
        public string LiveRoomUrl{ get; set; }

        /// <summary>
        /// <p>最长录制时长</p><p>单位：分</p><p>最长支持720分</p>
        /// </summary>
        [JsonProperty("MaxDurationMinutes")]
        public long? MaxDurationMinutes{ get; set; }

        /// <summary>
        /// <p>文件结果指定存储Cos桶信息。 注意：需开通Cos，创建并授权MPS_QcsRole角色。</p>
        /// </summary>
        [JsonProperty("StoreCosParam")]
        public AgentStoreCosParam StoreCosParam{ get; set; }

        /// <summary>
        /// <p>定时录制开始时刻</p><p>参数格式：2026-07-01T15:31:32+08:00</p><p>空表示提交后立即开始录制；非空表示从该时刻开始录制</p>
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// <p>中断策略</p><p>枚举值：</p><ul><li>STOP_ON_INTERRUPT： 直播流中断后立即结束录制</li><li>CONTINUE_UNTIL_END： 直播流中断时忽略中断，继续录制直到任务结束时间</li></ul><p>默认值：STOP_ON_INTERRUPT</p>
        /// </summary>
        [JsonProperty("InterruptPolicy")]
        public string InterruptPolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LiveRoomUrl", this.LiveRoomUrl);
            this.SetParamSimple(map, prefix + "MaxDurationMinutes", this.MaxDurationMinutes);
            this.SetParamObj(map, prefix + "StoreCosParam.", this.StoreCosParam);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "InterruptPolicy", this.InterruptPolicy);
        }
    }
}

