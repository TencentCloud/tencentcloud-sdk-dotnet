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

    public class CreateCRObtainRequest : AbstractModel
    {
        
        /// <summary>
        /// 已存证的作品ID
        /// </summary>
        [JsonProperty("WorkId")]
        public long? WorkId{ get; set; }

        /// <summary>
        /// 侵权链接
        /// </summary>
        [JsonProperty("TortUrl")]
        public string TortUrl{ get; set; }

        /// <summary>
        /// 取证类型 1-网页取证 2-过程取证
        /// </summary>
        [JsonProperty("ObtainType")]
        public long? ObtainType{ get; set; }

        /// <summary>
        /// 侵权标题
        /// </summary>
        [JsonProperty("WorkTitle")]
        public string WorkTitle{ get; set; }

        /// <summary>
        /// 侵权平台
        /// </summary>
        [JsonProperty("TortPlat")]
        public string TortPlat{ get; set; }

        /// <summary>
        /// 过程取证的取证时长 6-300分钟
        /// </summary>
        [JsonProperty("ObtainDuration")]
        public long? ObtainDuration{ get; set; }

        /// <summary>
        /// 取证回调地址
        /// </summary>
        [JsonProperty("ObtainUrl")]
        public string ObtainUrl{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("WorkCategory")]
        public string WorkCategory{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("WorkType")]
        public string WorkType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkId", this.WorkId);
            this.SetParamSimple(map, prefix + "TortUrl", this.TortUrl);
            this.SetParamSimple(map, prefix + "ObtainType", this.ObtainType);
            this.SetParamSimple(map, prefix + "WorkTitle", this.WorkTitle);
            this.SetParamSimple(map, prefix + "TortPlat", this.TortPlat);
            this.SetParamSimple(map, prefix + "ObtainDuration", this.ObtainDuration);
            this.SetParamSimple(map, prefix + "ObtainUrl", this.ObtainUrl);
            this.SetParamSimple(map, prefix + "WorkCategory", this.WorkCategory);
            this.SetParamSimple(map, prefix + "WorkType", this.WorkType);
        }
    }
}

