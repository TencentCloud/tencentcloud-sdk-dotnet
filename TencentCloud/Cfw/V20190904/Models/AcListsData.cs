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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AcListsData : AbstractModel
    {
        
        /// <summary>
        /// 规则id
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 访问源
        /// </summary>
        [JsonProperty("SourceIp")]
        public string SourceIp{ get; set; }

        /// <summary>
        /// 访问目的
        /// </summary>
        [JsonProperty("TargetIp")]
        public string TargetIp{ get; set; }

        /// <summary>
        /// 协议
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// 策略
        /// </summary>
        [JsonProperty("Strategy")]
        public ulong? Strategy{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// 命中次数
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// 执行顺序
        /// </summary>
        [JsonProperty("OrderIndex")]
        public ulong? OrderIndex{ get; set; }

        /// <summary>
        /// 告警规则id
        /// </summary>
        [JsonProperty("LogId")]
        public string LogId{ get; set; }

        /// <summary>
        /// 规则开关状态 1打开 0关闭
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 规则源类型
        /// </summary>
        [JsonProperty("SrcType")]
        public long? SrcType{ get; set; }

        /// <summary>
        /// 规则目的类型
        /// </summary>
        [JsonProperty("DstType")]
        public long? DstType{ get; set; }

        /// <summary>
        /// 规则唯一ID
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// 规则有效性
        /// 1 有效
        /// 0 无效
        /// </summary>
        [JsonProperty("Invalid")]
        public long? Invalid{ get; set; }

        /// <summary>
        /// 是否地域规则
        /// </summary>
        [JsonProperty("IsRegion")]
        public long? IsRegion{ get; set; }

        /// <summary>
        /// 云厂商代码
        /// </summary>
        [JsonProperty("CloudCode")]
        public string CloudCode{ get; set; }

        /// <summary>
        /// 自动化助手信息
        /// </summary>
        [JsonProperty("AutoTask")]
        public string AutoTask{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 地域码信息
        /// </summary>
        [JsonProperty("RegionCode")]
        public string RegionCode{ get; set; }

        /// <summary>
        /// 国家代码
        /// </summary>
        [JsonProperty("Country")]
        public long? Country{ get; set; }

        /// <summary>
        /// 城市代码
        /// </summary>
        [JsonProperty("City")]
        public long? City{ get; set; }

        /// <summary>
        /// 国家名称
        /// </summary>
        [JsonProperty("RegName1")]
        public string RegName1{ get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        [JsonProperty("RegName2")]
        public string RegName2{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "SourceIp", this.SourceIp);
            this.SetParamSimple(map, prefix + "TargetIp", this.TargetIp);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "OrderIndex", this.OrderIndex);
            this.SetParamSimple(map, prefix + "LogId", this.LogId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SrcType", this.SrcType);
            this.SetParamSimple(map, prefix + "DstType", this.DstType);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "Invalid", this.Invalid);
            this.SetParamSimple(map, prefix + "IsRegion", this.IsRegion);
            this.SetParamSimple(map, prefix + "CloudCode", this.CloudCode);
            this.SetParamSimple(map, prefix + "AutoTask", this.AutoTask);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "RegionCode", this.RegionCode);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "RegName1", this.RegName1);
            this.SetParamSimple(map, prefix + "RegName2", this.RegName2);
        }
    }
}

