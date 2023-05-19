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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBoundIPRequest : AbstractModel
    {
        
        /// <summary>
        /// 大禹子产品代号（bgp表示独享包；bgp-multip表示共享包）
        /// </summary>
        [JsonProperty("Business")]
        public string Business{ get; set; }

        /// <summary>
        /// 资源实例ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 绑定到资源实例的IP数组，当资源实例为高防包(独享包)时，数组只允许填1个IP；当没有要绑定的IP时可以为空数组；但是BoundDevList和UnBoundDevList至少有一个不为空；
        /// </summary>
        [JsonProperty("BoundDevList")]
        public BoundIpInfo[] BoundDevList{ get; set; }

        /// <summary>
        /// 与资源实例解绑的IP数组，当资源实例为高防包(独享包)时，数组只允许填1个IP；当没有要解绑的IP时可以为空数组；但是BoundDevList和UnBoundDevList至少有一个不为空；
        /// </summary>
        [JsonProperty("UnBoundDevList")]
        public BoundIpInfo[] UnBoundDevList{ get; set; }

        /// <summary>
        /// 已弃用，不填
        /// </summary>
        [JsonProperty("CopyPolicy")]
        public string CopyPolicy{ get; set; }

        /// <summary>
        /// 如果该资源实例为域名化资产则，该参数必填
        /// </summary>
        [JsonProperty("FilterRegion")]
        public string FilterRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Business", this.Business);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArrayObj(map, prefix + "BoundDevList.", this.BoundDevList);
            this.SetParamArrayObj(map, prefix + "UnBoundDevList.", this.UnBoundDevList);
            this.SetParamSimple(map, prefix + "CopyPolicy", this.CopyPolicy);
            this.SetParamSimple(map, prefix + "FilterRegion", this.FilterRegion);
        }
    }
}

