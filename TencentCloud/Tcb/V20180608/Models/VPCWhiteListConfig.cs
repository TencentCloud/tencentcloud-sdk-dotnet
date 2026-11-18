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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VPCWhiteListConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>VPC 白名单配置状态</p><p>枚举值：</p><ul><li>OPEN： 开启白名单，VPCs 必填，覆盖写入</li><li>CLOSE： 关闭白名单，VPCs 填入时，覆盖写入</li></ul>
        /// </summary>
        [JsonProperty("Action")]
        public string Action{ get; set; }

        /// <summary>
        /// <p>VPC 信息</p>
        /// </summary>
        [JsonProperty("VPCs")]
        public VPCInfo[] VPCs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamArrayObj(map, prefix + "VPCs.", this.VPCs);
        }
    }
}

