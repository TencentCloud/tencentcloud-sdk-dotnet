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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetWork : AbstractModel
    {
        
        /// <summary>
        /// 服务clbip
        /// </summary>
        [JsonProperty("ClbIp")]
        public string ClbIp{ get; set; }

        /// <summary>
        /// 服务clbPort
        /// </summary>
        [JsonProperty("ClbPort")]
        public string ClbPort{ get; set; }

        /// <summary>
        /// vpc实例id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// vpc网段
        /// </summary>
        [JsonProperty("VpcCidrBlock")]
        public string VpcCidrBlock{ get; set; }

        /// <summary>
        /// 子网实例id
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 子网网段
        /// </summary>
        [JsonProperty("SubnetCidrBlock")]
        public string SubnetCidrBlock{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClbIp", this.ClbIp);
            this.SetParamSimple(map, prefix + "ClbPort", this.ClbPort);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcCidrBlock", this.VpcCidrBlock);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetCidrBlock", this.SubnetCidrBlock);
        }
    }
}

