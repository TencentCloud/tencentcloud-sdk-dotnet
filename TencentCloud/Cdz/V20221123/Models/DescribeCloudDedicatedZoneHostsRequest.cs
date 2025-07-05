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

namespace TencentCloud.Cdz.V20221123.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCloudDedicatedZoneHostsRequest : AbstractModel
    {
        
        /// <summary>
        /// 专属可用区ID 
        /// </summary>
        [JsonProperty("CloudDedicatedZoneID")]
        public string CloudDedicatedZoneID{ get; set; }

        /// <summary>
        /// 一个或多个Host面的CVM实例信息。最大支持查询100台Host。
        /// </summary>
        [JsonProperty("HostUuids")]
        public string[] HostUuids{ get; set; }

        /// <summary>
        /// 查询一个实例或者多个实例所在的Host上面的CVM实例信息。最大支持查询100台实例。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。关于Offset的更进一步介绍请参考 API 简介中的相关小节。该参数仅与CloudDedicatedZoneID有关，传递了HostUuids和InstanceIds则会失效。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。关于Limit的更进一步介绍请参考 API 简介中的相关小节。该参数仅与CloudDedicatedZoneID有关，传递了HostUuids和InstanceIds则会失效。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CloudDedicatedZoneID", this.CloudDedicatedZoneID);
            this.SetParamArraySimple(map, prefix + "HostUuids.", this.HostUuids);
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}

