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

namespace TencentCloud.Antiddos.V20250903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConnectionProtectionConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>源 IP 每秒新建连接数限制，为 0 为不限制（关闭），大于 0 开启限制。命中后限制新建连接。</p><p>取值范围：[0, 4294967295]</p>
        /// </summary>
        [JsonProperty("SourceIPNewConnectionLimit")]
        public ulong? SourceIPNewConnectionLimit{ get; set; }

        /// <summary>
        /// <p>源 IP 并发连接数限制，为 0 不限制（关闭），大于 0 开启限制。命中后限制新建连接。</p><p>取值范围：[0, 4294967295]</p>
        /// </summary>
        [JsonProperty("SourceIPConcurrentConnectionLimit")]
        public ulong? SourceIPConcurrentConnectionLimit{ get; set; }

        /// <summary>
        /// <p>目的 IP 每秒新建连接数限制，为 0 不限制（关闭），大于 0 开启限制。命中后限制新建连接。</p><p>取值范围：[0, 4294967295]</p>
        /// </summary>
        [JsonProperty("DestinationIPNewConnectionLimit")]
        public ulong? DestinationIPNewConnectionLimit{ get; set; }

        /// <summary>
        /// <p>目的 IP 并发连接数限制，为 0 不限制（关闭）， 大于 0 开启限制。命中后限制新建连接。</p><p>取值范围：[0, 4294967295]</p>
        /// </summary>
        [JsonProperty("DestinationIPConcurrentConnectionLimit")]
        public ulong? DestinationIPConcurrentConnectionLimit{ get; set; }

        /// <summary>
        /// <p>源 IP 异常连接限制。</p>
        /// </summary>
        [JsonProperty("AbnormalConnectionLimit")]
        public AbnormalConnectionLimit AbnormalConnectionLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceIPNewConnectionLimit", this.SourceIPNewConnectionLimit);
            this.SetParamSimple(map, prefix + "SourceIPConcurrentConnectionLimit", this.SourceIPConcurrentConnectionLimit);
            this.SetParamSimple(map, prefix + "DestinationIPNewConnectionLimit", this.DestinationIPNewConnectionLimit);
            this.SetParamSimple(map, prefix + "DestinationIPConcurrentConnectionLimit", this.DestinationIPConcurrentConnectionLimit);
            this.SetParamObj(map, prefix + "AbnormalConnectionLimit.", this.AbnormalConnectionLimit);
        }
    }
}

