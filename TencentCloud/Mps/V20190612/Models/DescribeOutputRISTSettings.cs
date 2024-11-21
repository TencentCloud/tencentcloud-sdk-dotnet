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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOutputRISTSettings : AbstractModel
    {
        
        /// <summary>
        /// RIST模式，可选[LISTENER|CALLER]，默认为LISTENER。
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }

        /// <summary>
        /// RIST配置方案，可选[MAIN|SIMPLE]，默认为MAIN。
        /// </summary>
        [JsonProperty("Profile")]
        public string Profile{ get; set; }

        /// <summary>
        /// RIST缓冲区大小，单位为毫秒。最小值为50毫秒，最大值为5000毫秒。默认值：120
        /// </summary>
        [JsonProperty("Buffer")]
        public long? Buffer{ get; set; }

        /// <summary>
        /// 服务器监听地址，RIST模式为LISTENER时使用。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SourceAddresses")]
        public OutputRISTSourceAddressResp[] SourceAddresses{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Profile", this.Profile);
            this.SetParamSimple(map, prefix + "Buffer", this.Buffer);
            this.SetParamArrayObj(map, prefix + "SourceAddresses.", this.SourceAddresses);
        }
    }
}

