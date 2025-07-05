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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyNatFwReSelectRequest : AbstractModel
    {
        
        /// <summary>
        /// 模式 1：接入模式；0：新增模式
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// 防火墙实例id
        /// </summary>
        [JsonProperty("CfwInstance")]
        public string CfwInstance{ get; set; }

        /// <summary>
        /// 接入模式重新接入的nat网关列表，其中NatGwList和VpcList只能传递一个。
        /// </summary>
        [JsonProperty("NatGwList")]
        public string[] NatGwList{ get; set; }

        /// <summary>
        /// 新增模式重新接入的vpc列表，其中NatGwList和NatgwList只能传递一个。
        /// </summary>
        [JsonProperty("VpcList")]
        public string[] VpcList{ get; set; }

        /// <summary>
        /// 指定防火墙使用网段信息
        /// </summary>
        [JsonProperty("FwCidrInfo")]
        public FwCidrInfo FwCidrInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "CfwInstance", this.CfwInstance);
            this.SetParamArraySimple(map, prefix + "NatGwList.", this.NatGwList);
            this.SetParamArraySimple(map, prefix + "VpcList.", this.VpcList);
            this.SetParamObj(map, prefix + "FwCidrInfo.", this.FwCidrInfo);
        }
    }
}

