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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateFirstLinkSessionRequest : AbstractModel
    {
        
        /// <summary>
        /// 模版ID
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 终端网络信息
        /// </summary>
        [JsonProperty("SrcAddressInfo")]
        public SrcAddressInfo SrcAddressInfo{ get; set; }

        /// <summary>
        /// 加速目标网络信息
        /// </summary>
        [JsonProperty("DestAddressInfo")]
        public DestAddressInfo DestAddressInfo{ get; set; }

        /// <summary>
        /// 终端设备信息
        /// </summary>
        [JsonProperty("DeviceInfo")]
        public DeviceInfo DeviceInfo{ get; set; }

        /// <summary>
        /// 接口扩展参数，如果是电信用户，需要填充CTCC Token字段
        /// </summary>
        [JsonProperty("Capacity")]
        public Capacity Capacity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamObj(map, prefix + "SrcAddressInfo.", this.SrcAddressInfo);
            this.SetParamObj(map, prefix + "DestAddressInfo.", this.DestAddressInfo);
            this.SetParamObj(map, prefix + "DeviceInfo.", this.DeviceInfo);
            this.SetParamObj(map, prefix + "Capacity.", this.Capacity);
        }
    }
}

