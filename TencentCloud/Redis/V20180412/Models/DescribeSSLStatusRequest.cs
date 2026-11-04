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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSSLStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例 ID。请登录 <a href="https://console.cloud.tencent.com/redis/instance/list">Redis 控制台</a>在实例列表复制实例 ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>证书下载格式类型，不传时默认 nginx。仅对自定义证书（CertSource=1）生效</p><p>枚举值：</p><ul><li>nginx： nginx可用</li><li>apache： apache可用</li><li>tomcat： tomcat可用</li><li>iis： iis可用</li></ul>
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
        }
    }
}

