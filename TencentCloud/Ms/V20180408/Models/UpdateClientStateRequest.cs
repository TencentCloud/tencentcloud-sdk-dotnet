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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateClientStateRequest : AbstractModel
    {
        
        /// <summary>
        /// Client Id
        /// </summary>
        [JsonProperty("ClientId")]
        public string ClientId{ get; set; }

        /// <summary>
        /// Ip addr
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 内部分组
        /// </summary>
        [JsonProperty("Internal")]
        public long? Internal{ get; set; }

        /// <summary>
        /// Client  Version
        /// </summary>
        [JsonProperty("ServerVersion")]
        public string ServerVersion{ get; set; }

        /// <summary>
        /// 主机
        /// </summary>
        [JsonProperty("Hostname")]
        public string Hostname{ get; set; }

        /// <summary>
        /// 系统
        /// </summary>
        [JsonProperty("Os")]
        public string Os{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientId", this.ClientId);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Internal", this.Internal);
            this.SetParamSimple(map, prefix + "ServerVersion", this.ServerVersion);
            this.SetParamSimple(map, prefix + "Hostname", this.Hostname);
            this.SetParamSimple(map, prefix + "Os", this.Os);
        }
    }
}

