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

namespace TencentCloud.Sms.V20190711.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SmsPackagesStatistics : AbstractModel
    {
        
        /// <summary>
        /// 套餐包创建时间，标准时间，例如：2019-10-08 17:18:37。
        /// </summary>
        [JsonProperty("PackageCreateTime")]
        public string PackageCreateTime{ get; set; }

        /// <summary>
        /// 套餐包创建时间，UNIX 时间戳（单位：秒）。
        /// </summary>
        [JsonProperty("PackageCreateUnixTime")]
        public ulong? PackageCreateUnixTime{ get; set; }

        /// <summary>
        /// 套餐包生效时间，标准时间，例如：2019-10-08 17:18:37。
        /// </summary>
        [JsonProperty("PackageEffectiveTime")]
        public string PackageEffectiveTime{ get; set; }

        /// <summary>
        /// 套餐包生效时间，UNIX 时间戳（单位：秒）。
        /// </summary>
        [JsonProperty("PackageEffectiveUnixTime")]
        public ulong? PackageEffectiveUnixTime{ get; set; }

        /// <summary>
        /// 套餐包过期时间，标准时间，例如：2019-10-08 17:18:37。
        /// </summary>
        [JsonProperty("PackageExpiredTime")]
        public string PackageExpiredTime{ get; set; }

        /// <summary>
        /// 套餐包过期时间，UNIX 时间戳（单位：秒）。
        /// </summary>
        [JsonProperty("PackageExpiredUnixTime")]
        public ulong? PackageExpiredUnixTime{ get; set; }

        /// <summary>
        /// 套餐包条数。
        /// </summary>
        [JsonProperty("AmountOfPackage")]
        public ulong? AmountOfPackage{ get; set; }

        /// <summary>
        /// 0表示赠送套餐包，1表示购买套餐包。
        /// </summary>
        [JsonProperty("TypeOfPackage")]
        public ulong? TypeOfPackage{ get; set; }

        /// <summary>
        /// 套餐包 ID。
        /// </summary>
        [JsonProperty("PackageId")]
        public ulong? PackageId{ get; set; }

        /// <summary>
        /// 当前使用量。
        /// </summary>
        [JsonProperty("CurrentUsage")]
        public ulong? CurrentUsage{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PackageCreateTime", this.PackageCreateTime);
            this.SetParamSimple(map, prefix + "PackageCreateUnixTime", this.PackageCreateUnixTime);
            this.SetParamSimple(map, prefix + "PackageEffectiveTime", this.PackageEffectiveTime);
            this.SetParamSimple(map, prefix + "PackageEffectiveUnixTime", this.PackageEffectiveUnixTime);
            this.SetParamSimple(map, prefix + "PackageExpiredTime", this.PackageExpiredTime);
            this.SetParamSimple(map, prefix + "PackageExpiredUnixTime", this.PackageExpiredUnixTime);
            this.SetParamSimple(map, prefix + "AmountOfPackage", this.AmountOfPackage);
            this.SetParamSimple(map, prefix + "TypeOfPackage", this.TypeOfPackage);
            this.SetParamSimple(map, prefix + "PackageId", this.PackageId);
            this.SetParamSimple(map, prefix + "CurrentUsage", this.CurrentUsage);
        }
    }
}

