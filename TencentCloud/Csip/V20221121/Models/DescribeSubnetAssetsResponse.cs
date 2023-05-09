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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSubnetAssetsResponse : AbstractModel
    {
        
        /// <summary>
        /// 列表
        /// </summary>
        [JsonProperty("Data")]
        public SubnetAsset[] Data{ get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 地域列表
        /// </summary>
        [JsonProperty("RegionList")]
        public FilterDataObject[] RegionList{ get; set; }

        /// <summary>
        /// vpc列表
        /// </summary>
        [JsonProperty("VpcList")]
        public FilterDataObject[] VpcList{ get; set; }

        /// <summary>
        /// appid列表
        /// </summary>
        [JsonProperty("AppIdList")]
        public FilterDataObject[] AppIdList{ get; set; }

        /// <summary>
        /// 可用区列表
        /// </summary>
        [JsonProperty("ZoneList")]
        public FilterDataObject[] ZoneList{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Data.", this.Data);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "RegionList.", this.RegionList);
            this.SetParamArrayObj(map, prefix + "VpcList.", this.VpcList);
            this.SetParamArrayObj(map, prefix + "AppIdList.", this.AppIdList);
            this.SetParamArrayObj(map, prefix + "ZoneList.", this.ZoneList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

