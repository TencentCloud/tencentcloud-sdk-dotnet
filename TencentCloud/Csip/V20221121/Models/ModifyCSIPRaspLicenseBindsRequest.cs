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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyCSIPRaspLicenseBindsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>资源ID（指定绑定到哪个订单）</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>授权类型。枚举值：rasp(RASP) / enterprise_hp(旗舰版)。为空默认 rasp</p>
        /// </summary>
        [JsonProperty("LicenseType")]
        public string LicenseType{ get; set; }

        /// <summary>
        /// <p>资产类型。枚举值：host(主机) / cluster(容器节点) / eks(EKS超级节点)。为空默认 host</p>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// <p>待绑定的实例ID列表（IsAll=true时可不传）</p>
        /// </summary>
        [JsonProperty("InstanceIDs")]
        public string[] InstanceIDs{ get; set; }

        /// <summary>
        /// <p>是否绑定全部未绑定机器（true时自动算差集）</p>
        /// </summary>
        [JsonProperty("IsAll")]
        public bool? IsAll{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "LicenseType", this.LicenseType);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamArraySimple(map, prefix + "InstanceIDs.", this.InstanceIDs);
            this.SetParamSimple(map, prefix + "IsAll", this.IsAll);
        }
    }
}

