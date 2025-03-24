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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IdcUnitInfo : AbstractModel
    {
        
        /// <summary>
        /// 机房管理单元地址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// 机房经理
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonProperty("TelNumber")]
        public string TelNumber{ get; set; }

        /// <summary>
        /// 资产管理员
        /// </summary>
        [JsonProperty("AssetManager")]
        public string AssetManager{ get; set; }

        /// <summary>
        /// 资产管理员电话
        /// </summary>
        [JsonProperty("AssetManagerTelNumber")]
        public string AssetManagerTelNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "TelNumber", this.TelNumber);
            this.SetParamSimple(map, prefix + "AssetManager", this.AssetManager);
            this.SetParamSimple(map, prefix + "AssetManagerTelNumber", this.AssetManagerTelNumber);
        }
    }
}

