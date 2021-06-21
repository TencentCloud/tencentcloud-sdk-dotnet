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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProtocolBlockConfig : AbstractModel
    {
        
        /// <summary>
        /// TCP封禁，取值[0(封禁关)，1(封禁开)]
        /// </summary>
        [JsonProperty("DropTcp")]
        public long? DropTcp{ get; set; }

        /// <summary>
        /// UDP封禁，取值[0(封禁关)，1(封禁开)]
        /// </summary>
        [JsonProperty("DropUdp")]
        public long? DropUdp{ get; set; }

        /// <summary>
        /// ICMP封禁，取值[0(封禁关)，1(封禁开)]
        /// </summary>
        [JsonProperty("DropIcmp")]
        public long? DropIcmp{ get; set; }

        /// <summary>
        /// 其他协议封禁，取值[0(封禁关)，1(封禁开)]
        /// </summary>
        [JsonProperty("DropOther")]
        public long? DropOther{ get; set; }

        /// <summary>
        /// 异常空连接防护，取值[0(防护关)，1(防护开)]
        /// </summary>
        [JsonProperty("CheckExceptNullConnect")]
        public long? CheckExceptNullConnect{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DropTcp", this.DropTcp);
            this.SetParamSimple(map, prefix + "DropUdp", this.DropUdp);
            this.SetParamSimple(map, prefix + "DropIcmp", this.DropIcmp);
            this.SetParamSimple(map, prefix + "DropOther", this.DropOther);
            this.SetParamSimple(map, prefix + "CheckExceptNullConnect", this.CheckExceptNullConnect);
        }
    }
}

