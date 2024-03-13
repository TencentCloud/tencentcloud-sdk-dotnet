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

    public class PSTNSession : AbstractModel
    {
        
        /// <summary>
        /// 会话 ID
        /// </summary>
        [JsonProperty("SessionID")]
        public string SessionID{ get; set; }

        /// <summary>
        /// 会话临时房间 ID
        /// </summary>
        [JsonProperty("RoomID")]
        public string RoomID{ get; set; }

        /// <summary>
        /// 主叫
        /// </summary>
        [JsonProperty("Caller")]
        public string Caller{ get; set; }

        /// <summary>
        /// 被叫
        /// </summary>
        [JsonProperty("Callee")]
        public string Callee{ get; set; }

        /// <summary>
        /// 开始时间，Unix 时间戳
        /// </summary>
        [JsonProperty("StartTimestamp")]
        public long? StartTimestamp{ get; set; }

        /// <summary>
        /// 振铃时间，Unix 时间戳
        /// </summary>
        [JsonProperty("RingTimestamp")]
        public long? RingTimestamp{ get; set; }

        /// <summary>
        /// 接听时间，Unix 时间戳
        /// </summary>
        [JsonProperty("AcceptTimestamp")]
        public long? AcceptTimestamp{ get; set; }

        /// <summary>
        /// 座席邮箱
        /// </summary>
        [JsonProperty("StaffEmail")]
        public string StaffEmail{ get; set; }

        /// <summary>
        /// 座席工号
        /// </summary>
        [JsonProperty("StaffNumber")]
        public string StaffNumber{ get; set; }

        /// <summary>
        /// 会话状态
        /// ringing 振铃中
        /// seatJoining  等待座席接听
        /// inProgress 进行中
        /// finished 已完成
        /// </summary>
        [JsonProperty("SessionStatus")]
        public string SessionStatus{ get; set; }

        /// <summary>
        /// 会话呼叫方向， 0 呼入 | 1 - 呼出
        /// </summary>
        [JsonProperty("Direction")]
        public long? Direction{ get; set; }

        /// <summary>
        /// 转外线使用的号码（转外线主叫）
        /// </summary>
        [JsonProperty("OutBoundCaller")]
        public string OutBoundCaller{ get; set; }

        /// <summary>
        /// 转外线被叫
        /// </summary>
        [JsonProperty("OutBoundCallee")]
        public string OutBoundCallee{ get; set; }

        /// <summary>
        /// 主叫号码保护ID，开启号码保护映射功能时有效，且Caller字段置空
        /// </summary>
        [JsonProperty("ProtectedCaller")]
        public string ProtectedCaller{ get; set; }

        /// <summary>
        /// 被叫号码保护ID，开启号码保护映射功能时有效，且Callee字段置空
        /// </summary>
        [JsonProperty("ProtectedCallee")]
        public string ProtectedCallee{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionID", this.SessionID);
            this.SetParamSimple(map, prefix + "RoomID", this.RoomID);
            this.SetParamSimple(map, prefix + "Caller", this.Caller);
            this.SetParamSimple(map, prefix + "Callee", this.Callee);
            this.SetParamSimple(map, prefix + "StartTimestamp", this.StartTimestamp);
            this.SetParamSimple(map, prefix + "RingTimestamp", this.RingTimestamp);
            this.SetParamSimple(map, prefix + "AcceptTimestamp", this.AcceptTimestamp);
            this.SetParamSimple(map, prefix + "StaffEmail", this.StaffEmail);
            this.SetParamSimple(map, prefix + "StaffNumber", this.StaffNumber);
            this.SetParamSimple(map, prefix + "SessionStatus", this.SessionStatus);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "OutBoundCaller", this.OutBoundCaller);
            this.SetParamSimple(map, prefix + "OutBoundCallee", this.OutBoundCallee);
            this.SetParamSimple(map, prefix + "ProtectedCaller", this.ProtectedCaller);
            this.SetParamSimple(map, prefix + "ProtectedCallee", this.ProtectedCallee);
        }
    }
}

