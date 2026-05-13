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

    public class AllocateEnvRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>分配请求ID，会按这个值做幂等</p><p>入参限制：长度不超过64</p>
        /// </summary>
        [JsonProperty("AllocateId")]
        public string AllocateId{ get; set; }

        /// <summary>
        /// <p>客户平台的应用标识，如果没有则不传</p>
        /// </summary>
        [JsonProperty("ExternalAppId")]
        public string ExternalAppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AllocateId", this.AllocateId);
            this.SetParamSimple(map, prefix + "ExternalAppId", this.ExternalAppId);
        }
    }
}

