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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SalePackageSpec : AbstractModel
    {
        
        /// <summary>
        /// 资源包使用地域
        /// </summary>
        [JsonProperty("PackageRegion")]
        public string PackageRegion{ get; set; }

        /// <summary>
        /// 资源包类型
        /// CCU-计算资源包
        /// DISK-存储资源包
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// 资源包版本
        /// base-基础版本，common-通用版本，enterprise-企业版本
        /// </summary>
        [JsonProperty("PackageVersion")]
        public string PackageVersion{ get; set; }

        /// <summary>
        /// 当前版本资源包最小资源数，计算资源单位：个；存储资源：GB
        /// </summary>
        [JsonProperty("MinPackageSpec")]
        public float? MinPackageSpec{ get; set; }

        /// <summary>
        /// 当前版本资源包最大资源数，计算资源单位：个；存储资源：GB
        /// </summary>
        [JsonProperty("MaxPackageSpec")]
        public float? MaxPackageSpec{ get; set; }

        /// <summary>
        /// 资源包有效期，单位:天
        /// </summary>
        [JsonProperty("ExpireDay")]
        public long? ExpireDay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageRegion", this.PackageRegion);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "PackageVersion", this.PackageVersion);
            this.SetParamSimple(map, prefix + "MinPackageSpec", this.MinPackageSpec);
            this.SetParamSimple(map, prefix + "MaxPackageSpec", this.MaxPackageSpec);
            this.SetParamSimple(map, prefix + "ExpireDay", this.ExpireDay);
        }
    }
}

