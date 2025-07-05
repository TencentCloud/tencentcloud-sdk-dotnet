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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ArrivalInfo : AbstractModel
    {
        
        /// <summary>
        /// 线索id
        /// </summary>
        [JsonProperty("ClueId")]
        public ulong? ClueId{ get; set; }

        /// <summary>
        /// 客户id
        /// </summary>
        [JsonProperty("CustomerId")]
        public ulong? CustomerId{ get; set; }

        /// <summary>
        /// 客户姓名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 客户的手机号
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 是否首次到店，0否，1是
        /// </summary>
        [JsonProperty("FirstArrival")]
        public long? FirstArrival{ get; set; }

        /// <summary>
        /// 到店时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ArrivalTime")]
        public ulong? ArrivalTime{ get; set; }

        /// <summary>
        /// 发生事件
        /// </summary>
        [JsonProperty("EventType")]
        public long? EventType{ get; set; }

        /// <summary>
        /// 发生事件名称
        /// </summary>
        [JsonProperty("EventTypeName")]
        public string EventTypeName{ get; set; }

        /// <summary>
        /// 跟进记录
        /// </summary>
        [JsonProperty("FollowRecord")]
        public string FollowRecord{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClueId", this.ClueId);
            this.SetParamSimple(map, prefix + "CustomerId", this.CustomerId);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "FirstArrival", this.FirstArrival);
            this.SetParamSimple(map, prefix + "ArrivalTime", this.ArrivalTime);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "EventTypeName", this.EventTypeName);
            this.SetParamSimple(map, prefix + "FollowRecord", this.FollowRecord);
        }
    }
}

