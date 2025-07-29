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

    public class ModifyInput : AbstractModel
    {
        
        /// <summary>
        /// 输入Id。
        /// </summary>
        [JsonProperty("InputId")]
        public string InputId{ get; set; }

        /// <summary>
        /// 输入名称。
        /// </summary>
        [JsonProperty("InputName")]
        public string InputName{ get; set; }

        /// <summary>
        /// 输入描述。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 允许的推流的IP，CIDR格式。
        /// </summary>
        [JsonProperty("AllowIpList")]
        public string[] AllowIpList{ get; set; }

        /// <summary>
        /// SRT的配置信息。
        /// </summary>
        [JsonProperty("SRTSettings")]
        public CreateInputSRTSettings SRTSettings{ get; set; }

        /// <summary>
        /// RTP的配置信息。
        /// </summary>
        [JsonProperty("RTPSettings")]
        public CreateInputRTPSettings RTPSettings{ get; set; }

        /// <summary>
        /// 输入的协议，可选[SRT|RTP|RTMP|RTMP_PULL|RTSP_PULL|RIST]。	-
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 输入的主备开关，可选[OPEN|CLOSE]。
        /// </summary>
        [JsonProperty("FailOver")]
        public string FailOver{ get; set; }

        /// <summary>
        /// RTMP_PULL的配置信息。
        /// </summary>
        [JsonProperty("RTMPPullSettings")]
        public CreateInputRTMPPullSettings RTMPPullSettings{ get; set; }

        /// <summary>
        /// RTSP_PULL的配置信息。
        /// </summary>
        [JsonProperty("RTSPPullSettings")]
        public CreateInputRTSPPullSettings RTSPPullSettings{ get; set; }

        /// <summary>
        /// HLS_PULL的配置信息。
        /// </summary>
        [JsonProperty("HLSPullSettings")]
        public CreateInputHLSPullSettings HLSPullSettings{ get; set; }

        /// <summary>
        /// 延播平滑吐流配置信息。
        /// </summary>
        [JsonProperty("ResilientStream")]
        public ResilientStreamConf ResilientStream{ get; set; }

        /// <summary>
        /// 绑定的输入安全组 ID。 仅支持关联一组安全组。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 可用区，非必填，最多支持输入两个可用区，对于需改接口，只要第二个可用区会参与到资源分配。如果input开启容灾或者涉及RTSP_PULL协议切换时有效(会重新分配地址)。	
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// RIST的配置信息。
        /// </summary>
        [JsonProperty("RISTSettings")]
        public CreateInputRISTSettings RISTSettings{ get; set; }

        /// <summary>
        /// 输入节点的地区
        /// </summary>
        [JsonProperty("InputRegion")]
        public string InputRegion{ get; set; }

        /// <summary>
        /// 冷热备相关
        /// </summary>
        [JsonProperty("FailOverOption")]
        public FailOverOption FailOverOption{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InputId", this.InputId);
            this.SetParamSimple(map, prefix + "InputName", this.InputName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArraySimple(map, prefix + "AllowIpList.", this.AllowIpList);
            this.SetParamObj(map, prefix + "SRTSettings.", this.SRTSettings);
            this.SetParamObj(map, prefix + "RTPSettings.", this.RTPSettings);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "FailOver", this.FailOver);
            this.SetParamObj(map, prefix + "RTMPPullSettings.", this.RTMPPullSettings);
            this.SetParamObj(map, prefix + "RTSPPullSettings.", this.RTSPPullSettings);
            this.SetParamObj(map, prefix + "HLSPullSettings.", this.HLSPullSettings);
            this.SetParamObj(map, prefix + "ResilientStream.", this.ResilientStream);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamObj(map, prefix + "RISTSettings.", this.RISTSettings);
            this.SetParamSimple(map, prefix + "InputRegion", this.InputRegion);
            this.SetParamObj(map, prefix + "FailOverOption.", this.FailOverOption);
        }
    }
}

