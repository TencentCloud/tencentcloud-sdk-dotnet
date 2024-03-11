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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDSPASelfBuildMetaResourceResponse : AbstractModel
    {
        
        /// <summary>
        /// 连通性测试情况，success表示可正常访问，failed表示无法访问。
        /// </summary>
        [JsonProperty("ConnectivityStatus")]
        public string ConnectivityStatus{ get; set; }

        /// <summary>
        /// 连通性描述字段，如果连通性测试失败，这里会返回无法访问的相关信息说明。
        /// </summary>
        [JsonProperty("ConnectivityDescription")]
        public string ConnectivityDescription{ get; set; }

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
            this.SetParamSimple(map, prefix + "ConnectivityStatus", this.ConnectivityStatus);
            this.SetParamSimple(map, prefix + "ConnectivityDescription", this.ConnectivityDescription);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

