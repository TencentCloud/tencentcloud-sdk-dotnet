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

    public class DatabaseWhiteListRuleData : AbstractModel
    {
        
        /// <summary>
        /// 访问源
        /// </summary>
        [JsonProperty("SourceIp")]
        public string SourceIp{ get; set; }

        /// <summary>
        /// 访问源类型，1 ip；6 实例；100 资源分组
        /// </summary>
        [JsonProperty("SourceType")]
        public long? SourceType{ get; set; }

        /// <summary>
        /// 访问目的
        /// </summary>
        [JsonProperty("TargetIp")]
        public string TargetIp{ get; set; }

        /// <summary>
        /// 访问目的类型，1 ip；6 实例；100 资源分组
        /// </summary>
        [JsonProperty("TargetType")]
        public long? TargetType{ get; set; }

        /// <summary>
        /// 规则描述
        /// </summary>
        [JsonProperty("Detail")]
        public string Detail{ get; set; }

        /// <summary>
        /// 是否地域规则，0不是 1是
        /// </summary>
        [JsonProperty("IsRegionRule")]
        public long? IsRegionRule{ get; set; }

        /// <summary>
        /// 是否云厂商规则，0不是 1 时
        /// </summary>
        [JsonProperty("IsCloudRule")]
        public long? IsCloudRule{ get; set; }

        /// <summary>
        /// 是否启用，0 不启用，1启用
        /// </summary>
        [JsonProperty("Enable")]
        public long? Enable{ get; set; }

        /// <summary>
        /// 地域码1
        /// </summary>
        [JsonProperty("FirstLevelRegionCode")]
        public long? FirstLevelRegionCode{ get; set; }

        /// <summary>
        /// 地域码2
        /// </summary>
        [JsonProperty("SecondLevelRegionCode")]
        public long? SecondLevelRegionCode{ get; set; }

        /// <summary>
        /// 地域名称1
        /// </summary>
        [JsonProperty("FirstLevelRegionName")]
        public string FirstLevelRegionName{ get; set; }

        /// <summary>
        /// 地域名称2
        /// </summary>
        [JsonProperty("SecondLevelRegionName")]
        public string SecondLevelRegionName{ get; set; }

        /// <summary>
        /// 云厂商码
        /// </summary>
        [JsonProperty("CloudCode")]
        public string CloudCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceIp", this.SourceIp);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "TargetIp", this.TargetIp);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "Detail", this.Detail);
            this.SetParamSimple(map, prefix + "IsRegionRule", this.IsRegionRule);
            this.SetParamSimple(map, prefix + "IsCloudRule", this.IsCloudRule);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "FirstLevelRegionCode", this.FirstLevelRegionCode);
            this.SetParamSimple(map, prefix + "SecondLevelRegionCode", this.SecondLevelRegionCode);
            this.SetParamSimple(map, prefix + "FirstLevelRegionName", this.FirstLevelRegionName);
            this.SetParamSimple(map, prefix + "SecondLevelRegionName", this.SecondLevelRegionName);
            this.SetParamSimple(map, prefix + "CloudCode", this.CloudCode);
        }
    }
}

