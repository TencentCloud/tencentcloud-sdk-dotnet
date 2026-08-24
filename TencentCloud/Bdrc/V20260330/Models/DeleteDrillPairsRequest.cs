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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteDrillPairsRequest : AbstractModel
    {
        
        /// <summary>
        /// 要删除演练对的类型，其类型枚举跟复制对保持一致。枚举值：DISK / INSTANCE / CFS。
        /// </summary>
        [JsonProperty("DrillPairType")]
        public string DrillPairType{ get; set; }

        /// <summary>
        /// 要删除的演练对列表。长度范围 [1, 10]。
        /// </summary>
        [JsonProperty("DrillPairIds")]
        public string[] DrillPairIds{ get; set; }

        /// <summary>
        /// 要删除的演练组id列表。
        /// </summary>
        [JsonProperty("DrillGroupIds")]
        public string[] DrillGroupIds{ get; set; }

        /// <summary>
        /// 是否一并删除演练CFS/CVM/DISK演练资源。
        /// </summary>
        [JsonProperty("DeleteDrillResource")]
        public bool? DeleteDrillResource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DrillPairType", this.DrillPairType);
            this.SetParamArraySimple(map, prefix + "DrillPairIds.", this.DrillPairIds);
            this.SetParamArraySimple(map, prefix + "DrillGroupIds.", this.DrillGroupIds);
            this.SetParamSimple(map, prefix + "DeleteDrillResource", this.DeleteDrillResource);
        }
    }
}

