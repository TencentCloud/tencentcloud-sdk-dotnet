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

    public class MonitorTort : AbstractModel
    {
        
        /// <summary>
        /// 侵权信息ID
        /// </summary>
        [JsonProperty("TortId")]
        public long? TortId{ get; set; }

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
        /// 侵权链接
        /// </summary>
        [JsonProperty("TortURL")]
        public string TortURL{ get; set; }

        /// <summary>
        /// 侵权链接发布时间
        /// </summary>
        [JsonProperty("PubTime")]
        public string PubTime{ get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        [JsonProperty("Author")]
        public string Author{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("DetectTime")]
        public string DetectTime{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("ObtainStatus")]
        public long? ObtainStatus{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("RightStatus")]
        public long? RightStatus{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("BlockStatus")]
        public long? BlockStatus{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("TortNum")]
        public string TortNum{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("ObtainNote")]
        public string ObtainNote{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("WorkTitle")]
        public string WorkTitle{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TortId", this.TortId);
            this.SetParamSimple(map, prefix + "TortTitle", this.TortTitle);
            this.SetParamSimple(map, prefix + "TortPlat", this.TortPlat);
            this.SetParamSimple(map, prefix + "TortURL", this.TortURL);
            this.SetParamSimple(map, prefix + "PubTime", this.PubTime);
            this.SetParamSimple(map, prefix + "Author", this.Author);
            this.SetParamSimple(map, prefix + "DetectTime", this.DetectTime);
            this.SetParamSimple(map, prefix + "ObtainStatus", this.ObtainStatus);
            this.SetParamSimple(map, prefix + "RightStatus", this.RightStatus);
            this.SetParamSimple(map, prefix + "BlockStatus", this.BlockStatus);
            this.SetParamSimple(map, prefix + "TortNum", this.TortNum);
            this.SetParamSimple(map, prefix + "ObtainNote", this.ObtainNote);
            this.SetParamSimple(map, prefix + "WorkTitle", this.WorkTitle);
        }
    }
}

