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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeMachineRegionsResponse : AbstractModel
    {
        
        /// <summary>
        /// CVM 云服务器地域列表
        /// </summary>
        [JsonProperty("CVM")]
        public RegionInfo[] CVM{ get; set; }

        /// <summary>
        /// BM 黑石机器地域列表
        /// </summary>
        [JsonProperty("BM")]
        public RegionInfo[] BM{ get; set; }

        /// <summary>
        /// LH 轻量应用服务器地域列表
        /// </summary>
        [JsonProperty("LH")]
        public RegionInfo[] LH{ get; set; }

        /// <summary>
        /// ECM 边缘计算服务器地域列表
        /// </summary>
        [JsonProperty("ECM")]
        public RegionInfo[] ECM{ get; set; }

        /// <summary>
        /// Other 混合云地域列表
        /// </summary>
        [JsonProperty("Other")]
        public RegionInfo[] Other{ get; set; }

        /// <summary>
        /// 所有地域列表(包含以上所有地域)
        /// </summary>
        [JsonProperty("ALL")]
        public RegionInfo[] ALL{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "CVM.", this.CVM);
            this.SetParamArrayObj(map, prefix + "BM.", this.BM);
            this.SetParamArrayObj(map, prefix + "LH.", this.LH);
            this.SetParamArrayObj(map, prefix + "ECM.", this.ECM);
            this.SetParamArrayObj(map, prefix + "Other.", this.Other);
            this.SetParamArrayObj(map, prefix + "ALL.", this.ALL);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

