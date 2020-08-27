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

    public class TelCdrInfo : AbstractModel
    {
        
        /// <summary>
        /// 主叫号码
        /// </summary>
        [JsonProperty("Caller")]
        public string Caller{ get; set; }

        /// <summary>
        /// 被叫号码
        /// </summary>
        [JsonProperty("Callee")]
        public string Callee{ get; set; }

        /// <summary>
        /// 呼叫发起时间戳，Unix 时间戳
        /// </summary>
        [JsonProperty("Time")]
        public long? Time{ get; set; }

        /// <summary>
        /// 呼入呼出方向 0 呼入 1 呼出
        /// </summary>
        [JsonProperty("Direction")]
        public long? Direction{ get; set; }

        /// <summary>
        /// 通话时长
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 录音信息
        /// </summary>
        [JsonProperty("RecordURL")]
        public string RecordURL{ get; set; }

        /// <summary>
        /// 坐席信息
        /// </summary>
        [JsonProperty("SeatUser")]
        public SeatUserInfo SeatUser{ get; set; }

        /// <summary>
        /// 结束状态 0 未知 1 正常通话 2 未接通
        /// </summary>
        [JsonProperty("EndStatus")]
        public long? EndStatus{ get; set; }

        /// <summary>
        /// 技能组
        /// </summary>
        [JsonProperty("SkillGroup")]
        public string SkillGroup{ get; set; }

        /// <summary>
        /// 主叫归属地
        /// </summary>
        [JsonProperty("CallerLocation")]
        public string CallerLocation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Caller", this.Caller);
            this.SetParamSimple(map, prefix + "Callee", this.Callee);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "RecordURL", this.RecordURL);
            this.SetParamObj(map, prefix + "SeatUser.", this.SeatUser);
            this.SetParamSimple(map, prefix + "EndStatus", this.EndStatus);
            this.SetParamSimple(map, prefix + "SkillGroup", this.SkillGroup);
            this.SetParamSimple(map, prefix + "CallerLocation", this.CallerLocation);
        }
    }
}

