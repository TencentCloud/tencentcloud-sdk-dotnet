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

namespace TencentCloud.Dc.V20180410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PortSpecification : AbstractModel
    {
        
        /// <summary>
        /// 端口名称
        /// </summary>
        [JsonProperty("InternationalName")]
        public string InternationalName{ get; set; }

        /// <summary>
        /// 端口规格（M）
        /// </summary>
        [JsonProperty("Specification")]
        public ulong? Specification{ get; set; }

        /// <summary>
        /// 端口类型：T-电口，X-光口
        /// </summary>
        [JsonProperty("PortType")]
        public string PortType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InternationalName", this.InternationalName);
            this.SetParamSimple(map, prefix + "Specification", this.Specification);
            this.SetParamSimple(map, prefix + "PortType", this.PortType);
        }
    }
}

