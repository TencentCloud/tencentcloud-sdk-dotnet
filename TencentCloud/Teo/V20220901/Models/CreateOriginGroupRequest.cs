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

    public class CreateOriginGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 源站类型，取值有：
        /// <li>self：自有源站；</li>
        /// <li>third_party：第三方源站；</li>
        /// <li>cos：腾讯云COS源站。</li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// 源站组名称。
        /// </summary>
        [JsonProperty("OriginGroupName")]
        public string OriginGroupName{ get; set; }

        /// <summary>
        /// 源站配置类型，当OriginType=self时，取值有：
        /// <li>area：按区域配置；</li>
        /// <li>weight： 按权重配置；</li>
        /// <li>proto： 按HTTP协议配置。</li>当OriginType=third_party/cos时放空。
        /// </summary>
        [JsonProperty("ConfigurationType")]
        public string ConfigurationType{ get; set; }

        /// <summary>
        /// 源站记录信息。
        /// </summary>
        [JsonProperty("OriginRecords")]
        public OriginRecord[] OriginRecords{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamSimple(map, prefix + "OriginGroupName", this.OriginGroupName);
            this.SetParamSimple(map, prefix + "ConfigurationType", this.ConfigurationType);
            this.SetParamArrayObj(map, prefix + "OriginRecords.", this.OriginRecords);
        }
    }
}

