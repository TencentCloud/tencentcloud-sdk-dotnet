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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DatasourceConnectionLocation : AbstractModel
    {
        
        /// <summary>
        /// 数据连接所在Vpc实例Id，如“vpc-azd4dt1c”。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// Vpc的IPv4 CIDR
        /// </summary>
        [JsonProperty("VpcCidrBlock")]
        public string VpcCidrBlock{ get; set; }

        /// <summary>
        /// 数据连接所在子网的实例Id，如“subnet-bthucmmy”
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// Subnet的IPv4 CIDR
        /// </summary>
        [JsonProperty("SubnetCidrBlock")]
        public string SubnetCidrBlock{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcCidrBlock", this.VpcCidrBlock);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetCidrBlock", this.SubnetCidrBlock);
        }
    }
}

