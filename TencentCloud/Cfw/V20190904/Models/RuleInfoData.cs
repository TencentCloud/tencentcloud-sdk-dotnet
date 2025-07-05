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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RuleInfoData : AbstractModel
    {
        
        /// <summary>
        /// 执行顺序
        /// </summary>
        [JsonProperty("OrderIndex")]
        public ulong? OrderIndex{ get; set; }

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
        /// 策略, 0：观察，1：阻断，2：放行
        /// </summary>
        [JsonProperty("Strategy")]
        public string Strategy{ get; set; }

        /// <summary>
        /// 访问源类型，1是IP，3是域名，4是IP地址模板，5是域名地址模板
        /// </summary>
        [JsonProperty("SourceType")]
        public ulong? SourceType{ get; set; }

        /// <summary>
        /// 方向，0：出站，1：入站
        /// </summary>
        [JsonProperty("Direction")]
        public ulong? Direction{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// 访问目的类型，1是IP，3是域名，4是IP地址模板，5是域名地址模板
        /// </summary>
        [JsonProperty("TargetType")]
        public ulong? TargetType{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// id值
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 日志id，从告警处创建必传，其它为空
        /// </summary>
        [JsonProperty("LogId")]
        public string LogId{ get; set; }

        /// <summary>
        /// 城市Code
        /// </summary>
        [JsonProperty("City")]
        public ulong? City{ get; set; }

        /// <summary>
        /// 国家Code
        /// </summary>
        [JsonProperty("Country")]
        public ulong? Country{ get; set; }

        /// <summary>
        /// 云厂商，支持多个，以逗号分隔， 1:腾讯云（仅中国香港及海外）,2:阿里云,3:亚马逊云,4:华为云,5:微软云
        /// </summary>
        [JsonProperty("CloudCode")]
        public string CloudCode{ get; set; }

        /// <summary>
        /// 是否为地域
        /// </summary>
        [JsonProperty("IsRegion")]
        public ulong? IsRegion{ get; set; }

        /// <summary>
        /// 城市名
        /// </summary>
        [JsonProperty("CityName")]
        public string CityName{ get; set; }

        /// <summary>
        /// 国家名
        /// </summary>
        [JsonProperty("CountryName")]
        public string CountryName{ get; set; }

        /// <summary>
        /// 国家二位iso代码或者省份缩写代码
        /// </summary>
        [JsonProperty("RegionIso")]
        public string RegionIso{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrderIndex", this.OrderIndex);
            this.SetParamSimple(map, prefix + "SourceIp", this.SourceIp);
            this.SetParamSimple(map, prefix + "TargetIp", this.TargetIp);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Strategy", this.Strategy);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "LogId", this.LogId);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "CloudCode", this.CloudCode);
            this.SetParamSimple(map, prefix + "IsRegion", this.IsRegion);
            this.SetParamSimple(map, prefix + "CityName", this.CityName);
            this.SetParamSimple(map, prefix + "CountryName", this.CountryName);
            this.SetParamSimple(map, prefix + "RegionIso", this.RegionIso);
        }
    }
}

