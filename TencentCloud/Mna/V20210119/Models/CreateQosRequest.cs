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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateQosRequest : AbstractModel
    {
        
        /// <summary>
        /// 加速业务源地址信息，SrcIpv6和（SrcIpv4+SrcPublicIpv4）二选一，目前Ipv6不可用，全部填写以Ipv4参数为准。
        /// </summary>
        [JsonProperty("SrcAddressInfo")]
        public SrcAddressInfo SrcAddressInfo{ get; set; }

        /// <summary>
        /// 加速业务目标地址信息
        /// </summary>
        [JsonProperty("DestAddressInfo")]
        public DestAddressInfo DestAddressInfo{ get; set; }

        /// <summary>
        /// 加速套餐
        /// T100K：时延性保障 + 带宽保障上下行保障 100kbps
        /// T200K：时延性保障 + 带宽保障上下行保障 200kbps
        /// T400K：时延性保障 + 带宽保障上下行保障  400kbps
        /// BD1M：带宽型保障 + 下行带宽保障1Mbps
        /// BD2M：带宽型保障 + 下行带宽保障2Mbps
        /// BD4M：带宽型保障 + 下行带宽保障4Mbps
        /// BU1M：带宽型保障 + 上行带宽保障1Mbps
        /// BU2M：带宽型保障 + 上行带宽保障2Mbps
        /// BU4M：带宽型保障 + 上行带宽保障4Mbps
        /// </summary>
        [JsonProperty("QosMenu")]
        public string QosMenu{ get; set; }

        /// <summary>
        /// 申请加速的设备信息，包括运营商，操作系统，设备唯一标识等。
        /// </summary>
        [JsonProperty("DeviceInfo")]
        public DeviceInfo DeviceInfo{ get; set; }

        /// <summary>
        /// 期望加速时长（单位分钟），默认值30分钟
        /// </summary>
        [JsonProperty("Duration")]
        public ulong? Duration{ get; set; }

        /// <summary>
        /// 接口能力扩展，如果是电信用户，必须填充CTCC Token字段
        /// </summary>
        [JsonProperty("Capacity")]
        public Capacity Capacity{ get; set; }

        /// <summary>
        /// 应用模板ID
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 针对特殊协议进行加速
        /// 1. IP （默认值）
        /// 2. UDP
        /// 3. TCP
        /// </summary>
        [JsonProperty("Protocol")]
        public ulong? Protocol{ get; set; }

        /// <summary>
        /// 加速策略关键数据
        /// </summary>
        [JsonProperty("Context")]
        public Context Context{ get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("Extern")]
        public string Extern{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "SrcAddressInfo.", this.SrcAddressInfo);
            this.SetParamObj(map, prefix + "DestAddressInfo.", this.DestAddressInfo);
            this.SetParamSimple(map, prefix + "QosMenu", this.QosMenu);
            this.SetParamObj(map, prefix + "DeviceInfo.", this.DeviceInfo);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamObj(map, prefix + "Capacity.", this.Capacity);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamObj(map, prefix + "Context.", this.Context);
            this.SetParamSimple(map, prefix + "Extern", this.Extern);
        }
    }
}

