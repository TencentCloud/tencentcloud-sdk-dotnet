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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ViolationUrl : AbstractModel
    {
        
        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 违规资源原始访问 URL
        /// </summary>
        [JsonProperty("RealUrl")]
        public string RealUrl{ get; set; }

        /// <summary>
        /// 快照路径，用于控制台展示违规内容快照
        /// </summary>
        [JsonProperty("DownloadUrl")]
        public string DownloadUrl{ get; set; }

        /// <summary>
        /// 违规资源当前状态
        /// forbid：已封禁
        /// release：已解封
        /// delay ： 延迟处理
        /// reject ：申诉驳回，状态仍为封禁状态
        /// complain：申诉进行中
        /// </summary>
        [JsonProperty("UrlStatus")]
        public string UrlStatus{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "RealUrl", this.RealUrl);
            this.SetParamSimple(map, prefix + "DownloadUrl", this.DownloadUrl);
            this.SetParamSimple(map, prefix + "UrlStatus", this.UrlStatus);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

