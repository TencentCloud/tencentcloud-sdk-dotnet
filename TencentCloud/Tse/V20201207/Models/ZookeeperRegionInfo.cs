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

    public class ZookeeperRegionInfo : AbstractModel
    {
        
        /// <summary>
        /// 部署架构信息
        /// 
        /// - SingleRegion: 普通单地域
        /// - MultiRegion: 普通多地域场景
        /// - MasterSlave: 两地域，主备地域场景
        /// </summary>
        [JsonProperty("DeployMode")]
        public string DeployMode{ get; set; }

        /// <summary>
        /// 主地域的额外信息
        /// </summary>
        [JsonProperty("MainRegion")]
        public ZookeeperRegionMyIdInfo MainRegion{ get; set; }

        /// <summary>
        /// 其他地域的额外信息
        /// </summary>
        [JsonProperty("OtherRegions")]
        public ZookeeperRegionMyIdInfo[] OtherRegions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeployMode", this.DeployMode);
            this.SetParamObj(map, prefix + "MainRegion.", this.MainRegion);
            this.SetParamArrayObj(map, prefix + "OtherRegions.", this.OtherRegions);
        }
    }
}

