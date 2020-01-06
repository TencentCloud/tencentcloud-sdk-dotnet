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

namespace TencentCloud.Iai.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetectFaceResponse : AbstractModel
    {
        
        /// <summary>
        /// 请求的图片宽度。
        /// </summary>
        [JsonProperty("ImageWidth")]
        public long? ImageWidth{ get; set; }

        /// <summary>
        /// 请求的图片高度。
        /// </summary>
        [JsonProperty("ImageHeight")]
        public long? ImageHeight{ get; set; }

        /// <summary>
        /// 人脸信息列表。包含人脸坐标信息、属性信息（若需要）、质量分信息（若需要）。
        /// </summary>
        [JsonProperty("FaceInfos")]
        public FaceInfo[] FaceInfos{ get; set; }

        /// <summary>
        /// 人脸识别所用的算法模型版本。
        /// </summary>
        [JsonProperty("FaceModelVersion")]
        public string FaceModelVersion{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ImageWidth", this.ImageWidth);
            this.SetParamSimple(map, prefix + "ImageHeight", this.ImageHeight);
            this.SetParamArrayObj(map, prefix + "FaceInfos.", this.FaceInfos);
            this.SetParamSimple(map, prefix + "FaceModelVersion", this.FaceModelVersion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

