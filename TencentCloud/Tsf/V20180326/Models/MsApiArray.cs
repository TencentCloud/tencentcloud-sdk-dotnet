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

    public class MsApiArray : AbstractModel
    {
        
        /// <summary>
        /// <p>API 请求路径</p>
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// <p>请求方法</p>
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// <p>方法描述</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>API状态 0:离线 1:在线</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>API ID</p>
        /// </summary>
        [JsonProperty("ApiId")]
        public string ApiId{ get; set; }

        /// <summary>
        /// <p>API来源</p><p>枚举值：</p><ul><li>FROM_CONSUL： 服务注册</li><li>FROM_MANUAL： 手动录入</li></ul>
        /// </summary>
        [JsonProperty("SrcTypeName")]
        public string SrcTypeName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ApiId", this.ApiId);
            this.SetParamSimple(map, prefix + "SrcTypeName", this.SrcTypeName);
        }
    }
}

