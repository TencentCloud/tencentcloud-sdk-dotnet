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

namespace TencentCloud.Chdfs.V20201112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAccessGroupsRequest : AbstractModel
    {
        
        /// <summary>
        /// VPC网络ID
        /// 备注：入参只能指定VpcId和OwnerUin的其中一个
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 资源所属者Uin
        /// </summary>
        [JsonProperty("OwnerUin")]
        public ulong? OwnerUin{ get; set; }

        /// <summary>
        /// 起始权限组ID标记
        /// </summary>
        [JsonProperty("AccessGroupIdMarker")]
        public string AccessGroupIdMarker{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "AccessGroupIdMarker", this.AccessGroupIdMarker);
        }
    }
}

