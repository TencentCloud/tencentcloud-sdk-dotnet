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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FaceDetectStatistic : AbstractModel
    {
        
        /// <summary>
        /// 人脸大小占画面平均占比
        /// </summary>
        [JsonProperty("FaceSizeRatio")]
        public float? FaceSizeRatio{ get; set; }

        /// <summary>
        /// 检测到正脸次数
        /// </summary>
        [JsonProperty("FrontalFaceCount")]
        public long? FrontalFaceCount{ get; set; }

        /// <summary>
        /// 正脸时长占比
        /// </summary>
        [JsonProperty("FrontalFaceRatio")]
        public float? FrontalFaceRatio{ get; set; }

        /// <summary>
        /// 正脸时长在总出现时常占比
        /// </summary>
        [JsonProperty("FrontalFaceRealRatio")]
        public float? FrontalFaceRealRatio{ get; set; }

        /// <summary>
        /// 人员唯一标识符
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// 检测到侧脸次数
        /// </summary>
        [JsonProperty("SideFaceCount")]
        public long? SideFaceCount{ get; set; }

        /// <summary>
        /// 侧脸时长占比
        /// </summary>
        [JsonProperty("SideFaceRatio")]
        public float? SideFaceRatio{ get; set; }

        /// <summary>
        /// 侧脸时长在总出现时常占比
        /// </summary>
        [JsonProperty("SideFaceRealRatio")]
        public float? SideFaceRealRatio{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FaceSizeRatio", this.FaceSizeRatio);
            this.SetParamSimple(map, prefix + "FrontalFaceCount", this.FrontalFaceCount);
            this.SetParamSimple(map, prefix + "FrontalFaceRatio", this.FrontalFaceRatio);
            this.SetParamSimple(map, prefix + "FrontalFaceRealRatio", this.FrontalFaceRealRatio);
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "SideFaceCount", this.SideFaceCount);
            this.SetParamSimple(map, prefix + "SideFaceRatio", this.SideFaceRatio);
            this.SetParamSimple(map, prefix + "SideFaceRealRatio", this.SideFaceRealRatio);
        }
    }
}

