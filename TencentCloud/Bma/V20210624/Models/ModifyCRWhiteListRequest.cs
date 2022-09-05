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

namespace TencentCloud.Bma.V20210624.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyCRWhiteListRequest : AbstractModel
    {
        
        /// <summary>
        /// 白名单ID
        /// </summary>
        [JsonProperty("WhiteListId")]
        public long? WhiteListId{ get; set; }

        /// <summary>
        /// 平台名称
        /// </summary>
        [JsonProperty("PlatForm")]
        public string PlatForm{ get; set; }

        /// <summary>
        /// 平台站点链接
        /// </summary>
        [JsonProperty("PlatUrl")]
        public string PlatUrl{ get; set; }

        /// <summary>
        /// 作者ID
        /// </summary>
        [JsonProperty("AuthorId")]
        public string AuthorId{ get; set; }

        /// <summary>
        /// 作品ID
        /// </summary>
        [JsonProperty("WorksId")]
        public long? WorksId{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("WorkId")]
        public long? WorkId{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("WhiteSites")]
        public string WhiteSites{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WhiteListId", this.WhiteListId);
            this.SetParamSimple(map, prefix + "PlatForm", this.PlatForm);
            this.SetParamSimple(map, prefix + "PlatUrl", this.PlatUrl);
            this.SetParamSimple(map, prefix + "AuthorId", this.AuthorId);
            this.SetParamSimple(map, prefix + "WorksId", this.WorksId);
            this.SetParamSimple(map, prefix + "WorkId", this.WorkId);
            this.SetParamSimple(map, prefix + "WhiteSites", this.WhiteSites);
        }
    }
}

