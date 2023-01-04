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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FwCidrInfo : AbstractModel
    {
        
        /// <summary>
        /// 防火墙使用的网段类型，值VpcSelf/Assis/Custom分别代表自有网段优先/扩展网段优先/自定义
        /// </summary>
        [JsonProperty("FwCidrType")]
        public string FwCidrType{ get; set; }

        /// <summary>
        /// 为每个vpc指定防火墙的网段
        /// </summary>
        [JsonProperty("FwCidrLst")]
        public FwVpcCidr[] FwCidrLst{ get; set; }

        /// <summary>
        /// 其他防火墙占用网段，一般是防火墙需要独占vpc时指定的网段
        /// </summary>
        [JsonProperty("ComFwCidr")]
        public string ComFwCidr{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FwCidrType", this.FwCidrType);
            this.SetParamArrayObj(map, prefix + "FwCidrLst.", this.FwCidrLst);
            this.SetParamSimple(map, prefix + "ComFwCidr", this.ComFwCidr);
        }
    }
}

