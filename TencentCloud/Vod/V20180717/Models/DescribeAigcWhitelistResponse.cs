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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAigcWhitelistResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>AIGC任务类型</p><p>枚举值：</p><ul><li>Image： AIGC 生图任务</li><li>Video： AIGC 生视频任务</li></ul>
        /// </summary>
        [JsonProperty("AigcType")]
        public string AigcType{ get; set; }

        /// <summary>
        /// <p>模型白名单开关</p><p>枚举值：</p><ul><li>ON： 打开，只有允许调用ModelWhitelist中列出的模型</li><li>OFF： 关闭，允许调用所有模型</li></ul>
        /// </summary>
        [JsonProperty("ModelWhitelistSwitch")]
        public string ModelWhitelistSwitch{ get; set; }

        /// <summary>
        /// <p>模型白名单列表</p>
        /// </summary>
        [JsonProperty("ModelWhitelist")]
        public AigcWhitelistModel[] ModelWhitelist{ get; set; }

        /// <summary>
        /// <p>IP白名单开关</p><p>枚举值：</p><ul><li>ON： 打开，只允许IpWhitelist中列出的IP段进行调用</li><li>OFF： 关闭，允许所有IP进行调用</li></ul>
        /// </summary>
        [JsonProperty("IpWhitelistSwitch")]
        public string IpWhitelistSwitch{ get; set; }

        /// <summary>
        /// <p>IP白名单的CIDR列表</p>
        /// </summary>
        [JsonProperty("IpWhitelist")]
        public string[] IpWhitelist{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AigcType", this.AigcType);
            this.SetParamSimple(map, prefix + "ModelWhitelistSwitch", this.ModelWhitelistSwitch);
            this.SetParamArrayObj(map, prefix + "ModelWhitelist.", this.ModelWhitelist);
            this.SetParamSimple(map, prefix + "IpWhitelistSwitch", this.IpWhitelistSwitch);
            this.SetParamArraySimple(map, prefix + "IpWhitelist.", this.IpWhitelist);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

