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

    public class EdgeIpInfoSimple : AbstractModel
    {
        
        /// <summary>
        /// 公网IP
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 公网 IP 类型 1 公网,2 弹性,3 弹性ipv6,4 anycastIP, 6 HighQualityEIP
        /// </summary>
        [JsonProperty("PublicIpType")]
        public long? PublicIpType{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 开关状态
        /// 0 : 关闭
        /// 1 : 开启
        /// 2 : 开启中
        /// 3 : 关闭中
        /// 4 : 异常
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 0 : 旁路 1 : 串行 2 : 正在模式切换
        /// </summary>
        [JsonProperty("SwitchMode")]
        public long? SwitchMode{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PublicIpType", this.PublicIpType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SwitchMode", this.SwitchMode);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
        }
    }
}

