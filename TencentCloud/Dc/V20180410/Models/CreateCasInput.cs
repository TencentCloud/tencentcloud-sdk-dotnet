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
        /// 敏捷上云名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 需要接入敏捷上云的IDC的地址
        /// </summary>
        [JsonProperty("IdcAddress")]
        public string IdcAddress{ get; set; }

        /// <summary>
        /// 需要接入敏捷上云的IDC的互联网服务提供商类型
        /// </summary>
        [JsonProperty("IdcType")]
        public string IdcType{ get; set; }

        /// <summary>
        /// 敏捷上云的带宽，单位为MB
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonProperty("Telephone")]
        public string Telephone{ get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("Remarks")]
        public string Remarks{ get; set; }

        /// <summary>
        /// 接入地域
        /// </summary>
        [JsonProperty("ArRegion")]
        public string ArRegion{ get; set; }

        /// <summary>
        /// IDC侧类型，默认为OTHER。枚举值：CLOUD-云，ISP-运营商，OTHER-第三方
        /// </summary>
        [JsonProperty("IdcPointType")]
        public string IdcPointType{ get; set; }

        /// <summary>
        /// 运营商链路是否有保护
        /// </summary>
        [JsonProperty("BIapLinkProtected")]
        public bool? BIapLinkProtected{ get; set; }


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
        }
    }
}

