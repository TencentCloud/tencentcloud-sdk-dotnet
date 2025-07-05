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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUserActivityInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonProperty("ActivityId")]
        public long? ActivityId{ get; set; }

        /// <summary>
        /// 渠道加密token
        /// </summary>
        [JsonProperty("ChannelToken")]
        public string ChannelToken{ get; set; }

        /// <summary>
        /// 渠道来源，每个来源对应不同secretKey
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// 团id, 1元钱裂变中活动团id不为空时根据团id来查询记录，为空时查询uin最新记录
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
            this.SetParamSimple(map, prefix + "ChannelToken", this.ChannelToken);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
        }
    }
}

