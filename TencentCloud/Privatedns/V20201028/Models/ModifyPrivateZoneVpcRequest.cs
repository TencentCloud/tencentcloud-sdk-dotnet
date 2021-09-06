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

namespace TencentCloud.Privatedns.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPrivateZoneVpcRequest : AbstractModel
    {
        
        /// <summary>
        /// 私有域ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 私有域关联的全部VPC列表
        /// </summary>
        [JsonProperty("VpcSet")]
        public VpcInfo[] VpcSet{ get; set; }

        /// <summary>
        /// 私有域账号关联的全部VPC列表
        /// </summary>
        [JsonProperty("AccountVpcSet")]
        public AccountVpcInfo[] AccountVpcSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArrayObj(map, prefix + "VpcSet.", this.VpcSet);
            this.SetParamArrayObj(map, prefix + "AccountVpcSet.", this.AccountVpcSet);
        }
    }
}

