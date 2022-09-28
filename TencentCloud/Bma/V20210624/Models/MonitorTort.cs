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
        /// 1
        /// </summary>
        [JsonProperty("TortSite")]
        public string TortSite{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("ICP")]
        public string ICP{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("RightNote")]
        public string RightNote{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("ObtainType")]
        public long? ObtainType{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("BlockNote")]
        public string BlockNote{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("WorkId")]
        public long? WorkId{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("WorkName")]
        public string WorkName{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("AuthStatus")]
        public long? AuthStatus{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("CommStatus")]
        public long? CommStatus{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("EvidenceStatus")]
        public long? EvidenceStatus{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("IsProducer")]
        public long? IsProducer{ get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("IsOverseas")]
        public long? IsOverseas{ get; set; }


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
            this.SetParamSimple(map, prefix + "TortSite", this.TortSite);
            this.SetParamSimple(map, prefix + "ICP", this.ICP);
            this.SetParamSimple(map, prefix + "RightNote", this.RightNote);
            this.SetParamSimple(map, prefix + "ObtainType", this.ObtainType);
            this.SetParamSimple(map, prefix + "BlockNote", this.BlockNote);
            this.SetParamSimple(map, prefix + "WorkId", this.WorkId);
            this.SetParamSimple(map, prefix + "WorkName", this.WorkName);
            this.SetParamSimple(map, prefix + "AuthStatus", this.AuthStatus);
            this.SetParamSimple(map, prefix + "CommStatus", this.CommStatus);
            this.SetParamSimple(map, prefix + "EvidenceStatus", this.EvidenceStatus);
            this.SetParamSimple(map, prefix + "IsProducer", this.IsProducer);
            this.SetParamSimple(map, prefix + "IsOverseas", this.IsOverseas);
        }
    }
}

