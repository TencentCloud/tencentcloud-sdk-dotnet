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

    public class AssumeRoleForAllocatedEnvResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>SecretId</p>
        /// </summary>
        [JsonProperty("SecretId")]
        public string SecretId{ get; set; }

        /// <summary>
        /// <p>SecretKey</p>
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// <p>Token值</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Token")]
        public string Token{ get; set; }

        /// <summary>
        /// <p>过期时间戳</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpiredTime")]
        public long? ExpiredTime{ get; set; }

        /// <summary>
        /// <p>是否从缓存中加载。标明该值是否实时从sts服务获取，还是从缓存中获取。调用方可不关心</p>
        /// </summary>
        [JsonProperty("IsCache")]
        public bool? IsCache{ get; set; }

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
            this.SetParamSimple(map, prefix + "SecretId", this.SecretId);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamSimple(map, prefix + "ExpiredTime", this.ExpiredTime);
            this.SetParamSimple(map, prefix + "IsCache", this.IsCache);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

