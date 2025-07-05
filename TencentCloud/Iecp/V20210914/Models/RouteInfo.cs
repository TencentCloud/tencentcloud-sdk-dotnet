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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RouteInfo : AbstractModel
    {
        
        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("RouteID")]
        public long? RouteID{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("RouteName")]
        public string RouteName{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("SourceProductID")]
        public string SourceProductID{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("TopicFilter")]
        public string TopicFilter{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("TargetOptions")]
        public string TargetOptions{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("Descript")]
        public string Descript{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("Healthy")]
        public string Healthy{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("MessageCount")]
        public long? MessageCount{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("MessageLastTime")]
        public string MessageLastTime{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("SourceProductName")]
        public string SourceProductName{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("SourceUnitIDList")]
        public string[] SourceUnitIDList{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("SourceUnitNameList")]
        public string[] SourceUnitNameList{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("SourceDeviceNameList")]
        public string[] SourceDeviceNameList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RouteID", this.RouteID);
            this.SetParamSimple(map, prefix + "RouteName", this.RouteName);
            this.SetParamSimple(map, prefix + "SourceProductID", this.SourceProductID);
            this.SetParamSimple(map, prefix + "TopicFilter", this.TopicFilter);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "TargetOptions", this.TargetOptions);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Descript", this.Descript);
            this.SetParamSimple(map, prefix + "Healthy", this.Healthy);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MessageCount", this.MessageCount);
            this.SetParamSimple(map, prefix + "MessageLastTime", this.MessageLastTime);
            this.SetParamSimple(map, prefix + "SourceProductName", this.SourceProductName);
            this.SetParamArraySimple(map, prefix + "SourceUnitIDList.", this.SourceUnitIDList);
            this.SetParamArraySimple(map, prefix + "SourceUnitNameList.", this.SourceUnitNameList);
            this.SetParamArraySimple(map, prefix + "SourceDeviceNameList.", this.SourceDeviceNameList);
        }
    }
}

