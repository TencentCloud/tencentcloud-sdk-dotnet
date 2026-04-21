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

    public class CreateCasInput : AbstractModel
    {
        
        /// <summary>
        /// <p>敏捷上云名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>需要接入敏捷上云的IDC的地址</p>
        /// </summary>
        [JsonProperty("IdcAddress")]
        public string IdcAddress{ get; set; }

        /// <summary>
        /// <p>需要接入敏捷上云的IDC的互联网服务提供商类型</p>
        /// </summary>
        [JsonProperty("IdcType")]
        public string IdcType{ get; set; }

        /// <summary>
        /// <p>敏捷上云的带宽，单位为MB</p>
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// <p>联系电话</p>
        /// </summary>
        [JsonProperty("Telephone")]
        public string Telephone{ get; set; }

        /// <summary>
        /// <p>备注信息</p>
        /// </summary>
        [JsonProperty("Remarks")]
        public string Remarks{ get; set; }

        /// <summary>
        /// <p>接入地域</p>
        /// </summary>
        [JsonProperty("ArRegion")]
        public string ArRegion{ get; set; }

        /// <summary>
        /// <p>IDC侧类型，默认为OTHER。枚举值：CLOUD-云，ISP-运营商，OTHER-第三方</p>
        /// </summary>
        [JsonProperty("IdcPointType")]
        public string IdcPointType{ get; set; }

        /// <summary>
        /// <p>运营商链路是否有保护</p>
        /// </summary>
        [JsonProperty("BIapLinkProtected")]
        public bool? BIapLinkProtected{ get; set; }

        /// <summary>
        /// <p>服务类型，SHARE-共享型，EXCLUSIVE-独占型</p>
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IdcAddress", this.IdcAddress);
            this.SetParamSimple(map, prefix + "IdcType", this.IdcType);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "Telephone", this.Telephone);
            this.SetParamSimple(map, prefix + "Remarks", this.Remarks);
            this.SetParamSimple(map, prefix + "ArRegion", this.ArRegion);
            this.SetParamSimple(map, prefix + "IdcPointType", this.IdcPointType);
            this.SetParamSimple(map, prefix + "BIapLinkProtected", this.BIapLinkProtected);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
        }
    }
}

