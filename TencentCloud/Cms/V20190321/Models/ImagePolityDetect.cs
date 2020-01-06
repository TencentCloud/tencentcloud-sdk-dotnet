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

namespace TencentCloud.Cms.V20190321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImagePolityDetect : AbstractModel
    {
        
        /// <summary>
        /// 恶意类型
        /// 100：正常 
        /// 20001：政治
        /// </summary>
        [JsonProperty("EvilType")]
        public long? EvilType{ get; set; }

        /// <summary>
        /// 处置判定  0：正常 1：可疑
        /// </summary>
        [JsonProperty("HitFlag")]
        public long? HitFlag{ get; set; }

        /// <summary>
        /// 命中的人脸名称
        /// </summary>
        [JsonProperty("FaceNames")]
        public string[] FaceNames{ get; set; }

        /// <summary>
        /// 关键词明细
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }

        /// <summary>
        /// 命中的政治物品名称
        /// </summary>
        [JsonProperty("PolityItems")]
        public string[] PolityItems{ get; set; }

        /// <summary>
        /// 政治（人脸）分：分值范围 0-100，分数越高可疑程度越高
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EvilType", this.EvilType);
            this.SetParamSimple(map, prefix + "HitFlag", this.HitFlag);
            this.SetParamArraySimple(map, prefix + "FaceNames.", this.FaceNames);
            this.SetParamArraySimple(map, prefix + "Keywords.", this.Keywords);
            this.SetParamArraySimple(map, prefix + "PolityItems.", this.PolityItems);
            this.SetParamSimple(map, prefix + "Score", this.Score);
        }
    }
}

