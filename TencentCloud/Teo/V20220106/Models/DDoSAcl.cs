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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSAcl : AbstractModel
    {
        
        /// <summary>
        /// 目的端口end
        /// </summary>
        [JsonProperty("DportEnd")]
        public long? DportEnd{ get; set; }

        /// <summary>
        /// 目的端口start
        /// </summary>
        [JsonProperty("DportStart")]
        public long? DportStart{ get; set; }

        /// <summary>
        /// 源端口end
        /// </summary>
        [JsonProperty("SportEnd")]
        public long? SportEnd{ get; set; }

        /// <summary>
        /// 源端口start
        /// </summary>
        [JsonProperty("SportStart")]
        public long? SportStart{ get; set; }

        /// <summary>
        /// 协议 'tcp', 'udp', 'all'
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 动作  drop-丢弃,；transmit-放行； forward-继续防护
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// 是否为系统配置 0-人工配置；1-系统配置
        /// </summary>
        [JsonProperty("Default")]
        public long? Default{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DportEnd", this.DportEnd);
            this.SetParamSimple(map, prefix + "DportStart", this.DportStart);
            this.SetParamSimple(map, prefix + "SportEnd", this.SportEnd);
            this.SetParamSimple(map, prefix + "SportStart", this.SportStart);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "Default", this.Default);
        }
    }
}

