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

namespace TencentCloud.Iotvideo.V20191126.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateUsrTokenResponse : AbstractModel
    {
        
        /// <summary>
        /// 终端用户在IoT Video上的唯一标识ID
        /// </summary>
        [JsonProperty("AccessId")]
        public string AccessId{ get; set; }

        /// <summary>
        /// IoT Video平台的AccessToken
        /// </summary>
        [JsonProperty("AccessToken")]
        public string AccessToken{ get; set; }

        /// <summary>
        /// Token的过期时间，单位秒(UTC时间)
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// 终端ID
        /// </summary>
        [JsonProperty("TerminalId")]
        public string TerminalId{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessId", this.AccessId);
            this.SetParamSimple(map, prefix + "AccessToken", this.AccessToken);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "TerminalId", this.TerminalId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

