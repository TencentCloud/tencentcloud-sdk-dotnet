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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBInstanceSSLConfigResponse : AbstractModel
    {
        
        /// <summary>
        /// true 代表开通 ，false 代表未开通
        /// </summary>
        [JsonProperty("SSLEnabled")]
        public bool? SSLEnabled{ get; set; }

        /// <summary>
        /// 云端根证书下载链接
        /// </summary>
        [JsonProperty("CAUrl")]
        public string CAUrl{ get; set; }

        /// <summary>
        /// 服务器证书中配置的内网或外网连接地址
        /// </summary>
        [JsonProperty("ConnectAddress")]
        public string ConnectAddress{ get; set; }

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
            this.SetParamSimple(map, prefix + "SSLEnabled", this.SSLEnabled);
            this.SetParamSimple(map, prefix + "CAUrl", this.CAUrl);
            this.SetParamSimple(map, prefix + "ConnectAddress", this.ConnectAddress);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

