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
        /// 输出的转推协议，支持SRT|RTP|RTMP|RTMP_PULL|RTSP_PULL|RIST。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 输出地区。
        /// </summary>
        [JsonProperty("OutputRegion")]
        public string OutputRegion{ get; set; }

        /// <summary>
        /// 输出类型：Internet/TencentCSS
        /// </summary>
        [JsonProperty("OutputType")]
        public string OutputType{ get; set; }

        /// <summary>
        /// 输出模块类型，包括Pinpoint（单点输出，最多支持四路并发输出）；MultiMesh（多路输出，支持大于四路的并发输出，目前可以达到200路）。默认类型为 Pinpoint 输出。对于单个 Flow 一个区域最多只能有一个 MultiMesh 输出
        /// </summary>
        [JsonProperty("OutputKind")]
        public string OutputKind{ get; set; }

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
        /// 可用区，output最多只支持输入一个可用区。	
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// 输出的RIST的配置。
        /// </summary>
        [JsonProperty("RISTSettings")]
        public CreateOutputRistSettings RISTSettings{ get; set; }

        /// <summary>
        /// 对于含有多个音/视频轨的流，可以指定需要使用的轨道。PidSelector 与 TrackSelector 只能存在一个
        /// </summary>
        [JsonProperty("PidSelector")]
        [System.Obsolete]
        public PidSelector PidSelector{ get; set; }

        /// <summary>
        /// 对于含有多个音/视频轨的流，可以指定需要使用的轨道。PidSelector 与 TrackSelector 只能存在一个
        /// </summary>
        [JsonProperty("StreamSelector")]
        public StreamSelector StreamSelector{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OutputName", this.OutputName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "OutputRegion", this.OutputRegion);
            this.SetParamSimple(map, prefix + "OutputType", this.OutputType);
            this.SetParamSimple(map, prefix + "OutputKind", this.OutputKind);
            this.SetParamObj(map, prefix + "SRTSettings.", this.SRTSettings);
            this.SetParamObj(map, prefix + "RTMPSettings.", this.RTMPSettings);
            this.SetParamObj(map, prefix + "RTPSettings.", this.RTPSettings);
            this.SetParamArraySimple(map, prefix + "AllowIpList.", this.AllowIpList);
            this.SetParamSimple(map, prefix + "MaxConcurrent", this.MaxConcurrent);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamObj(map, prefix + "RISTSettings.", this.RISTSettings);
            this.SetParamObj(map, prefix + "PidSelector.", this.PidSelector);
            this.SetParamObj(map, prefix + "StreamSelector.", this.StreamSelector);
        }
    }
}

