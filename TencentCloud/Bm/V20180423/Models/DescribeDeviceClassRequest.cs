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

namespace TencentCloud.Bm.V20180423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDeviceClassRequest : AbstractModel
    {
        
        /// <summary>
        /// 是否仅查询在售标准机型配置信息。取值0：查询所有机型；1：查询在售机型。默认为1
        /// </summary>
        [JsonProperty("OnSale")]
        public ulong? OnSale{ get; set; }

        /// <summary>
        /// 是否返回价格信息。取值0：不返回价格信息，接口返回速度更快；1：返回价格信息。默认为1
        /// </summary>
        [JsonProperty("NeedPriceInfo")]
        public ulong? NeedPriceInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OnSale", this.OnSale);
            this.SetParamSimple(map, prefix + "NeedPriceInfo", this.NeedPriceInfo);
        }
    }
}

