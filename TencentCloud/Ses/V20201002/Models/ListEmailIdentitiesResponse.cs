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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListEmailIdentitiesResponse : AbstractModel
    {
        
        /// <summary>
        /// 发信域名列表
        /// </summary>
        [JsonProperty("EmailIdentities")]
        public EmailIdentity[] EmailIdentities{ get; set; }

        /// <summary>
        /// 最大信誉等级
        /// </summary>
        [JsonProperty("MaxReputationLevel")]
        public ulong? MaxReputationLevel{ get; set; }

        /// <summary>
        /// 单域名最高日发送量
        /// </summary>
        [JsonProperty("MaxDailyQuota")]
        public ulong? MaxDailyQuota{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "EmailIdentities.", this.EmailIdentities);
            this.SetParamSimple(map, prefix + "MaxReputationLevel", this.MaxReputationLevel);
            this.SetParamSimple(map, prefix + "MaxDailyQuota", this.MaxDailyQuota);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

