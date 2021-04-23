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

namespace TencentCloud.Iotvideo.V20191126.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateUsrTokenRequest : AbstractModel
    {
        
        /// <summary>
        /// 终端用户在IoT Video上的唯一标识ID
        /// </summary>
        [JsonProperty("AccessId")]
        public string AccessId{ get; set; }

        /// <summary>
        /// 终端唯一ID，用于区分同一个用户的多个终端
        /// </summary>
        [JsonProperty("UniqueId")]
        public string UniqueId{ get; set; }

        /// <summary>
        /// Token的TTL(time to alive)分钟数
        /// </summary>
        [JsonProperty("TtlMinutes")]
        public ulong? TtlMinutes{ get; set; }

        /// <summary>
        /// 旧的AccessToken。续期Token时，此参数为必须。
        /// </summary>
        [JsonProperty("OldAccessToken")]
        public string OldAccessToken{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessId", this.AccessId);
            this.SetParamSimple(map, prefix + "UniqueId", this.UniqueId);
            this.SetParamSimple(map, prefix + "TtlMinutes", this.TtlMinutes);
            this.SetParamSimple(map, prefix + "OldAccessToken", this.OldAccessToken);
        }
    }
}

