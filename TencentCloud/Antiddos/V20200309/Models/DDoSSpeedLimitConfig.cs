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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDoSSpeedLimitConfig : AbstractModel
    {
        
        /// <summary>
        /// 限速模式，取值[
        /// 1(基于源IP限速)
        /// 2(基于目的端口限速)
        /// ]
        /// </summary>
        [JsonProperty("Mode")]
        public ulong? Mode{ get; set; }

        /// <summary>
        /// 限速值，每种类型的限速值最多支持1个；该字段数组至少有一种限速值
        /// </summary>
        [JsonProperty("SpeedValues")]
        public SpeedValue[] SpeedValues{ get; set; }

        /// <summary>
        /// 此字段已弃用，请填写新字段DstPortList。
        /// </summary>
        [JsonProperty("DstPortScopes")]
        public PortSegment[] DstPortScopes{ get; set; }

        /// <summary>
        /// 配置ID，配置添加成功后生成；添加新限制配置时不用填写此字段，修改或删除限速配置时需要填写配置ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// IP protocol numbers, 取值[
        /// ALL(所有协议)
        /// TCP(tcp协议)
        /// UDP(udp协议)
        /// SMP(smp协议)
        /// 1;2-100(自定义协议号范围,最多8个)
        /// ]
        /// 注意：当自定义协议号范围时，只能填写协议号，多个范围;分隔；当填写ALL时不能再填写其他协议或协议号。
        /// </summary>
        [JsonProperty("ProtocolList")]
        public string ProtocolList{ get; set; }

        /// <summary>
        /// 端口范围列表，最多8个，多个;分隔，范围表示用-；此端口范围必须填写；填写样式1:0-65535，样式2:80;443;1000-2000
        /// </summary>
        [JsonProperty("DstPortList")]
        public string DstPortList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamArrayObj(map, prefix + "SpeedValues.", this.SpeedValues);
            this.SetParamArrayObj(map, prefix + "DstPortScopes.", this.DstPortScopes);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ProtocolList", this.ProtocolList);
            this.SetParamSimple(map, prefix + "DstPortList", this.DstPortList);
        }
    }
}

