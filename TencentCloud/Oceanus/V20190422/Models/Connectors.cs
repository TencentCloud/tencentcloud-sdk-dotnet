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

namespace TencentCloud.Oceanus.V20190422.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Connectors : AbstractModel
    {
        
        /// <summary>
        /// 连接方式
        /// </summary>
        [JsonProperty("ConnectionMethod")]
        public string ConnectionMethod{ get; set; }

        /// <summary>
        /// 连接器名称
        /// </summary>
        [JsonProperty("Connector")]
        public string Connector{ get; set; }

        /// <summary>
        /// 是否已经被使用
        /// </summary>
        [JsonProperty("Existed")]
        public bool? Existed{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConnectionMethod", this.ConnectionMethod);
            this.SetParamSimple(map, prefix + "Connector", this.Connector);
            this.SetParamSimple(map, prefix + "Existed", this.Existed);
        }
    }
}

