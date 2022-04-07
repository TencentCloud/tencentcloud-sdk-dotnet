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

    public class DescribeCCPrecisionPlyListRequest : AbstractModel
    {
        
        /// <summary>
        /// 大禹子产品代号（bgpip-multip：表示高防包；bgpip：表示高防IP）
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// 页起始偏移，取值为(页码-1)*一页条数
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 一页条数
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 指定特定实例Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// IP地址，普通高防IP要传该字段
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 域名，普通高防IP要传该字段
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 协议，普通高防IP要传该字段
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
        }
    }
}

