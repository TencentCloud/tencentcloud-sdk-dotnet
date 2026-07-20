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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateNatFwInstanceWithDomainRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>防火墙实例名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>带宽</p>
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }

        /// <summary>
        /// <p>模式 1：接入模式；0：新增模式</p>
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// <p>新增模式传递参数，其中NewModeItems和NatgwList至少传递一种。</p>
        /// </summary>
        [JsonProperty("NewModeItems")]
        public NewModeItems NewModeItems{ get; set; }

        /// <summary>
        /// <p>接入模式接入的nat网关列表，其中NewModeItems和NatgwList至少传递一种。</p>
        /// </summary>
        [JsonProperty("NatGwList")]
        public string[] NatGwList{ get; set; }

        /// <summary>
        /// <p>主可用区，为空则选择默认可用区</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>备可用区，为空则选择默认可用区</p>
        /// </summary>
        [JsonProperty("ZoneBak")]
        public string ZoneBak{ get; set; }

        /// <summary>
        /// <p>异地灾备 1：使用异地灾备；0：不使用异地灾备；为空则默认不使用异地灾备</p>
        /// </summary>
        [JsonProperty("CrossAZone")]
        public long? CrossAZone{ get; set; }

        /// <summary>
        /// <p>0不创建域名,1创建域名</p>
        /// </summary>
        [JsonProperty("IsCreateDomain")]
        public long? IsCreateDomain{ get; set; }

        /// <summary>
        /// <p>如果要创建域名则必填</p>
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// <p>指定防火墙使用网段信息</p>
        /// </summary>
        [JsonProperty("FwCidrInfo")]
        public FwCidrInfo FwCidrInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamObj(map, prefix + "NewModeItems.", this.NewModeItems);
            this.SetParamArraySimple(map, prefix + "NatGwList.", this.NatGwList);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ZoneBak", this.ZoneBak);
            this.SetParamSimple(map, prefix + "CrossAZone", this.CrossAZone);
            this.SetParamSimple(map, prefix + "IsCreateDomain", this.IsCreateDomain);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamObj(map, prefix + "FwCidrInfo.", this.FwCidrInfo);
        }
    }
}

