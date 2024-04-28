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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EngineRegionInfo : AbstractModel
    {
        
        /// <summary>
        /// 引擎节点所在地域
        /// </summary>
        [JsonProperty("EngineRegion")]
        public string EngineRegion{ get; set; }

        /// <summary>
        /// 此地域节点分配数量
        /// </summary>
        [JsonProperty("Replica")]
        public long? Replica{ get; set; }

        /// <summary>
        /// 集群网络信息
        /// </summary>
        [JsonProperty("VpcInfos")]
        public VpcInfo[] VpcInfos{ get; set; }

        /// <summary>
        /// Polaris: 是否为主地域
        /// Zookeeper: 是否为Leader固定地域
        /// </summary>
        [JsonProperty("MainRegion")]
        public bool? MainRegion{ get; set; }

        /// <summary>
        /// 引擎规格ID
        /// </summary>
        [JsonProperty("SpecId")]
        public string SpecId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EngineRegion", this.EngineRegion);
            this.SetParamSimple(map, prefix + "Replica", this.Replica);
            this.SetParamArrayObj(map, prefix + "VpcInfos.", this.VpcInfos);
            this.SetParamSimple(map, prefix + "MainRegion", this.MainRegion);
            this.SetParamSimple(map, prefix + "SpecId", this.SpecId);
        }
    }
}

