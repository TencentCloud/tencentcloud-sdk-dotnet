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

    public class IPLineInfo : AbstractModel
    {
        
        /// <summary>
        /// IP线路类型，取值[
        /// "bgp"：BGP线路IP
        /// "ctcc"：电信线路IP
        /// "cucc"：联通线路IP
        /// "cmcc"：移动线路IP
        /// "abroad"：境外线路IP
        /// ]
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 线路IP
        /// </summary>
        [JsonProperty("Eip")]
        public string Eip{ get; set; }

        /// <summary>
        /// 实例对应的cname
        /// </summary>
        [JsonProperty("Cname")]
        public string Cname{ get; set; }

        /// <summary>
        /// 资源flag，0：高防包资源，1：高防IP资源，2：非高防资源IP
        /// </summary>
        [JsonProperty("ResourceFlag")]
        public long? ResourceFlag{ get; set; }

        /// <summary>
        /// 域名化资产对应的域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Eip", this.Eip);
            this.SetParamSimple(map, prefix + "Cname", this.Cname);
            this.SetParamSimple(map, prefix + "ResourceFlag", this.ResourceFlag);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
        }
    }
}

