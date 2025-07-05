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

    public class CreateAccessGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 权限组名称
        /// </summary>
        [JsonProperty("AccessGroupName")]
        public string AccessGroupName{ get; set; }

        /// <summary>
        /// VPC网络类型（1：CVM）
        /// </summary>
        [JsonProperty("VpcType")]
        public ulong? VpcType{ get; set; }

        /// <summary>
        /// VPC网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 权限组描述，默认为空字符串
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AccessGroupName", this.AccessGroupName);
            this.SetParamSimple(map, prefix + "VpcType", this.VpcType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
        }
    }
}

