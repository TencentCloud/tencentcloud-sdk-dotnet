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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateRecordDetails : AbstractModel
    {
        
        /// <summary>
        /// 新旧证书更新云资源的云资源类型：
        /// - clb
        /// - cdn
        /// - ddos
        /// - live
        /// - vod
        /// - waf
        /// - apigateway
        /// - teo
        /// - tke
        /// - cos
        /// - tse
        /// - tcb
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 该云资源更新详情
        /// </summary>
        [JsonProperty("List")]
        public UpdateRecordDetail[] List{ get; set; }

        /// <summary>
        /// 该云资源更新资源总数
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamArrayObj(map, prefix + "List.", this.List);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
        }
    }
}

