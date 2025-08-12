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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateMicroserviceWithDetailRespRequest : AbstractModel
    {
        
        /// <summary>
        /// 命名空间ID。该参数可以通过调用 [DescribeSimpleNamespaces](https://cloud.tencent.com/document/api/649/36096) 的返回值中的 NamespaceId 字段来获取或通过登录[控制台](https://console.cloud.tencent.com/tsf/resource?tab=namespace)查看；也可以调用[CreateNamespace](https://cloud.tencent.com/document/product/649/36098)创建新的命名空间。
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 微服务名称，最多支持128个字符。
        /// </summary>
        [JsonProperty("MicroserviceName")]
        public string MicroserviceName{ get; set; }

        /// <summary>
        /// 微服务描述信息，最多支持200个字符。
        /// </summary>
        [JsonProperty("MicroserviceDesc")]
        public string MicroserviceDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "MicroserviceName", this.MicroserviceName);
            this.SetParamSimple(map, prefix + "MicroserviceDesc", this.MicroserviceDesc);
        }
    }
}

