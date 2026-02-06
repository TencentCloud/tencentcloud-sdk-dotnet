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

    public class CreateProxyGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>通道组所属项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// <p>通道组别名</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>源站地域，参考接口 [https://cloud.tencent.com/document/api/608/36964] 返回参数RegionDetail中的RegionId</p>
        /// </summary>
        [JsonProperty("RealServerRegion")]
        public string RealServerRegion{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// </summary>
        [JsonProperty("TagSet")]
        public TagPair[] TagSet{ get; set; }

        /// <summary>
        /// <p>加速地域列表，包括加速地域名，及该地域对应的带宽和并发配置。</p>
        /// </summary>
        [JsonProperty("AccessRegionSet")]
        public AccessConfiguration[] AccessRegionSet{ get; set; }

        /// <summary>
        /// <p>IP版本，可取值：IPv4、IPv6，默认值IPv4</p>
        /// </summary>
        [JsonProperty("IPAddressVersion")]
        public string IPAddressVersion{ get; set; }

        /// <summary>
        /// <p>通道组套餐类型，可取值：Thunder、Accelerator，默认值Thunder</p>
        /// </summary>
        [JsonProperty("PackageType")]
        public string PackageType{ get; set; }

        /// <summary>
        /// <p>该字段已废弃，当IPAddressVersion为IPv4时，所创建的通道组默认支持Http3.0；当为IPv6，默认不支持Http3.0。</p>
        /// </summary>
        [JsonProperty("Http3Supported")]
        public long? Http3Supported{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "RealServerRegion", this.RealServerRegion);
            this.SetParamArrayObj(map, prefix + "TagSet.", this.TagSet);
            this.SetParamArrayObj(map, prefix + "AccessRegionSet.", this.AccessRegionSet);
            this.SetParamSimple(map, prefix + "IPAddressVersion", this.IPAddressVersion);
            this.SetParamSimple(map, prefix + "PackageType", this.PackageType);
            this.SetParamSimple(map, prefix + "Http3Supported", this.Http3Supported);
        }
    }
}

