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

namespace TencentCloud.Monitor.V20230616.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListAIWorkbenchArtifactsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>每页数量</p>
        /// </summary>
        [JsonProperty("PerPage")]
        public long? PerPage{ get; set; }

        /// <summary>
        /// <p>页码</p>
        /// </summary>
        [JsonProperty("PageNo")]
        public long? PageNo{ get; set; }

        /// <summary>
        /// <p>会话ID</p>
        /// </summary>
        [JsonProperty("SessionIds")]
        public string[] SessionIds{ get; set; }

        /// <summary>
        /// <p>消息内容类型</p>
        /// </summary>
        [JsonProperty("MimeTypes")]
        public string[] MimeTypes{ get; set; }

        /// <summary>
        /// <p>排序</p><p>枚举值：</p><ul><li>ASC： 正序</li><li>DESC： 倒序</li></ul>
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PerPage", this.PerPage);
            this.SetParamSimple(map, prefix + "PageNo", this.PageNo);
            this.SetParamArraySimple(map, prefix + "SessionIds.", this.SessionIds);
            this.SetParamArraySimple(map, prefix + "MimeTypes.", this.MimeTypes);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
        }
    }
}

