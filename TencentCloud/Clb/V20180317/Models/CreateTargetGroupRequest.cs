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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTargetGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>目标组名称。命名规则：1-80 个英文字母、汉字等国际通用语言字符，数字，连接线“-”、下划线“_”等常见字符（禁止Unicode补充字符，如emoji表情、生僻汉字等）。</p>
        /// </summary>
        [JsonProperty("TargetGroupName")]
        public string TargetGroupName{ get; set; }

        /// <summary>
        /// <p>目标组的vpcId属性，不填则使用默认vpc。</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>目标组的默认端口， 后续添加服务器时可使用该默认端口。全监听目标组不支持此参数，非全监听目标组Port和TargetGroupInstances.N中的port二者必填其一。</p>
        /// </summary>
        [JsonProperty("Port")]
        public ulong? Port{ get; set; }

        /// <summary>
        /// <p>目标组绑定的后端服务器，单次最多支持50个。</p>
        /// </summary>
        [JsonProperty("TargetGroupInstances")]
        public TargetGroupInstance[] TargetGroupInstances{ get; set; }

        /// <summary>
        /// <p>目标组类型，当前支持v1(旧版目标组), v2(新版目标组), 默认为v1(旧版目标组)。</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>目标组后端转发协议。v2新版目标组该项必填。目前支持TCP、UDP、HTTP、HTTPS、GRPC。</p>
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// <p>健康检查。</p>
        /// </summary>
        [JsonProperty("HealthCheck")]
        public TargetGroupHealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// <p>调度算法，仅V2新版目标组，且后端转发协议为(HTTP|HTTPS|GRPC)时该参数有效。可选值：<br>&lt;ur&gt;<li>WRR:按权重轮询。</li><li>LEAST_CONN:最小连接数。</li><li>IP_HASH:按IP哈希。</li><li>默认为 WRR。</li>&lt;ur&gt;</p>
        /// </summary>
        [JsonProperty("ScheduleAlgorithm")]
        public string ScheduleAlgorithm{ get; set; }

        /// <summary>
        /// <p>标签。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>后端服务默认权重, 其中：</p><ul><li>取值范围[0, 100]</li><li>设置该值后，添加后端服务到目标组时， 若后端服务不单独设置权重， 则使用这里的默认权重。 </li><li>v1 目标组类型不支持设置 Weight 参数。</li></ul>
        /// </summary>
        [JsonProperty("Weight")]
        public ulong? Weight{ get; set; }

        /// <summary>
        /// <p>全监听目标组标识，true表示是全监听目标组，false表示不是全监听目标组。仅V2新版类型目标组支持该参数。</p>
        /// </summary>
        [JsonProperty("FullListenSwitch")]
        public bool? FullListenSwitch{ get; set; }

        /// <summary>
        /// <p>是否开启长连接，此参数仅适用于HTTP/HTTPS目标组，0:关闭；1:开启， 默认关闭。</p>
        /// </summary>
        [JsonProperty("KeepaliveEnable")]
        public bool? KeepaliveEnable{ get; set; }

        /// <summary>
        /// <p>会话保持时间，单位：秒。可选值：30~3600，默认 0，表示不开启。仅V2新版且后端转发协议为HTTP/HTTPS/GRPC目标组支持该参数。</p>
        /// </summary>
        [JsonProperty("SessionExpireTime")]
        public ulong? SessionExpireTime{ get; set; }

        /// <summary>
        /// <p>IP版本类型。</p>
        /// </summary>
        [JsonProperty("IpVersion")]
        public string IpVersion{ get; set; }

        /// <summary>
        /// <p>是否开启SNAT（源IP替换），True（开启）、False（关闭）。默认为关闭。注意：SnatEnable开启时会替换客户端源IP，此时<code>透传客户端源IP</code>选项关闭，反之亦然。</p>
        /// </summary>
        [JsonProperty("SnatEnable")]
        public bool? SnatEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetGroupName", this.TargetGroupName);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamArrayObj(map, prefix + "TargetGroupInstances.", this.TargetGroupInstances);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamSimple(map, prefix + "ScheduleAlgorithm", this.ScheduleAlgorithm);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "FullListenSwitch", this.FullListenSwitch);
            this.SetParamSimple(map, prefix + "KeepaliveEnable", this.KeepaliveEnable);
            this.SetParamSimple(map, prefix + "SessionExpireTime", this.SessionExpireTime);
            this.SetParamSimple(map, prefix + "IpVersion", this.IpVersion);
            this.SetParamSimple(map, prefix + "SnatEnable", this.SnatEnable);
        }
    }
}

