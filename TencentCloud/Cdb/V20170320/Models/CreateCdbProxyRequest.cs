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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCdbProxyRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 私有网络ID
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// 私有子网ID
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// 节点规格配置
        /// </summary>
        [JsonProperty("ProxyNodeCustom")]
        public ProxyNodeCustom[] ProxyNodeCustom{ get; set; }

        /// <summary>
        /// 安全组
        /// </summary>
        [JsonProperty("SecurityGroup")]
        public string[] SecurityGroup{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 连接池阈值
        /// </summary>
        [JsonProperty("ConnectionPoolLimit")]
        public ulong? ConnectionPoolLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamArrayObj(map, prefix + "ProxyNodeCustom.", this.ProxyNodeCustom);
            this.SetParamArraySimple(map, prefix + "SecurityGroup.", this.SecurityGroup);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "ConnectionPoolLimit", this.ConnectionPoolLimit);
        }
    }
}

