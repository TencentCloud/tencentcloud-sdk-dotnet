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

    public class OriginRecord : AbstractModel
    {
        
        /// <summary>
        /// 源站记录值，不包含端口信息，可以为：IPv4，IPv6，域名格式。
        /// </summary>
        [JsonProperty("Record")]
        public string Record{ get; set; }

        /// <summary>
        /// 源站记录ID。
        /// </summary>
        [JsonProperty("RecordId")]
        public string RecordId{ get; set; }

        /// <summary>
        /// 源站端口，取值范围：[1-65535]。
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// 当源站配置类型ConfigurationType=weight时，表示权重。
        /// 不配置权重信息时，所有源站组记录统一填写为0或者不填写，表示多个源站轮询回源。
        /// 配置权重信息时，取值为[1-100]，多个源站权重总和应为100，表示多个源站按照权重回源。
        /// 当源站配置类型ConfigurationType=proto时，表示权重。
        /// 不配置权重信息时，所有源站组记录统一填写为0或者不填写，表示多个源站轮询回源。
        /// 配置权重信息时，取值为[1-100]，源站组内Proto相同的多个源站权重总和应为100，表示多个源站按照权重回源。
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// 当源站配置类型ConfigurationType=proto时，表示源站的协议类型，将按照客户端请求协议回到相应的源站，取值有：
        /// <li>http：HTTP协议源站；</li>
        /// <li>https：HTTPS协议源站。</li>
        /// </summary>
        [JsonProperty("Proto")]
        public string Proto{ get; set; }

        /// <summary>
        /// 当源站配置类型ConfigurationType=area时，表示区域，为空表示全部地区。取值为iso-3166中alpha-2编码或者大洲区域代码。大洲区域代码取值为：
        /// <li>Asia：亚洲；</li>
        /// <li>Europe：欧洲；</li>
        /// <li>Africa：非洲；</li>
        /// <li>Oceania：大洋洲；</li>
        /// <li>Americas：美洲。</li>源站组记录中，至少需要有一项为全部地区。
        /// </summary>
        [JsonProperty("Area")]
        public string[] Area{ get; set; }

        /// <summary>
        /// 当源站类型OriginType=third_part时有效
        /// 是否私有鉴权，取值有：
        /// <li>true：使用私有鉴权；</li>
        /// <li>false：不使用私有鉴权。</li>不填写，默认值为：false。
        /// </summary>
        [JsonProperty("Private")]
        public bool? Private{ get; set; }

        /// <summary>
        /// 当源站类型Private=true时有效，表示私有鉴权使用参数。
        /// </summary>
        [JsonProperty("PrivateParameters")]
        public PrivateParameter[] PrivateParameters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Record", this.Record);
            this.SetParamSimple(map, prefix + "RecordId", this.RecordId);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "Proto", this.Proto);
            this.SetParamArraySimple(map, prefix + "Area.", this.Area);
            this.SetParamSimple(map, prefix + "Private", this.Private);
            this.SetParamArrayObj(map, prefix + "PrivateParameters.", this.PrivateParameters);
        }
    }
}

