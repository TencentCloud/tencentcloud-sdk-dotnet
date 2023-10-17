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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnvAddressInfo : AbstractModel
    {
        
        /// <summary>
        /// 环境名
        /// </summary>
        [JsonProperty("EnvName")]
        public string EnvName{ get; set; }

        /// <summary>
        /// 是否开启config公网
        /// </summary>
        [JsonProperty("EnableConfigInternet")]
        public bool? EnableConfigInternet{ get; set; }

        /// <summary>
        /// config公网ip
        /// </summary>
        [JsonProperty("ConfigInternetServiceIp")]
        public string ConfigInternetServiceIp{ get; set; }

        /// <summary>
        /// config内网访问地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigIntranetAddress")]
        public string ConfigIntranetAddress{ get; set; }

        /// <summary>
        /// 是否开启config内网clb
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableConfigIntranet")]
        public bool? EnableConfigIntranet{ get; set; }

        /// <summary>
        /// 客户端公网带宽
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InternetBandWidth")]
        public long? InternetBandWidth{ get; set; }

        /// <summary>
        /// 客户端公网CLB多可用区信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CLBMultiRegion")]
        public CLBMultiRegion CLBMultiRegion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvName", this.EnvName);
            this.SetParamSimple(map, prefix + "EnableConfigInternet", this.EnableConfigInternet);
            this.SetParamSimple(map, prefix + "ConfigInternetServiceIp", this.ConfigInternetServiceIp);
            this.SetParamSimple(map, prefix + "ConfigIntranetAddress", this.ConfigIntranetAddress);
            this.SetParamSimple(map, prefix + "EnableConfigIntranet", this.EnableConfigIntranet);
            this.SetParamSimple(map, prefix + "InternetBandWidth", this.InternetBandWidth);
            this.SetParamObj(map, prefix + "CLBMultiRegion.", this.CLBMultiRegion);
        }
    }
}

