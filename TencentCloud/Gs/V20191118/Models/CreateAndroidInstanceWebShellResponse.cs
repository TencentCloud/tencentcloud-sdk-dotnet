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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAndroidInstanceWebShellResponse : AbstractModel
    {
        
        /// <summary>
        /// 鉴权密钥
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 连接地址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 连接区域
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 访问链接，可以直接使用此链接访问 WebShell
        /// </summary>
        [JsonProperty("ConnectUrl")]
        public string ConnectUrl{ get; set; }

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
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ConnectUrl", this.ConnectUrl);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

