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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyBackupDownloadRestrictionRequest : AbstractModel
    {
        
        /// <summary>
        /// NoLimit 不限制,内外网都可以下载； LimitOnlyIntranet 仅内网可下载； Customize 用户自定义vpc:ip可下载。 只有该值为 Customize 时，才可以设置 LimitVpc 和 LimitIp 。
        /// </summary>
        [JsonProperty("LimitType")]
        public string LimitType{ get; set; }

        /// <summary>
        /// 该参数仅支持 In， 表示 LimitVpc 指定的vpc可以下载。默认为In。
        /// </summary>
        [JsonProperty("VpcComparisonSymbol")]
        public string VpcComparisonSymbol{ get; set; }

        /// <summary>
        /// In: 指定的ip可以下载； NotIn: 指定的ip不可以下载。 默认为In。
        /// </summary>
        [JsonProperty("IpComparisonSymbol")]
        public string IpComparisonSymbol{ get; set; }

        /// <summary>
        /// 限制下载的vpc设置。
        /// </summary>
        [JsonProperty("LimitVpc")]
        public BackupLimitVpcItem[] LimitVpc{ get; set; }

        /// <summary>
        /// 限制下载的ip设置
        /// </summary>
        [JsonProperty("LimitIp")]
        public string[] LimitIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LimitType", this.LimitType);
            this.SetParamSimple(map, prefix + "VpcComparisonSymbol", this.VpcComparisonSymbol);
            this.SetParamSimple(map, prefix + "IpComparisonSymbol", this.IpComparisonSymbol);
            this.SetParamArrayObj(map, prefix + "LimitVpc.", this.LimitVpc);
            this.SetParamArraySimple(map, prefix + "LimitIp.", this.LimitIp);
        }
    }
}

