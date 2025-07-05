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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRegionAndPriceRequest : AbstractModel
    {
        
        /// <summary>
        /// IP版本，可取值：IPv4、IPv6，默认值IPv4
        /// </summary>
        [JsonProperty("IPAddressVersion")]
        public string IPAddressVersion{ get; set; }

        /// <summary>
        /// 通道套餐类型，Thunder表示标准通道组，Accelerator表示游戏加速器通道，CrossBorder表示跨境通道。
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IPAddressVersion", this.IPAddressVersion);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
        }
    }
}

