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

    public class DescribeActivityRecordRequest : AbstractModel
    {
        
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
        /// 活动id列表
        /// </summary>
        [JsonProperty("ActivityIdList")]
        public long?[] ActivityIdList{ get; set; }

        /// <summary>
        /// 过滤状态码，已废弃
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 状态码过滤数组，空数组时不过滤
        /// </summary>
        [JsonProperty("Statuses")]
        public long?[] Statuses{ get; set; }

        /// <summary>
        /// 根据是否软删除进行过滤，[0]未删除, [1] 删除，不传不过滤
        /// </summary>
        [JsonProperty("IsDeletedList")]
        public long?[] IsDeletedList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelToken", this.ChannelToken);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamArraySimple(map, prefix + "ActivityIdList.", this.ActivityIdList);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "Statuses.", this.Statuses);
            this.SetParamArraySimple(map, prefix + "IsDeletedList.", this.IsDeletedList);
        }
    }
}

