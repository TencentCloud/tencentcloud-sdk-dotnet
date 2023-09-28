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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateOutputInfo : AbstractModel
    {
        
        /// <summary>
        /// 输出的名称。
        /// </summary>
        [JsonProperty("OutputName")]
        public string OutputName{ get; set; }

        /// <summary>
        /// 输出描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 输出协议，可选[SRT|RTP|RTMP|RTMP_PULL]。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 输出地区。
        /// </summary>
        [JsonProperty("OutputRegion")]
        public string OutputRegion{ get; set; }

        /// <summary>
        /// 输出的SRT的配置。
        /// </summary>
        [JsonProperty("SRTSettings")]
        public CreateOutputSRTSettings SRTSettings{ get; set; }

        /// <summary>
        /// 输出的RTMP的配置。
        /// </summary>
        [JsonProperty("RTMPSettings")]
        public CreateOutputRTMPSettings RTMPSettings{ get; set; }

        /// <summary>
        /// 输出的RTP的配置。
        /// </summary>
        [JsonProperty("RTPSettings")]
        public CreateOutputInfoRTPSettings RTPSettings{ get; set; }

        /// <summary>
        /// IP白名单列表，格式为CIDR，如0.0.0.0/0。
        /// 当Protocol为RTMP_PULL有效，为空代表不限制客户端IP。
        /// </summary>
        [JsonProperty("AllowIpList")]
        public string[] AllowIpList{ get; set; }

        /// <summary>
        /// 最大拉流并发数，最大4，默认4。
        /// </summary>
        [JsonProperty("MaxConcurrent")]
        public ulong? MaxConcurrent{ get; set; }

        /// <summary>
        /// 绑定的输入安全组 ID。 
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutputName", this.OutputName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "OutputRegion", this.OutputRegion);
            this.SetParamObj(map, prefix + "SRTSettings.", this.SRTSettings);
            this.SetParamObj(map, prefix + "RTMPSettings.", this.RTMPSettings);
            this.SetParamObj(map, prefix + "RTPSettings.", this.RTPSettings);
            this.SetParamArraySimple(map, prefix + "AllowIpList.", this.AllowIpList);
            this.SetParamSimple(map, prefix + "MaxConcurrent", this.MaxConcurrent);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
        }
    }
}

