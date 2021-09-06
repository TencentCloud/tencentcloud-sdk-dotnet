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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUserActivityInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 自定义标记，1元钱裂变需求中即代指`团id`
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// 自定义备注，1元钱裂变需求中返回`团列表`，uin列表通过","拼接
        /// </summary>
        [JsonProperty("Notes")]
        public string Notes{ get; set; }

        /// <summary>
        /// 活动剩余时间，单位为s.1元钱裂变需求中即为 time(活动过期时间)-Now()), 过期后为0，即返回必为自然数
        /// </summary>
        [JsonProperty("ActivityTimeLeft")]
        public long? ActivityTimeLeft{ get; set; }

        /// <summary>
        /// 拼团剩余时间，单位为s.1元钱裂变需求中即为time(成团时间)+24H-Now()，过期后为0，即返回必为自然数
        /// </summary>
        [JsonProperty("GroupTimeLeft")]
        public long? GroupTimeLeft{ get; set; }

        /// <summary>
        /// 昵称列表,通过","拼接， 1元钱裂变活动中与Notes中uin一一对应
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NickNameList")]
        public string NickNameList{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "Notes", this.Notes);
            this.SetParamSimple(map, prefix + "ActivityTimeLeft", this.ActivityTimeLeft);
            this.SetParamSimple(map, prefix + "GroupTimeLeft", this.GroupTimeLeft);
            this.SetParamSimple(map, prefix + "NickNameList", this.NickNameList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

