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

    public class CreateResourcePackageRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例类型，目前固定传cynosdb-serverless
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// 资源包使用地域chineseMainland-中国内地通用，overseas-港澳台及海外通用
        /// </summary>
        [JsonProperty("PackageRegion")]
        public string PackageRegion{ get; set; }

        /// <summary>
        /// 资源包类型：CCU-计算资源包，DISK-存储资源包
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
        /// 资源包大小，计算资源单位：个；存储资源：GB
        /// </summary>
        [JsonProperty("PackageSpec")]
        public float? PackageSpec{ get; set; }

        /// <summary>
        /// 资源包有效期，单位:天
        /// </summary>
        [JsonProperty("ExpireDay")]
        public long? ExpireDay{ get; set; }

        /// <summary>
        /// 购买资源包个数
        /// </summary>
        [JsonProperty("PackageCount")]
        public long? PackageCount{ get; set; }

        /// <summary>
        /// 资源包名称
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "PackageRegion", this.PackageRegion);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "PackageVersion", this.PackageVersion);
            this.SetParamSimple(map, prefix + "PackageSpec", this.PackageSpec);
            this.SetParamSimple(map, prefix + "ExpireDay", this.ExpireDay);
            this.SetParamSimple(map, prefix + "PackageCount", this.PackageCount);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
        }
    }
}

