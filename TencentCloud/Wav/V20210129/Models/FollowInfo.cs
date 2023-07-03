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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FollowInfo : AbstractModel
    {
        
        /// <summary>
        /// 线索id
        /// </summary>
        [JsonProperty("ClueId")]
        public ulong? ClueId{ get; set; }

        /// <summary>
        /// 客户档案id
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
        /// 是否逾期
        /// </summary>
        [JsonProperty("IsOverdue")]
        public long? IsOverdue{ get; set; }

        /// <summary>
        /// 逾期时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OverdueTime")]
        public ulong? OverdueTime{ get; set; }

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
        /// 跟进方式
        /// </summary>
        [JsonProperty("FollowWayType")]
        public string FollowWayType{ get; set; }

        /// <summary>
        /// 跟进方式名称
        /// </summary>
        [JsonProperty("FollowWayName")]
        public string FollowWayName{ get; set; }

        /// <summary>
        /// 本次跟进时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FollowTime")]
        public ulong? FollowTime{ get; set; }

        /// <summary>
        /// 下次跟进时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NextFollowTime")]
        public ulong? NextFollowTime{ get; set; }

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
            this.SetParamSimple(map, prefix + "IsOverdue", this.IsOverdue);
            this.SetParamSimple(map, prefix + "OverdueTime", this.OverdueTime);
            this.SetParamSimple(map, prefix + "EventType", this.EventType);
            this.SetParamSimple(map, prefix + "EventTypeName", this.EventTypeName);
            this.SetParamSimple(map, prefix + "FollowWayType", this.FollowWayType);
            this.SetParamSimple(map, prefix + "FollowWayName", this.FollowWayName);
            this.SetParamSimple(map, prefix + "FollowTime", this.FollowTime);
            this.SetParamSimple(map, prefix + "NextFollowTime", this.NextFollowTime);
            this.SetParamSimple(map, prefix + "FollowRecord", this.FollowRecord);
        }
    }
}

