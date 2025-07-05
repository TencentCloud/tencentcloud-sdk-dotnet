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

    public class BuildMessageRouteRequest : AbstractModel
    {
        
        /// <summary>
        /// 路由名字
        /// </summary>
        [JsonProperty("RouteName")]
        public string RouteName{ get; set; }

        /// <summary>
        /// 源产品id
        /// </summary>
        [JsonProperty("SourceProductID")]
        public string SourceProductID{ get; set; }

        /// <summary>
        /// 源设备名列表
        /// </summary>
        [JsonProperty("SourceDeviceNameList")]
        public string[] SourceDeviceNameList{ get; set; }

        /// <summary>
        /// 第一个字符为 "0"或"1"，"1"表示自定义topic
        /// </summary>
        [JsonProperty("TopicFilter")]
        public string TopicFilter{ get; set; }

        /// <summary>
        /// http或mqtt-broker
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// 源单元id列表
        /// </summary>
        [JsonProperty("SourceUnitIDList")]
        public string[] SourceUnitIDList{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Descript")]
        public string Descript{ get; set; }

        /// <summary>
        /// 无
        /// </summary>
        [JsonProperty("TargetOptions")]
        public string TargetOptions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RouteName", this.RouteName);
            this.SetParamSimple(map, prefix + "SourceProductID", this.SourceProductID);
            this.SetParamArraySimple(map, prefix + "SourceDeviceNameList.", this.SourceDeviceNameList);
            this.SetParamSimple(map, prefix + "TopicFilter", this.TopicFilter);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamArraySimple(map, prefix + "SourceUnitIDList.", this.SourceUnitIDList);
            this.SetParamSimple(map, prefix + "Descript", this.Descript);
            this.SetParamSimple(map, prefix + "TargetOptions", this.TargetOptions);
        }
    }
}

