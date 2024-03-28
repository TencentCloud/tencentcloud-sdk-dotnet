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

namespace TencentCloud.Cdwpg.V20201230.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateInstanceByApiRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 私有网络
        /// </summary>
        [JsonProperty("UserVPCId")]
        public string UserVPCId{ get; set; }

        /// <summary>
        /// 子网
        /// </summary>
        [JsonProperty("UserSubnetId")]
        public string UserSubnetId{ get; set; }

        /// <summary>
        /// 计费方式
        /// </summary>
        [JsonProperty("ChargeProperties")]
        public ChargeProperties ChargeProperties{ get; set; }

        /// <summary>
        /// 集群密码
        /// </summary>
        [JsonProperty("AdminPassword")]
        public string AdminPassword{ get; set; }

        /// <summary>
        /// 资源信息
        /// </summary>
        [JsonProperty("Resources")]
        public ResourceSpecNew[] Resources{ get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("Tags")]
        public Tag Tags{ get; set; }

        /// <summary>
        /// 版本
        /// </summary>
        [JsonProperty("ProductVersion")]
        public string ProductVersion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "UserVPCId", this.UserVPCId);
            this.SetParamSimple(map, prefix + "UserSubnetId", this.UserSubnetId);
            this.SetParamObj(map, prefix + "ChargeProperties.", this.ChargeProperties);
            this.SetParamSimple(map, prefix + "AdminPassword", this.AdminPassword);
            this.SetParamArrayObj(map, prefix + "Resources.", this.Resources);
            this.SetParamObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ProductVersion", this.ProductVersion);
        }
    }
}

