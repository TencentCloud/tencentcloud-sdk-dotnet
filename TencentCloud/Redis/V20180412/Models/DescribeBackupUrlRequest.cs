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

    public class DescribeBackupUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 备份 ID，可通过 [DescribeInstanceBackups ](https://cloud.tencent.com/document/product/239/20011)接口返回的参数 RedisBackupSet 获取。
        /// </summary>
        [JsonProperty("BackupId")]
        public string BackupId{ get; set; }

        /// <summary>
        /// 下载备份文件的网络限制类型，如果不配置该参数，则使用用户自定义的配置。
        /// 
        /// - NoLimit：不限制，腾讯云内外网均可以下载备份文件。
        /// -  LimitOnlyIntranet：仅腾讯云自动分配的内网地址可下载备份文件。
        /// - Customize：指用户自定义的私有网络可下载备份文件。
        /// </summary>
        [JsonProperty("LimitType")]
        public string LimitType{ get; set; }

        /// <summary>
        /// 该参数仅支持输入 In，表示自定义的**LimitVpc**可以下载备份文件。
        /// </summary>
        [JsonProperty("VpcComparisonSymbol")]
        public string VpcComparisonSymbol{ get; set; }

        /// <summary>
        /// 标识自定义的 LimitIp 地址是否可下载备份文件。
        /// 
        /// - In: 自定义的 IP 地址可以下载。默认为 In。
        /// - NotIn: 自定义的 IP 不可以下载。
        /// </summary>
        [JsonProperty("IpComparisonSymbol")]
        public string IpComparisonSymbol{ get; set; }

        /// <summary>
        /// 自定义的可下载备份文件的 VPC ID。当参数**LimitType**为**Customize **时，需配置该参数。
        /// </summary>
        [JsonProperty("LimitVpc")]
        public BackupLimitVpcItem[] LimitVpc{ get; set; }

        /// <summary>
        /// 自定义的可下载备份文件的 VPC IP 地址。当参数**LimitType**为**Customize **时，需配置该参数。
        /// </summary>
        [JsonProperty("LimitIp")]
        public string[] LimitIp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "BackupId", this.BackupId);
            this.SetParamSimple(map, prefix + "LimitType", this.LimitType);
            this.SetParamSimple(map, prefix + "VpcComparisonSymbol", this.VpcComparisonSymbol);
            this.SetParamSimple(map, prefix + "IpComparisonSymbol", this.IpComparisonSymbol);
            this.SetParamArrayObj(map, prefix + "LimitVpc.", this.LimitVpc);
            this.SetParamArraySimple(map, prefix + "LimitIp.", this.LimitIp);
        }
    }
}

