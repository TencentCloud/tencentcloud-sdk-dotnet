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

namespace TencentCloud.Ecm.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModuleCounter : AbstractModel
    {
        
        /// <summary>
        /// 运营商统计信息列表
        /// </summary>
        [JsonProperty("ISPCounterSet")]
        public ISPCounter[] ISPCounterSet{ get; set; }

        /// <summary>
        /// 省份数量
        /// </summary>
        [JsonProperty("ProvinceNum")]
        public long? ProvinceNum{ get; set; }

        /// <summary>
        /// 城市数量
        /// </summary>
        [JsonProperty("CityNum")]
        public long? CityNum{ get; set; }

        /// <summary>
        /// 节点数量
        /// </summary>
        [JsonProperty("NodeNum")]
        public long? NodeNum{ get; set; }

        /// <summary>
        /// 实例数量
        /// </summary>
        [JsonProperty("InstanceNum")]
        public long? InstanceNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ISPCounterSet.", this.ISPCounterSet);
            this.SetParamSimple(map, prefix + "ProvinceNum", this.ProvinceNum);
            this.SetParamSimple(map, prefix + "CityNum", this.CityNum);
            this.SetParamSimple(map, prefix + "NodeNum", this.NodeNum);
            this.SetParamSimple(map, prefix + "InstanceNum", this.InstanceNum);
        }
    }
}

