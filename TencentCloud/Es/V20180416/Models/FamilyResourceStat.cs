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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FamilyResourceStat : AbstractModel
    {
        
        /// <summary>
        /// <p>机型族，如 &quot;SA5&quot;</p>
        /// </summary>
        [JsonProperty("InsFamily")]
        public string InsFamily{ get; set; }

        /// <summary>
        /// <p>CVM资源是否有货</p>
        /// </summary>
        [JsonProperty("CvmAvailable")]
        public bool? CvmAvailable{ get; set; }

        /// <summary>
        /// <p>系统盘资源是否有货</p>
        /// </summary>
        [JsonProperty("SysDiskAvailable")]
        public bool? SysDiskAvailable{ get; set; }

        /// <summary>
        /// <p>该盘型数据盘资源是否有货</p>
        /// </summary>
        [JsonProperty("DiskAvailable")]
        public bool? DiskAvailable{ get; set; }

        /// <summary>
        /// <p>三类资源是否全部有货(可直接购买)</p>
        /// </summary>
        [JsonProperty("Purchasable")]
        public bool? Purchasable{ get; set; }

        /// <summary>
        /// <p>缺少的资源，取值 CVM/SYSDISK/DISK；为空表示不缺</p>
        /// </summary>
        [JsonProperty("MissingResources")]
        public string[] MissingResources{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InsFamily", this.InsFamily);
            this.SetParamSimple(map, prefix + "CvmAvailable", this.CvmAvailable);
            this.SetParamSimple(map, prefix + "SysDiskAvailable", this.SysDiskAvailable);
            this.SetParamSimple(map, prefix + "DiskAvailable", this.DiskAvailable);
            this.SetParamSimple(map, prefix + "Purchasable", this.Purchasable);
            this.SetParamArraySimple(map, prefix + "MissingResources.", this.MissingResources);
        }
    }
}

