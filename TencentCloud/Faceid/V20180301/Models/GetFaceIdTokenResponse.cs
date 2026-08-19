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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetFaceIdTokenResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>token值。- 有效期 10分钟。- 只能完成1次核身。</p>
        /// </summary>
        [JsonProperty("FaceIdToken")]
        public string FaceIdToken{ get; set; }

        /// <summary>
        /// <p>客户端配置信息，SDK将使用该配置进行后续操作。请将返回值原样传递给客户端SDK。</p>
        /// </summary>
        [JsonProperty("ClientConfig")]
        public string ClientConfig{ get; set; }

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
            this.SetParamSimple(map, prefix + "FaceIdToken", this.FaceIdToken);
            this.SetParamSimple(map, prefix + "ClientConfig", this.ClientConfig);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

