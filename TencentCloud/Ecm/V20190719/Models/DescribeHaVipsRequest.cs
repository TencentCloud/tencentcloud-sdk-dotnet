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

    public class DescribeHaVipsRequest : AbstractModel
    {
        
        /// <summary>
        /// HAVIP数组，HAVIP唯一ID，形如：havip-9o233uri。
        /// </summary>
        [JsonProperty("HaVipIds")]
        public string[] HaVipIds{ get; set; }

        /// <summary>
        /// 过滤条件，参数不支持同时指定HaVipIds和Filters。
        /// havip-id - String - HAVIP唯一ID，形如：havip-9o233uri。
        /// havip-name - String - HAVIP名称。
        /// vpc-id - String - HAVIP所在私有网络ID。
        /// subnet-id - String - HAVIP所在子网ID。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// Ecm 区域，不填代表全部区域。
        /// </summary>
        [JsonProperty("EcmRegion")]
        public string EcmRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "HaVipIds.", this.HaVipIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "EcmRegion", this.EcmRegion);
        }
    }
}

