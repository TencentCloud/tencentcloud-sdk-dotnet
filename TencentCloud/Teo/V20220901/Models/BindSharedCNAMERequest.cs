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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BindSharedCNAMERequest : AbstractModel
    {
        
        /// <summary>
        /// 加速域名所属站点 ID。	
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 绑定类型，取值有：
        /// <li>bind：绑定；</li>
        /// <li>unbind：解绑。</li>
        /// </summary>
        [JsonProperty("BindType")]
        public string BindType{ get; set; }

        /// <summary>
        /// 接入域名与共享 CNAME 的绑定关系。
        /// </summary>
        [JsonProperty("BindSharedCNAMEMaps")]
        public BindSharedCNAMEMap[] BindSharedCNAMEMaps{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "BindType", this.BindType);
            this.SetParamArrayObj(map, prefix + "BindSharedCNAMEMaps.", this.BindSharedCNAMEMaps);
        }
    }
}

