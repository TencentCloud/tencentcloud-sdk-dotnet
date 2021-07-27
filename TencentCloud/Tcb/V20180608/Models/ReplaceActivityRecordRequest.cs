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

    public class ReplaceActivityRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// 活动id
        /// </summary>
        [JsonProperty("ActivityId")]
        public long? ActivityId{ get; set; }

        /// <summary>
        /// 状态码
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 自定义子状态
        /// </summary>
        [JsonProperty("SubStatus")]
        public string SubStatus{ get; set; }

        /// <summary>
        /// 鉴权token
        /// </summary>
        [JsonProperty("ChannelToken")]
        public string ChannelToken{ get; set; }

        /// <summary>
        /// 渠道名，不同渠道对应不同secretKey
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ActivityId", this.ActivityId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SubStatus", this.SubStatus);
            this.SetParamSimple(map, prefix + "ChannelToken", this.ChannelToken);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
        }
    }
}

