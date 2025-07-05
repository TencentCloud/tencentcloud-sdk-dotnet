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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VolumeNFS : AbstractModel
    {
        
        /// <summary>
        /// 服务地址
        /// </summary>
        [JsonProperty("Server")]
        public string Server{ get; set; }

        /// <summary>
        /// 对应服务器路径
        /// </summary>
        [JsonProperty("ServerPath")]
        public string ServerPath{ get; set; }

        /// <summary>
        /// 对应本地路径
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Server", this.Server);
            this.SetParamSimple(map, prefix + "ServerPath", this.ServerPath);
            this.SetParamSimple(map, prefix + "Path", this.Path);
        }
    }
}

