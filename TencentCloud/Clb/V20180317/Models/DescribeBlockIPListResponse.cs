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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBlockIPListResponse : AbstractModel
    {
        
        /// <summary>
        /// 返回的IP的数量
        /// </summary>
        [JsonProperty("BlockedIPCount")]
        public ulong? BlockedIPCount{ get; set; }

        /// <summary>
        /// 获取用户真实IP的字段
        /// </summary>
        [JsonProperty("ClientIPField")]
        public string ClientIPField{ get; set; }

        /// <summary>
        /// 加入了12360黑名单的IP列表
        /// </summary>
        [JsonProperty("BlockedIPList")]
        public BlockedIP[] BlockedIPList{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BlockedIPCount", this.BlockedIPCount);
            this.SetParamSimple(map, prefix + "ClientIPField", this.ClientIPField);
            this.SetParamArrayObj(map, prefix + "BlockedIPList.", this.BlockedIPList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

