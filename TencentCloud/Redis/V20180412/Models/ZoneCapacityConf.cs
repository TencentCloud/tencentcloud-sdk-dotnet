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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneCapacityConf : AbstractModel
    {
        
        /// <summary>
        /// 可用区ID：如ap-guangzhou-3
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 可用区名称
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// 可用区是否售罄
        /// </summary>
        [JsonProperty("IsSaleout")]
        public bool? IsSaleout{ get; set; }

        /// <summary>
        /// 是否为默认可用区
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }

        /// <summary>
        /// 网络类型：basenet -- 基础网络；vpcnet -- VPC网络
        /// </summary>
        [JsonProperty("NetWorkType")]
        public string[] NetWorkType{ get; set; }

        /// <summary>
        /// 可用区内产品规格等信息
        /// </summary>
        [JsonProperty("ProductSet")]
        public ProductConf[] ProductSet{ get; set; }

        /// <summary>
        /// 可用区ID：如100003
        /// </summary>
        [JsonProperty("OldZoneId")]
        public long? OldZoneId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "IsSaleout", this.IsSaleout);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamArraySimple(map, prefix + "NetWorkType.", this.NetWorkType);
            this.SetParamArrayObj(map, prefix + "ProductSet.", this.ProductSet);
            this.SetParamSimple(map, prefix + "OldZoneId", this.OldZoneId);
        }
    }
}

