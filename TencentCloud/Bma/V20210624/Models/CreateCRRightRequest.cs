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

    public class CreateCRRightRequest : AbstractModel
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
        /// 侵权标题
        /// </summary>
        [JsonProperty("TortTitle")]
        public string TortTitle{ get; set; }

        /// <summary>
        /// 侵权平台
        /// </summary>
        [JsonProperty("TortPlat")]
        public string TortPlat{ get; set; }

        /// <summary>
        /// 发函结果回调地址
        /// </summary>
        [JsonProperty("RightUrl")]
        public string RightUrl{ get; set; }

        /// <summary>
        /// x
        /// </summary>
        [JsonProperty("FileUrl")]
        public string FileUrl{ get; set; }

        /// <summary>
        /// x
        /// </summary>
        [JsonProperty("ValidStartDate")]
        public string ValidStartDate{ get; set; }

        /// <summary>
        /// x
        /// </summary>
        [JsonProperty("ValidEndDate")]
        public string ValidEndDate{ get; set; }

        /// <summary>
        /// x
        /// </summary>
        [JsonProperty("CommFileUrl")]
        public string CommFileUrl{ get; set; }

        /// <summary>
        /// x
        /// </summary>
        [JsonProperty("CommValidStartDate")]
        public string CommValidStartDate{ get; set; }

        /// <summary>
        /// x
        /// </summary>
        [JsonProperty("CommValidEndDate")]
        public string CommValidEndDate{ get; set; }

        /// <summary>
        /// x
        /// </summary>
        [JsonProperty("HomeFileUrl")]
        public string HomeFileUrl{ get; set; }

        /// <summary>
        /// x
        /// </summary>
        [JsonProperty("HomeValidStartDate")]
        public string HomeValidStartDate{ get; set; }

        /// <summary>
        /// x
        /// </summary>
        [JsonProperty("HomeValidEndDate")]
        public string HomeValidEndDate{ get; set; }

        /// <summary>
        /// x
        /// </summary>
        [JsonProperty("IsProducer")]
        public string IsProducer{ get; set; }

        /// <summary>
        /// x
        /// </summary>
        [JsonProperty("EvidenceFileUrl")]
        public string EvidenceFileUrl{ get; set; }

        /// <summary>
        /// x
        /// </summary>
        [JsonProperty("EvidenceValidStartDate")]
        public string EvidenceValidStartDate{ get; set; }

        /// <summary>
        /// x
        /// </summary>
        [JsonProperty("EvidenceValidEndDate")]
        public string EvidenceValidEndDate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WorkId", this.WorkId);
            this.SetParamSimple(map, prefix + "TortUrl", this.TortUrl);
            this.SetParamSimple(map, prefix + "TortTitle", this.TortTitle);
            this.SetParamSimple(map, prefix + "TortPlat", this.TortPlat);
            this.SetParamSimple(map, prefix + "RightUrl", this.RightUrl);
            this.SetParamSimple(map, prefix + "FileUrl", this.FileUrl);
            this.SetParamSimple(map, prefix + "ValidStartDate", this.ValidStartDate);
            this.SetParamSimple(map, prefix + "ValidEndDate", this.ValidEndDate);
            this.SetParamSimple(map, prefix + "CommFileUrl", this.CommFileUrl);
            this.SetParamSimple(map, prefix + "CommValidStartDate", this.CommValidStartDate);
            this.SetParamSimple(map, prefix + "CommValidEndDate", this.CommValidEndDate);
            this.SetParamSimple(map, prefix + "HomeFileUrl", this.HomeFileUrl);
            this.SetParamSimple(map, prefix + "HomeValidStartDate", this.HomeValidStartDate);
            this.SetParamSimple(map, prefix + "HomeValidEndDate", this.HomeValidEndDate);
            this.SetParamSimple(map, prefix + "IsProducer", this.IsProducer);
            this.SetParamSimple(map, prefix + "EvidenceFileUrl", this.EvidenceFileUrl);
            this.SetParamSimple(map, prefix + "EvidenceValidStartDate", this.EvidenceValidStartDate);
            this.SetParamSimple(map, prefix + "EvidenceValidEndDate", this.EvidenceValidEndDate);
        }
    }
}

