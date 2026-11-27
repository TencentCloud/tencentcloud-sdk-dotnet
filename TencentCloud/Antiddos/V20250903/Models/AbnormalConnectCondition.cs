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

    public class AbnormalConnectCondition : AbstractModel
    {
        
        /// <summary>
        /// <p>SYN占比阈值（百分比）， 0为不检查。 同一连接中，SYN 包占比超过配置占比时，将被视为异常连接处置。</p><p>取值范围：[0, 100]</p>
        /// </summary>
        [JsonProperty("SynRatioThreshold")]
        public ulong? SynRatioThreshold{ get; set; }

        /// <summary>
        /// <p>SYN占比阈值（百分比）， 0为不检查。 同一连接中，SYN 包占比超过配置占比时，将被视为异常连接处置。</p><p>取值范围：[0, 65535]</p>
        /// </summary>
        [JsonProperty("SynCountThreshold")]
        public ulong? SynCountThreshold{ get; set; }

        /// <summary>
        /// <p>连接超时（秒），0为不检查。 连接超过配置时间内未收到数据时，将被视为异常连接处置。</p><p>取值范围：[0, 65535]</p>
        /// </summary>
        [JsonProperty("ConnectTimeout")]
        public ulong? ConnectTimeout{ get; set; }

        /// <summary>
        /// <p>是否开启空连接防护。 同一客户端对应了较大数量的空连接时，将被视为异常连接处置。</p><p>枚举值：</p><ul><li>on： 开启</li><li>off： 关闭</li></ul>
        /// </summary>
        [JsonProperty("EmptyConnection")]
        public string EmptyConnection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SynRatioThreshold", this.SynRatioThreshold);
            this.SetParamSimple(map, prefix + "SynCountThreshold", this.SynCountThreshold);
            this.SetParamSimple(map, prefix + "ConnectTimeout", this.ConnectTimeout);
            this.SetParamSimple(map, prefix + "EmptyConnection", this.EmptyConnection);
        }
    }
}

