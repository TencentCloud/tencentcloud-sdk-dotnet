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

namespace TencentCloud.Cdc.V20201214.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VpngwBandwidthData : AbstractModel
    {
        
        /// <summary>
        /// 出带宽流量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OutBandwidth")]
        public OutBandwidth OutBandwidth{ get; set; }

        /// <summary>
        /// 入带宽流量
        /// </summary>
        [JsonProperty("InBandwidth")]
        public InBandwidth InBandwidth{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "OutBandwidth.", this.OutBandwidth);
            this.SetParamObj(map, prefix + "InBandwidth.", this.InBandwidth);
        }
    }
}

